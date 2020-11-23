using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Competition.EF.Models;
using Competition.Web.Models;
using Newtonsoft.Json;

namespace Competition.Web.Controllers
{
    public class ReportController : Controller
    {
        CompetitionDbContext db = new CompetitionDbContext();
        // GET: Report
        public ActionResult Index()
        {
            ViewBag.PageName = "Report";
            return View();
        }

        public ActionResult CompanyRank()
        {
            ViewBag.PageName = "Report";
            return View();
        }

        [ValidateInput(false)]
        public ActionResult CompanyRankReporGridViewPartial()
        {
            List<CompanyRank> table = GetComanyRank();

            return PartialView("_CompanyRankReporGridViewPartial", table.ToList());
        }

        private List<CompanyRank> GetComanyRank()
        {
            var model = GetPersonalRank("", "");


            var data = from personal in model
                       group personal by personal.Company into g
                       orderby g.Sum(p => p.TotalScore) descending
                       select new
                       {

                           CompanyName = g.FirstOrDefault().Company,
                           Score = g.Sum(p => p.TotalScore),
                           Count = g.Sum(p => p.Count)
                       }
                       ;
            var table = data.AsEnumerable().Select((score, index) => new CompanyRank
            {
                CompanyName = score.CompanyName,
                Score = score.Score.Value,
                Count = score.Count,
                Rank = index + 1
            });
            return table.ToList();
        }

        [ValidateInput(false)]
        public ActionResult CompanyRankDetailGridViewPartial(string company)
        {

            ViewBag.Company = company;
            List<PersonalRank> list = GetPersonalRank(null, company);

            return PartialView("_CompanyRankDetailGridViewPartial", list);
        }
        public ActionResult EventRank_ME()
        {
            ViewBag.PageName = "Report";
            ViewBag.Pro = "ME";
            ViewBag.EventList = db.Events.Where(t => t.Pro.Contains("ME")).ToList();
            return View();
        }
        public ActionResult EventRank_AV()
        {
            ViewBag.PageName = "Report";
            ViewBag.Pro = "AV";
            ViewBag.EventList = db.Events.Where(t => t.Pro.Contains("AV")).ToList();
            return View();
        }
        [ValidateInput(false)]
        public ActionResult EventRankGridViewPartial(int? eventId, string pro, string time)
        {

            return PartialView("_EventRankGridViewPartial", GetEventRank(eventId, pro, time));
        }

        private List<EventRank> GetEventRank(int? eventId, string pro, string time)
        {
            var data = db.Schedules.Where(t => true);
            if (eventId != null)
            {
                data = data.Where(s => s.EventId == eventId);
            }
            if (!string.IsNullOrEmpty(pro))
            {
                data = data.Where(s => s.Competitor.Pro == pro);
            }
            if (!string.IsNullOrEmpty(time))
            {
                try
                {
                    DateTime endTime = Convert.ToDateTime(time);
                    data = data.Where(s => s.PlanBeginTime <= endTime);
                }
                finally
                {

                }

            }

            ViewBag.Pro = pro;
            Event @event = db.Events.Find(eventId);
            ViewBag.EventName = @event == null ? "" : @event.Name;

            var table = data.AsEnumerable().OrderByDescending(s => s.MarkAVG).Select((schedule, Index) => new EventRank
            {
                Competitor_Company = schedule.Competitor.Company.Name,
                Competitor_Name = schedule.Competitor.Name,
                Competitor_Pro = schedule.Competitor.Pro,
                Competitor_Staffid = schedule.Competitor.StaffId,
                EventName = schedule.Event.Name,
                Score = schedule.MarkAVG,
                Rank = Index + 1
            });
            return table.ToList();
        }
        private List<EventRank> GetEventRank(int[] eventIds, string pro, string time)
        {
            var data = db.Schedules.Where(t => true);
            if (eventIds.Count() > 0)
            {
                data = data.Where(s => eventIds.Contains(s.EventId));
            }
            if (!string.IsNullOrEmpty(pro))
            {
                data = data.Where(s => s.Competitor.Pro == pro);
            }
            if (!string.IsNullOrEmpty(time))
            {
                try
                {
                    DateTime endTime = Convert.ToDateTime(time);
                    data = data.Where(s => s.PlanBeginTime <= endTime);
                }
                finally
                {

                }

            }

            ViewBag.Pro = pro;
            var @events = db.Events.Where(s => eventIds.Contains(s.Id));
            ViewBag.EventName = "综合项目";
            var table = from schedule in data
                        group schedule by schedule.CompetitorId into g
                        select new EventRank()
                        {
                            EventName = "综合项目",
                            Score = g.Sum(c => c.Scores.Average(k => k.Mark) / 3.0),  //不同专业各3个项目，每个项目先把100分换成33.3分，然后再累加，当做一个排故综合的分数。目前只能写死了，以后需求有变要改
                            Competitor_Name = g.FirstOrDefault().Competitor.Name,
                            Competitor_Pro = g.FirstOrDefault().Competitor.Pro,
                            Competitor_Staffid = g.FirstOrDefault().Competitor.StaffId,
                            Competitor_Company = g.FirstOrDefault().Competitor.Company.Name
                        };
            table = table.OrderByDescending(t => t.Score);
                        

            //var table = data.AsEnumerable().GroupBy(s=>s.CompetitorId).OrderByDescending(s => s).Select((schedule, Index) => new EventRank
            //{
            //    Competitor_Company = schedule.Competitor.Company.Name,
            //    Competitor_Name = schedule.Competitor.Name,
            //    Competitor_Pro = schedule.Competitor.Pro,
            //    Competitor_Staffid = schedule.Competitor.StaffId,
            //    EventName = schedule.Event.Name,
            //    Score = schedule.MarkAVG,
            //    Rank = Index + 1
            //});
            return table.ToList();
        }


        [ValidateInput(false)]
        public ActionResult ScorePivotGridPartial()
        {
            var model = db.Schedules;
            return PartialView("_ScorePivotGridPartial", model.ToList());
        }



        public ActionResult PersonalAVRank()
        {
            ViewBag.PageName = "Report";

            return View();
        }

        public ActionResult PersonalMERank()
        {
            ViewBag.PageName = "Report";

            return View();
        }

        [ValidateInput(false)]
        public ActionResult PersonalRankGridViewPartial(string pro, string company)
        {
            ViewBag.Pro = pro;
            ViewBag.Company = company;
            List<PersonalRank> list = GetPersonalRank(pro, company);

            return PartialView("_PersonalRankGridViewPartial", list);
        }

        private List<PersonalRank> GetPersonalRank(string pro, string company)
        {
            var data = db.Schedules.Where(t => true).ToList();
            if (!string.IsNullOrEmpty(pro))
            {
                data = data.Where(s => s.Competitor.Pro == pro).ToList();
            }
            if (!string.IsNullOrEmpty(company))
            {
                data = data.Where(s => s.Competitor.Company.Name == company).ToList();
            }

            var data2 = from schedule in data
                        group schedule by schedule.CompetitorId into g
                        select new
                        {
                            g.Key,
                            Count = g.Sum(c => c.Scores.Count),
                            Company = g.FirstOrDefault().Competitor.Company.Name,
                            g.FirstOrDefault().Competitor.Name,
                            g.FirstOrDefault().Competitor.Pro,
                            g.FirstOrDefault().Competitor.StaffId,
                            Bishi = g.FirstOrDefault(t => t.Event.Name == "笔试"),//总分200，转为总成绩的30分
                            ReplaceME = g.FirstOrDefault(t => t.Event.Name == "部件拆装(ME)"),
                            ReplaceAV = g.FirstOrDefault(t => t.Event.Name == "部件拆装(AV)"),
                            THS = g.FirstOrDefault(t => t.Event.Name == "水平安定面自动配平系统排故"),
                            Radar = g.FirstOrDefault(t => t.Event.Name == "气象雷达系统综合施工"),
                            Seal = g.FirstOrDefault(t => t.Event.Name == "天线拆装和密封项目"),
                            CVR = g.FirstOrDefault(t => t.Event.Name == "CVR系统测试和排故)"),
                            Lockwire = g.FirstOrDefault(t => t.Event.Name == "保险综合项目"),
                            Call = g.FirstOrDefault(t => t.Event.Name == "驾驶舱地面呼叫系统排故"),
                            Jingujian = g.FirstOrDefault(t => t.Event.Name == "量具和紧固件拆装"),
                            Caozong = g.FirstOrDefault(t => t.Event.Name == "飞行操纵系统维护"),
                            Biaoxian = g.FirstOrDefault(t => t.Event.Name == "标线综合施工"),
                            Shouce = g.FirstOrDefault(t => t.Event.Name == "技术资料综合运用")

                        };
            var table = data2.AsEnumerable().Select((score, Index) => new PersonalRank
            {
                Company = score.Company,
                Name = score.Name,
                Pro = score.Pro,
                Staffid = score.StaffId,
                Count = score.Count,
                Bishi = score.Bishi != null ? score.Bishi.MarkAVG : null,
                ReplaceME = score.ReplaceME != null ? score.ReplaceME.MarkAVG : null,
                ReplaceAV = score.ReplaceAV != null ? score.ReplaceAV.MarkAVG : null,
                THS = score.THS != null ? score.THS.MarkAVG : null,
                Radar = score.Radar != null ? score.Radar.MarkAVG : null,
                Seal = score.Seal != null ? score.Seal.MarkAVG : null,
                CVR = score.CVR != null ? score.CVR.MarkAVG : null,
                Lockwire = score.Lockwire != null ? score.Lockwire.MarkAVG : null,
                Call = score.Call != null ? score.Call.MarkAVG : null,
                Jingujian = score.Jingujian != null ? score.Jingujian.MarkAVG : null,
                Caozong = score.Caozong != null ? score.Caozong.MarkAVG : null,
                Biaoxian = score.Biaoxian != null ? score.Biaoxian.MarkAVG : null,
                Shouce = score.Shouce != null ? score.Shouce.MarkAVG : null
            });
            int i = 1;
            var list = table.OrderByDescending(s => s.TotalScore).ToList();
            foreach (var item in list)
            {
                item.Rank = i++;
            }

            return list;
        }

        public ActionResult test()
        {
            // DXCOMMENT: Pass a data model for GridView

            List<CompanyRank> companyRanks = GetComanyRank();
            List<string[]> companyRanksList = new List<string[]>();
            foreach (CompanyRank rank in companyRanks)
            {
                string[] arr = { rank.CompanyName, rank.Score.ToString(), rank.Count.ToString() };
                companyRanksList.Add(arr);
            }
            ViewBag.companyRanksList = JsonConvert.SerializeObject(companyRanksList);
            ViewBag.MERanksList = GetPersonalRankDataString("ME");
            ViewBag.AVRanksList = GetPersonalRankDataString("AV");
            ViewBag.ReplaceMEList = GetEventRankDataString("部件拆装(ME)", "ME", null);
            ViewBag.ReplaceAVList = GetEventRankDataString("部件拆装(AV)", "AV", null);
            ViewBag.RadarList = GetEventRankDataString("气象雷达系统综合施工", "AV", null);
            ViewBag.SealList = GetEventRankDataString("天线拆装和密封项目", "AV", null);
            ViewBag.LockwireAVList = GetEventRankDataString("保险综合项目", "AV", null);
            ViewBag.LockwireMEList = GetEventRankDataString("保险综合项目", "ME", null);
            ViewBag.JingujianList = GetEventRankDataString("量具和紧固件拆装", "ME", null);
            ViewBag.CaozongList = GetEventRankDataString("飞行操纵系统维护", "ME", null);
            ViewBag.BiaoxianMEList = GetEventRankDataString("标线综合施工", "ME", null);
            ViewBag.BiaoxianAVList = GetEventRankDataString("标线综合施工", "AV", null);
            ViewBag.PaiguMEList = GetEventRankDataString("综合排故", "ME", null);
            ViewBag.PaiguAVList = GetEventRankDataString("综合排故", "AV", null);

            ViewBag.schedule_count = db.Schedules.Count();
            ViewBag.schedule_complete = db.Schedules.Where(s => s.Status == SchedulStatus.Complete).Count();
            ViewBag.schedule_uncomplete = ViewBag.schedule_count - ViewBag.schedule_complete;
            ViewBag.schedule_progress = Math.Round(1.0 * ViewBag.schedule_complete / ViewBag.schedule_count, 2) * 100;


            return View();
        }
        public string GetEventRankDataString(string eventName, string pro, string time)
        {
            List<EventRank> table = new List<EventRank>();
            if (eventName == "综合排故")
            {
                int[] eventIds = db.Events.Where(s => s.Pro.Contains(pro)).Where(s => s.Name == "技术资料综合运用" || s.Name == "水平安定面自动配平系统排故" || s.Name == "CVR系统测试和排故" || s.Name == "驾驶舱地面呼叫系统排故").Select(s => s.Id).ToArray();
                table = GetEventRank(eventIds, pro, time).Where(t => t.Score != null).ToList();

            }
            else
            {
                Event @event = db.Events.Where(s => s.Pro.Contains(pro) && s.Name == eventName).FirstOrDefault();
                table = GetEventRank(@event.Id, pro, time).Where(t => t.Score != null).ToList();
            }


            List<string[]> list = new List<string[]>();
            foreach (EventRank rank in table)
            {
                string[] arr = { rank.Competitor_Name, rank.Competitor_Company, rank.Score.Value.ToString("f2") };  //暂时只显示排名，不显示分数
                list.Add(arr);
            }
            return JsonConvert.SerializeObject(list);
        }

        public string GetPersonalRankDataString(string pro)
        {

            List<PersonalRank> table = GetPersonalRank(pro, null).ToList();

            List<string[]> list = new List<string[]>();
            foreach (PersonalRank rank in table)
            {
                string[] arr = { rank.Name, rank.Company, rank.Count.ToString(), rank.TotalScore.ToString() };
                list.Add(arr);
            }
            return JsonConvert.SerializeObject(list);
        }
        public ActionResult test2()
        {
            return View();
        }
    }
}
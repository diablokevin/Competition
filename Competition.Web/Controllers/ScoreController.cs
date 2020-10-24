using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using Competition.EF.Models;
using Competition.Web.Models;
using DevExpress.Web.Mvc;

namespace Competition.Web.Controllers
{
    public class ScoreController : Controller
    {
        // GET: Score
        CompetitionDbContext db = new CompetitionDbContext();
        public ActionResult Index()
        {
            return View();


        }



        [ValidateInput(false)]
        public ActionResult ScoreGridViewPartial()
        {
            var model = db.Scores.Include(s => s.Schedule).OrderByDescending(s=>s.JudgeTime);
            //ViewBag.Eventlist = db.Events.ToList();
            //ViewBag.Companylist = db.Companies.ToList();
            //ViewBag.Schedulelist = db.Schedules.ToList();
            return PartialView("_ScoreGridViewPartial", model.ToList());
        }

        public ActionResult ScoreEditFormPartial(int? Id)
        {
            //ViewBag.Eventlist = db.Events.ToList();
            //ViewBag.Companylist = db.Companies.ToList();
            ViewBag.Schedulelist = db.Schedules.OrderBy(s=>s.EventId).OrderBy(s=>s.Competitor.Name).ToList();
            if (Id != null)
            { 
                var model = db.Scores.Find(Id);

                return PartialView("_ScoreEditFormPartial", model ?? new Score());
            }
            return PartialView("_ScoreEditFormPartial", new Score());

        }

        [HttpPost, ValidateInput(false)]
        public ActionResult ScoreGridViewPartialAddNew(Score item)
        {
            var model = db.Scores;
            if (ModelState.IsValid)
            {
                try
                {
                    item.JudgeTime = DateTime.Now;
                    item.ModifyTime = DateTime.Now;
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_ScoreGridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult ScoreGridViewPartialUpdate(Score item)
        {
            var model = db.Scores.Include(s => s.Schedule).OrderByDescending(s => s.JudgeTime);
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.Id == item.Id);
                    if (modelItem != null)
                    {
                        modelItem.ModifyTime = DateTime.Now;
                        this.UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_ScoreGridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult ScoreGridViewPartialDelete(System.Int32 Id)
        {
            var model = db.Scores;
            if (Id >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.Id == Id);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_ScoreGridViewPartial", model.ToList());
        }





        //[ValidateInput(false)]
        //public ActionResult ScoreJudgeGridViewPartial()
        //{
        //    var judgeStaffid = User.Identity.Name;
        //    var eventId=db.Judges.Where(j => j.StaffId == judgeStaffid).FirstOrDefault().EventId;
        //    var model = db.Scores.Where(s=>s.Schedule.EventId==eventId ).OrderBy(s=>s.Schedule.PlanBeginTime);
        //    return PartialView("_ScoreJudgeGridViewPartial", model.ToList());
        //}
        //public ActionResult ScoreJudgeEditFormPartial(int? Id)
        //{

        //    if (Id != null)
        //    {
        //        var model = db.Schedules.Find(Id);

        //        return PartialView("_ScoreJudgeEditFormPartial", model ?? new Models.Schedule());
        //    }
        //    return PartialView("_ScoreJudgeEditFormPartial", new Models.Schedule());

        //}
        //[HttpPost, ValidateInput(false)]
        //public ActionResult ScoreJudgeGridViewPartialAddNew(ScoringSystem.Models.Score item)
        //{
        //    var judgeStaffid = User.Identity.Name;
        //    var judge = db.Judges.Where(j => j.StaffId == judgeStaffid).FirstOrDefault();
        //    var eventId = judge.EventId;

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            item.JudgeId = judge.Id;
        //            item.JudgeTime = DateTime.Now;
        //            item.ModifyTime = DateTime.Now;
        //            db.Scores.Add(item);
        //            db.SaveChanges();
        //        }
        //        catch (Exception e)
        //        {
        //            ViewData["EditError"] = e.Message;
        //        }
        //    }
        //    else
        //        ViewData["EditError"] = "Please, correct all errors.";

        //    var model = db.Scores.Where(s => s.Schedule.EventId == eventId).OrderBy(s => s.Schedule.PlanBeginTime);
        //    return PartialView("_ScoreJudgeGridViewPartial", model.ToList());
        //}
        //[HttpPost, ValidateInput(false)]
        //public ActionResult ScoreJudgeGridViewPartialUpdate(ScoringSystem.Models.Score item)
        //{
        //    var judgeStaffid = User.Identity.Name;
        //    var judge = db.Judges.Where(j => j.StaffId == judgeStaffid).FirstOrDefault();
        //    var eventId = judge.EventId;

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var modelItem = db.Scores.FirstOrDefault(it => it.Id == item.Id);
        //            if (modelItem != null)
        //            {
        //                modelItem.JudgeId = judge.Id;
        //                if (modelItem.JudgeTime==null)
        //                {
        //                    modelItem.JudgeTime = DateTime.Now;
        //                }                            
        //                modelItem.ModifyTime = DateTime.Now;
        //                this.UpdateModel(modelItem);
        //                db.SaveChanges();
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            ViewData["EditError"] = e.Message;
        //        }
        //    }
        //    else
        //        ViewData["EditError"] = "Please, correct all errors.";

        //    var model = db.Scores.Where(s => s.Schedule.EventId == eventId).OrderBy(s => s.Schedule.PlanBeginTime);

        //    return PartialView("_ScoreJudgeGridViewPartial", model.ToList());
        //}
        //[HttpPost, ValidateInput(false)]
        //public ActionResult ScoreJudgeGridViewPartialDelete(System.Int32 Id)
        //{
        //    var model = db.Schedules;
        //    if (Id >= 0)
        //    {
        //        try
        //        {
        //            var item = model.FirstOrDefault(it => it.Id == Id);
        //            if (item != null)
        //                model.Remove(item);
        //            db.SaveChanges();
        //        }
        //        catch (Exception e)
        //        {
        //            ViewData["EditError"] = e.Message;
        //        }
        //    }
        //    return PartialView("_ScoreJudgeGridViewPartial", model.ToList());
        //}


        [ValidateInput(false)]
        public ActionResult ScoreFinishGridViewPartial()
        {
            var judgeStaffid = User.Identity.Name;
           // var eventId = db.Judges.Where(j => j.StaffId == judgeStaffid).FirstOrDefault().EventId;
            var model = db.Scores.Where(s => s.Judge.StaffId == judgeStaffid).OrderByDescending(s => s.JudgeTime);


            return PartialView("_ScoreFinishGridViewPartial", model.ToList());
        }

        [ValidateInput(false)]
        public ActionResult ScoreCompetitorGridViewPartial()
        {
            var competitorStaffid = User.Identity.Name;
            var competitor = db.Competitors.Where(j => j.StaffId == competitorStaffid).FirstOrDefault();

            //var model = db.Schedules.Where(s => s.CompetitorId == competitor.Id).OrderBy(s => s.PlanBeginTime);
            var model = db.Schedules.Where(s => s.CompetitorId == competitor.Id).Include(s => s.Scores).Include(s=>s.Competitor).OrderBy(s => s.PlanBeginTime);
           
            return PartialView("_ScoreCompetitorGridViewPartial", model.ToList());
        }

        public ActionResult ScoreJudgeEditFormPartial(int? ScheduleId)
        {

            if (ScheduleId != null)
            {
                ScoreDetailViewModel model = GetNewScoreDetailViewModel(ScheduleId);
                return PartialView("_ScoreJudgeEditFormPartial", model ?? new ScoreDetailViewModel());
            }
            return PartialView("_ScoreJudgeEditFormPartial", new ScoreDetailViewModel());

        }

        private ScoreDetailViewModel GetNewScoreDetailViewModel(int? ScheduleId)
        {
            var model = new ScoreDetailViewModel();
            //在属性里加了默认值，这里就不需要了
            //model.Score = new Score();
            //model.ScoreDetails = new List<ScoreDetail>();
            var schedule = db.Schedules.Find(ScheduleId);
            model.Score.ScheduleId = ScheduleId.Value;
            model.Score.Schedule = schedule;
            var judgeStaffid = User.Identity.Name;
            var judge = db.Judges.Where(j => j.StaffId == judgeStaffid).FirstOrDefault();

            model.Score.JudgeId = judge.Id;
            model.Score.Judge = judge;
            var criterias = db.EventCriterias.Where(c => c.EventId == schedule.EventId);
            foreach (EventCriteria criteria in criterias)
            {
                ScoreDetail detail = new ScoreDetail();
                detail.EventCriteriaId = criteria.Id;
                detail.EventCriteria = criteria;
                model.ScoreDetails.Add(detail);

            }
           
            return model;
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult ScoreJudgeEditFormPartial(ScoreDetailViewModel item)
        {

            if (ModelState.IsValid)
            {
                var judgeStaffid = User.Identity.Name;
                var judge = db.Judges.Where(j => j.StaffId == judgeStaffid).FirstOrDefault();
                var schedule = db.Schedules.Find(item.Score.ScheduleId);
                if (db.Scores.Where(s=>s.JudgeId==judge.Id&&s.ScheduleId==item.Score.ScheduleId).Count()==0)
                {
                    item.Score.JudgeId = judge.Id;
                    item.Score.JudgeTime = DateTime.Now;
                    item.Score.ModifyTime = DateTime.Now;
                    item.Score.Mark = item.ScoreDetails.Sum(s => s.Mark);
                    int timelimit =Convert.ToInt32( item.Score.Schedule.Event.TimeLimit.TotalSeconds);
                    int min = item.Score.TimeConsume_minute.Value;
                    int sec = item.Score.TimeConsume_second.Value;
                    double timescore= Math.Floor((double)(timelimit - 60 * min - sec) / 30) * 0.5;
                    item.Score.Mark += timescore;
                    schedule.Status = SchedulStatus.Complete;
                    if (item.Score.Mark < 0)
                    {
                        item.Score.Mark = 0;
                    }
                    db.Scores.Add(item.Score);
                    db.SaveChanges();
                    foreach (var detail in item.ScoreDetails)
                    {
                        detail.ScoreId = item.Score.Id;
                        db.ScoreDetails.Add(detail);
                    }
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "请勿重复提交";
                   
                    return PartialView("_ScoreJudgeEditFormPartial", GetNewScoreDetailViewModel(item.Score.ScheduleId));
                }
                
            }
            ViewBag.Error = ModelState.Values;
            return PartialView("_ScoreJudgeEditFormPartial", GetNewScoreDetailViewModel(item.Score.ScheduleId));

        }

        public ActionResult ScoreJudgeViewFormPartial(int? ScoreId)
        {

            if (ScoreId != null)
            {
                var item = db.Scores.FirstOrDefault(i => i.Id == ScoreId);
                var schedule=db.Schedules.FirstOrDefault(i => i.Id == item.ScheduleId);
                item.Schedule = schedule;
                var model = new ScoreDetailViewModel();
                model.Score = item;
                model.ScoreDetails = item.ScoreDetail.ToList();

                //这里需要EventCriterias与scoredetail leftjoin,暂时先只列出scoredetail
              
               
                //var criterias = db.EventCriterias.Where(c => c.EventId == schedule.EventId);
                //foreach (EventCriteria criteria in criterias)
                //{
                //    ScoreDetail detail = new ScoreDetail();
                //    detail.EventCriteriaId = criteria.Id;
                //    detail.EventCriteria = criteria;
                //    model.ScoreDetails.Add(detail);

                //}
                return PartialView("_ScoreJudgeViewFormPartial", model ?? new ScoreDetailViewModel());
            }
            return PartialView("_ScoreJudgeViewFormPartial", new ScoreDetailViewModel());

        }
    }
}
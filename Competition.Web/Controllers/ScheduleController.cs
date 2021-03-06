﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Competition.EF.Models;
namespace Competition.Web.Controllers
{
    public class ScheduleController : Controller
    {
        CompetitionDbContext db = new CompetitionDbContext();

        // GET: Schedule
        public ActionResult Index()
        {
            ViewBag.PageName = "Setting";
            return View();
        }



        [ValidateInput(false)]
        public ActionResult ScheduleGridViewPartial()
        {
            var model = db.Schedules;
            return PartialView("_ScheduleGridViewPartial", model.ToList());
        }
        public ActionResult Multi(int? id)
        { return View(); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Multi()
        {
            if (ModelState.IsValid)
            {
                string content = Request["List"];
                ViewBag.Content = content;

                List<string> t = content.Split('\r', '\n').ToList();
                ViewBag.Count = t.Count;
                ViewBag.FaultCount = 0;
                foreach (string item in t)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        Schedule schedule = new Schedule();
                        try
                        {
                            string date = item.Split('\t')[0];
                            string eventName = item.Split('\t')[1];
                            string competitorNum = item.Split('\t')[2];
                            string begin = item.Split('\t')[3];
                            string end = item.Split('\t')[4];

                            schedule.PlanBeginTime = Convert.ToDateTime(date + " " + begin);
                            schedule.PlanEndTime = Convert.ToDateTime(date + " " + end);
                            schedule.EventId = db.Events.Where(c => c.Name == eventName).First().Id;
                            var testData = db.Competitors.ToList();
                            var competitors = db.Competitors.Where(c => c.Race_num == competitorNum);

                            schedule.CompetitorId = competitors.FirstOrDefault().Id;
                            db.Schedules.Add(schedule);


                        }
                        catch (Exception e)
                        {
                            ViewData["EditError"] = e.Message;
                            ViewBag.FaultCount++;
                        }

                    }
                }
                ViewBag.SuccessCount = db.SaveChanges();
                return View();
            }


            return View();
        }

        public ActionResult BishiScoreMulti(int? id)
        { return View(); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BishiScoreMulti()
        {
            if (ModelState.IsValid)
            {
                string content = Request["List"];
                ViewBag.Content = content;

                List<string> t = content.Split('\r', '\n').ToList();
                ViewBag.Count = t.Count;
                ViewBag.FaultCount = 0;
                foreach (string item in t)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        
                        try
                        {
                            string competitorNum = item.Split('\t')[0];
                            double mark = Convert.ToDouble( item.Split('\t')[1]);
                            int eventId = db.Events.Where(c => c.Name == "笔试").First().Id;                      
                            int competitorsId = db.Competitors.Where(c => c.Race_num == competitorNum).FirstOrDefault().Id;
                            var schedule = db.Schedules.Where(c => c.EventId == eventId && c.CompetitorId == competitorsId);
                            Score score = new Score();
                            score.Mark = mark;
                            score.JudgeTime = DateTime.Now;
                            score.ModifyTime = DateTime.Now;
                            score.ScheduleId = schedule.FirstOrDefault().Id;                            
                            db.Scores.Add(score);

                        }
                        catch (Exception e)
                        {
                            ViewData["EditError"] = e.Message;
                            ViewBag.FaultCount++;
                        }

                    }
                }
                ViewBag.SuccessCount = db.SaveChanges();
                return View();
            }


            return View();
        }




        [ValidateInput(false)]
        public ActionResult ScheduleJudgeGridViewPartial()
        {
            var judgeStaffid = User.Identity.Name;
            var judge = db.Judges.Where(j => j.StaffId == judgeStaffid).FirstOrDefault();
            var eventId = judge.EventId;
            var model = db.Schedules.Where(s => s.EventId == eventId&&s.Status!=SchedulStatus.Complete).OrderBy(s => s.PlanBeginTime);  //调整逻辑，加入status的筛选逻辑，同时还需要与提交分数时，如何判断complete的逻辑相结合
            var test = from schedule in model
                       where  !(from score in schedule.Scores
                               where score.JudgeId == judge.Id
                               select score.ScheduleId).Contains(schedule.Id)
                       select schedule;
         
            return PartialView("_ScheduleJudgeGridViewPartial", test.ToList());
        }
        //public ActionResult ScheduleJudgeEditFormPartial(int? Id)
        //{

        //    if (Id != null)
        //    {
        //        var model = db.Schedules.Find(Id);

        //        return PartialView("_ScheduleJudgeEditFormPartial", model ?? new Models.Schedule());
        //    }
        //    return PartialView("_ScheduleJudgeEditFormPartial", new Models.Schedule());

        //}
        //[HttpPost, ValidateInput(false)]
        //public ActionResult ScheduleJudgeGridViewPartialAddNew(ScoringSystem.Models.Score item)
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
        //    return PartialView("_ScheduleJudgeGridViewPartial", model.ToList());
        //}
        //[HttpPost, ValidateInput(false)]
        //public ActionResult ScheduleJudgeGridViewPartialUpdate(ScoringSystem.Models.Score item)
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
        //                if (modelItem.JudgeTime == null)
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

        //    return PartialView("_ScheduleJudgeGridViewPartial", model.ToList());
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
        //    return PartialView("_ScheduleJudgeGridViewPartial", model.ToList());
        //}

    }

}

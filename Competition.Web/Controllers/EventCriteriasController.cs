using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Competition.EF.Models;
using System.Text.RegularExpressions;

namespace Competition.Web.Controllers
{
    public class EventCriteriasController : Controller
    {
        private CompetitionDbContext db = new CompetitionDbContext();

        // GET: EventCriterias
        public ActionResult Index()
        {
            ViewBag.PageName = "Setting";
            return View();
        }
               

        [ValidateInput(false)]
        public ActionResult EventCriteriasGridViewPartial()
        {
            var model = db.EventCriterias;
            var query= from eventitem in db.Events
                       select new
                       {
                           Id = eventitem.Id,
                           Name = eventitem.Name
                       };
            ViewBag.EventIds = query.ToList();
            return PartialView("_EventCriteriasGridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult EventCriteriasGridViewPartialAddNew(Competition.EF.Models.EventCriteria item)
        {
            var model = db.EventCriterias;
            if (ModelState.IsValid)
            {
                try
                {
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
            return PartialView("_EventCriteriasGridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EventCriteriasGridViewPartialUpdate(Competition.EF.Models.EventCriteria item)
        {
            var model = db.EventCriterias;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.Id == item.Id);
                    if (modelItem != null)
                    {
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
            return PartialView("_EventCriteriasGridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EventCriteriasGridViewPartialDelete(System.Int32 Id)
        {
            var model = db.EventCriterias;
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
            return PartialView("_EventCriteriasGridViewPartial", model.ToList());
        }

        public ActionResult EventCriteriaEditForm(int EventId)
        {
            var model = db.EventCriterias.Where(c=>c.EventId==EventId);          
            return View("EventCriteriaEditForm", model.ToList());
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
                //C#实现字符串按多个字符采用Split方法分割  https://www.cnblogs.com/codingsilence/archive/2010/09/29/2146603.html
                List<string> t = Regex.Split(content, "#\r\n", RegexOptions.IgnoreCase).ToList();
                ViewBag.Content = t;
                ViewBag.Count = t.Count;
                ViewBag.FaultCount = 0;
                ViewBag.SuccessCount = 0;
                //int order = 0;
                //if (db.Events.Count() > 0)
                //{
                //    order = db.Events.Max(record => record.MenuOrder);
                //}


                foreach (string item in t)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        try
                        {
                            EventCriteria criteria = new EventCriteria();

                            
                            string eventName= item.Split('\t')[0];
                            criteria.EventId = db.Events.Where(c => c.Name == eventName).First().Id;
                            criteria.Title = item.Split('\t')[1];
                            criteria.MinScore = Convert.ToInt32(item.Split('\t')[2]);
                            criteria.MaxScore = Convert.ToInt32(item.Split('\t')[3]);
                            criteria.SetId = Convert.ToInt32(item.Split('\t')[4]);
                            db.EventCriterias.Add(criteria);

                        }
                        catch
                        {
                            ViewBag.FaultCount++;

                        }


                    }
                }
                ViewBag.SuccessCount = db.SaveChanges();
                return View();
            }


            return View();
        }

   
    }
}

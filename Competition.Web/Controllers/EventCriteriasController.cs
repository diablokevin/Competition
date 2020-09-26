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
    }
}

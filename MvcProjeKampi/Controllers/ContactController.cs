using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManger ctact = new ContactManger(new EfContactDal());
        ContactValidator cv = new ContactValidator();
       
        public ActionResult Index()
        {
            var contactvalues=ctact.GetList();
            return View(contactvalues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = ctact.GetByID(id);
            return View(contactvalues);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelContentController : Controller
    {
        ContentManager contentManager = new ContentManager(new EfContentDal());
        Context c = new Context();
        public ActionResult MyContent(string p)
        {
            Context c= new Context();
           
            p = (string)Session["WriterMail"];
            var writerinfoid=c.Writers.Where(x=>x.WriterMail == p).Select(y=>y.WriterID).FirstOrDefault();

            var contentvalues = contentManager.GetListByWriter(writerinfoid);
            return View(contentvalues);
        }
        [HttpGet]
       public ActionResult AddContent(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            string mail = (string)Session["WriterMail"];
            var writerinfoid = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterID).FirstOrDefault();


            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = writerinfoid;
            contentManager.ContentAdd(p);
            p.ContenStatus= true;

            return RedirectToAction("MyContent");
        }
        public ActionResult ToDoList() 
        { 
            return View();
        
        }
    }
}
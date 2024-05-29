using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content

        ContentManager contentManager = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }
        Context c =new Context();
        public ActionResult GetAllContent(string p="")

        {
         
            var values=contentManager.GetList(p);
            return View(values);
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues=contentManager.GetListByID(id);
            return View(contentvalues);


        }

    }
}
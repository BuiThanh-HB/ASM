using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using BaiTapThucHanh.Models;

namespace BaiTapThucHanh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Product> data = new List<Product>();
            using (StreamReader sr = new StreamReader(Server.MapPath("~/Data/generated.json")))
            {
                data = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
            }
                return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
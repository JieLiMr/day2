using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonthExam.MVC.Controllers
{
    public class MatchController : Controller
    {
        /// <summary>
        /// 添加竞赛信息（空页面）
        /// </summary>
        /// <returns></returns>
        public ActionResult AddMatch()
        {
            return View();
        }
    }
}
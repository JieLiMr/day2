using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MonthExam.DAL;
using MonthExam.Model;

namespace MonthExam.WebAPI.Controllers
{
    public class MatchController : ApiController
    {
        // Dal 实例
        MatchDal dal = new MatchDal();

        /// <summary>
        /// 人员信息（通讯录）
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public IHttpActionResult GetUserList(int pageindex, int pagesize, string search )
        {
            int TotalCount = 0;
            var list = dal.GetUserList(pageindex,pagesize, search,out TotalCount);
            return Json(new {list, TotalCount } );
        }

        /// <summary>
        /// 添加竞赛信息
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public IHttpActionResult AddMatch(Match match)
        {
            var result = dal.AddMatch(match);
            return Json(result);
        }
    }
}

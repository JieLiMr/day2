using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonthExam.Model;
using NLog;

namespace MonthExam.DAL
{
    public class MatchDal
    {
        // 数据上下文类实例
        MatchDbContext db = new MatchDbContext();

        /// <summary>
        /// 人员信息（通讯录）
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<UserInfo> GetUserList(int pageindex,int pagesize,string search,out int TotalCount)
        {
            try
            {
                var list = db.UserInfo.AsQueryable().ToList();
                // 查询条件
                if (!string.IsNullOrEmpty(search))
                {
                    list = list.Where(u=>u.UserName.Contains(search) ||u.Phone.Contains(search)).ToList();
                }
                TotalCount=list.Count();
                list=list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
                return list.ToList();

            }
            catch (Exception ex)
            {
                // 写日志
                LogManager.GetLogger("*").Info(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// 添加竞赛信息
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public int AddMatch(Match match)
        {
            try
            {
                db.Match.Add(match);
                return db.SaveChanges();
            }
            catch (Exception ex)
            {
                // 写日志
                LogManager.GetLogger("*").Info(ex.Message);
                throw;
            }
        }
    }
}

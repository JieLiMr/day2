using System;
using System.Data.Entity;
using System.Linq;
using MonthExam.Model;

namespace MonthExam.DAL
{
    public class MatchDbContext : DbContext
    {
        public MatchDbContext()
            : base("name=MatchDbContext")
        {
        }


        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
    }
}
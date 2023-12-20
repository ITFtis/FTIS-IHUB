using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace iHub.Models
{
    public class iHubModelContextExt : Dou.Models.ModelContextBase<User, Role>
    {
        public iHubModelContextExt() : base("name=iHubModelContextExt")
        {
            Database.SetInitializer<iHubModelContextExt>(null);
        }

        public virtual DbSet<cmmMrq> cmmMrq { get; set; }

		public virtual DbSet<POST> POST { get; set; }
	}

    public class T8ModelContext : DbContext
    {
        public T8ModelContext() : base("name=T8ModelContext")
        {
            Database.SetInitializer<T8ModelContext>(null);
        }

        public virtual DbSet<F22EmpWTOption> F22OptionMWT { get; set; }
        public virtual DbSet<F22Qdate> F22Qdate { get; set; }        
    }
}
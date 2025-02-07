using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using iHub.Models.Mis;
using iHub.Models.ERP;

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

        public virtual DbSet<tmp_POST> tmp_POST { get; set; }
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

    public class T8ERPModelContext : DbContext
    {
        public T8ERPModelContext() : base("name=T8ERPModelContext")
        {
            Database.SetInitializer<T8ERPModelContext>(null);
        }

        public virtual DbSet<capCommBillType> capCommBillType { get; set; }
        public virtual DbSet<comGroupPerson> comGroupPerson { get; set; }
        public virtual DbSet<wfActivity> wfActivity { get; set; }
        public virtual DbSet<wfBill> wfBill { get; set; }
        public virtual DbSet<hrmOTApplyTime> hrmOTApplyTime { get; set; }       
        public virtual DbSet<webUrlAccess> webUrlAccess { get; set; }
    }

    public class MisModelContext : DbContext
    {
        public MisModelContext() : base("name=MisModelContext")
        {
            Database.SetInitializer<MisModelContext>(null);
        }

        public virtual DbSet<pjPjds> pjPjds { get; set; }
        public virtual DbSet<cmmDep> cmmDep { get; set; }
        public virtual DbSet<cmmEmp> cmmEmp { get; set; }
    }
}
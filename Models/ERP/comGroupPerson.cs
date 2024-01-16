using Dou.Misc.Attr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace iHub.Models
{
    /// <summary>
    /// 人員人事檔案
    /// </summary>
    [Table("comGroupPerson")]
    public class comGroupPerson
    {
        [Key]
        [Display(Name = "人員編號")]
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string PersonId { get; set; }

        [Display(Name = "人員姓名")]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string PersonName { get; set; }

        [Display(Name = "EMail")]
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string EMail { get; set; }



        static object lockGetAllDatas = new object();
        public static IEnumerable<comGroupPerson> GetAllDatas(int cachetimer = 0)
        {
            if (cachetimer == 0) cachetimer = Constant.cacheTime;
            
            string key = "iHub.Models.comGroupPerson";
            var allData = DouHelper.Misc.GetCache<IEnumerable<comGroupPerson>>(cachetimer, key);
            lock (lockGetAllDatas)
            {
                if (allData == null)
                {
                    Dou.Models.DB.IModelEntity<comGroupPerson> modle = new Dou.Models.DB.ModelEntity<comGroupPerson>(new T8ERPModelContext());
                    allData = modle.GetAll().OrderBy(a => a.PersonId).ToArray();

                    DouHelper.Misc.AddCache(allData, key);
                }
            }

            return allData;
        }
    }
}
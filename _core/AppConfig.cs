using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace iHub
{
    public class AppConfig
    {
        #region 私有變數

        private static bool _isBkTask;

        #endregion

        #region 建構子

        static AppConfig()
        {
            bool.TryParse(ConfigurationManager.AppSettings["IsBkTask"].ToString(), out _isBkTask);
        }

        #endregion

        #region 公用屬性     
        
        public static bool IsBkTask
        {
            get { return _isBkTask; }
        }

        #endregion
    }
}
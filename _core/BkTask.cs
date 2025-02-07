using iHub.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;

namespace iHub
{
    public class BkTask
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BkTask()
        {
            // 從組態檔載入相關參數，例如 SmtpHost、SmtpPort、SenderEmail 等等.
        }
        private DateTime startdt = DateTime.Now;
        private int runCount = 0;
        private bool _stopping = false;


        public void Run()
        {
            logger.Info("啟動BkTask背景");
            System.IO.File.AppendAllText(Path.Combine(System.Web.Hosting.HostingEnvironment.MapPath(("~/logs")), "startlog.txt"), $"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}啟動BkTask背景" + Environment.NewLine);
            var aThread = new Thread(TaskLoop);
            aThread.IsBackground = true;
            aThread.Priority = ThreadPriority.BelowNormal;  // 避免此背景工作拖慢 ASP.NET 處理 HTTP 請求.
            aThread.Start();
        }

        public void Stop()
        {
            _stopping = true;
        }



        private void TaskLoop()
        {
            // 設定每一輪工作執行完畢之後要間隔幾分鐘再執行下一輪工作.
            //const int LoopIntervalInMinutes = 1000 * 60 * 15;//15分鐘1次
            const int LoopIntervalInMinutes = 1000 * 60 * 60 * 8;//8小時1次(系統資料剛建立，避免"薪資資料"尚未完成，執行更新)

            logger.Info("背景TaskLoop on thread ID: " + Thread.CurrentThread.ManagedThreadId.ToString());
            while (!_stopping)
            {
                try
                {
                    Todo();
                    logger.Info("==================================================================================");
                }
                catch (Exception ex)
                {
                    // 發生意外時只記在 log 裡，不拋出 exception，以確保迴圈持續執行.
                    logger.Error("BkTask.TaskLoop錯誤:" + ex.ToString());
                }
                finally
                {
                    // 每一輪工作完成後的延遲.
                    System.Threading.Thread.Sleep(LoopIntervalInMinutes);
                }
            }
        }

        private void Todo()
        {
            logger.Info($"To do ......啟動時間:{startdt.ToString("yyyy/MM/dd HH:mm:ss")};次數:{(++runCount)}");

            DateTime start_time = DateTime.Now;

            //工作1
            logger.Info("job1");
            start_time = DateTime.Now;
            logger.Info("Start:" + "轉檔會內公告(tmp_POST=>POST)");
            To_ConvertPOST();
            logger.Info(@"Execution time(sec)=" + DateTime.Now.Subtract(start_time).TotalSeconds);           
        }

        /// <summary>
        /// 轉檔會內公告(tmp_POST=>POST)
        /// </summary>
        private void To_ConvertPOST()
        {
            try
            {
                //xxxxxxxx
                Dou.Models.DB.IModelEntity<tmp_POST> m_tmp_POST = new Dou.Models.DB.ModelEntity<tmp_POST>(new iHubModelContextExt());
                var tmps = m_tmp_POST.GetAll().ToList();

                Dou.Models.DB.IModelEntity<POST> m_POST = new Dou.Models.DB.ModelEntity<POST>(new iHubModelContextExt());

                foreach (var tmp in tmps)
                {
                    var v = m_POST.GetAll().Where(a => a.PostId == tmp.PostId).FirstOrDefault();
                    if (v == null)
                    {
                        //新增
                        POST p = new POST();
                        p.Title = tmp.Title;
                        p.Summary = tmp.Summary;
                        p.HtmlContent = tmp.HtmlContent;
                        p.KeyWord = tmp.KeyWord;
                        p.NodeId = tmp.NodeId;
                        p.SortNo = tmp.SortNo;
                        p.Flag = tmp.Flag;
                        p.PicFileName = tmp.PicFileName;
                        p.DocFileName = tmp.DocFileName;
                        p.StoreName = tmp.StoreName;
                        p.Phone = tmp.Phone;
                        p.Fax = tmp.Fax;
                        p.Address = tmp.Address;
                        p.GoogleMap = tmp.GoogleMap;
                        p.CreatedBy = tmp.CreatedBy;
                        p.UpdatedBy = tmp.UpdatedBy;
                        p.UpdatedDate = tmp.UpdatedDate;
                        p.CreatedDate = tmp.CreatedDate;
                        p.ShowDate = tmp.ShowDate;
                        p.Type = tmp.Type;
                        p.LinkUrl = tmp.LinkUrl;
                        p.HtmlContent2 = tmp.HtmlContent2;
                        p.HtmlContent3 = tmp.HtmlContent3;
                        p.HtmlContent4 = tmp.HtmlContent4;

                        p.PostId = tmp.PostId;
                        p.IsClosedIHub = "N";
                        m_POST.Add(p);
                    }
                    else
                    {
                        //修改
                        v.Title = tmp.Title;
                        v.Summary = tmp.Summary;
                        v.HtmlContent = tmp.HtmlContent;
                        v.KeyWord = tmp.KeyWord;
                        v.NodeId = tmp.NodeId;
                        v.SortNo = tmp.SortNo;
                        v.Flag = tmp.Flag;
                        v.PicFileName = tmp.PicFileName;
                        v.DocFileName = tmp.DocFileName;
                        v.StoreName = tmp.StoreName;
                        v.Phone = tmp.Phone;
                        v.Fax = tmp.Fax;
                        v.Address = tmp.Address;
                        v.GoogleMap = tmp.GoogleMap;
                        v.CreatedBy = tmp.CreatedBy;
                        v.UpdatedBy = tmp.UpdatedBy;
                        v.UpdatedDate = tmp.UpdatedDate;
                        v.CreatedDate = tmp.CreatedDate;
                        v.ShowDate = tmp.ShowDate;
                        v.Type = tmp.Type;
                        v.LinkUrl = tmp.LinkUrl;
                        v.HtmlContent2 = tmp.HtmlContent2;
                        v.HtmlContent3 = tmp.HtmlContent3;
                        v.HtmlContent4 = tmp.HtmlContent4;

                        m_POST.Update(v);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("(錯誤)iHub匯入員工薪資");
                logger.Error(ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace iHub
{
    [XmlRoot(ElementName = "SysParam")]
    public class SysParam
    {
        [XmlIgnore]
        private DateTime _cStartDate;
        private DateTime _cEndDate;

        //參數識別碼
        [XmlElement(ElementName = "Key")]
        public string Key { get; set; }

        //參數識別名稱
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        //差勤年份
        [XmlElement(ElementName = "Wyear")]
        public int Wyear { get; set; }

        //季別
        [XmlElement(ElementName = "Qno")]
        public System.Byte Qno { get; set; }

        //該季起始日期
        [XmlElement(ElementName = "Cstartdate")]
        public string Cstartdate// { get; set; }
        {
            get { return _cStartDate.ToString("yyyy-MM-dd HH:mm:ss"); }
            set { _cStartDate = DateTime.Parse(value); }
        }

        //該季結束日期
        [XmlElement(ElementName = "Cenddate")]
        public string Cenddate// { get; set; }
        {
            get { return _cEndDate.ToString("yyyy-MM-dd HH:mm:ss"); }
            set { _cEndDate = DateTime.Parse(value); }
        }

        //班別一
        [XmlElement(ElementName = "Class1")]
        public string Class1 { get; set; }

        //班別二
        [XmlElement(ElementName = "Class2")]
        public string Class2 { get; set; }

        //班別三
        [XmlElement(ElementName = "Class3")]
        public string Class3 { get; set; }

        //特殊班別
        [XmlElement(ElementName = "Class9")]
        public string Class9 { get; set; }

        //是否檢視(Y/N)
        [XmlElement(ElementName = "IsView")]
        public string IsView { get; set; }

        //是否Block員工設定(Y/N)
        [XmlElement(ElementName = "IsBlock")]
        public string IsBlock { get; set; }
    }

    [XmlRoot(ElementName = "ArrayOfSysParam")]
    public class ArrayOfSysParam
    {

        [XmlElement(ElementName = "SysParam")]
        public List<SysParam> SysParam { get; set; }

        [XmlAttribute(AttributeName = "xsd")]
        public string Xsd { get; set; }

        [XmlAttribute(AttributeName = "xsi")]
        public string Xsi { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
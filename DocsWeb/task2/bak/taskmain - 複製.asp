<!--#include file="../opendatabase.asp"-->

<html>
<head>
<title>行政管理專區</title>
<meta http-equiv="Content-Type" content="text/html; charset=big5">
<style type="text/css">
<!--
.12word { font-family: "微軟正黑體"; font-size: 12pt; line-height: 16pt}
-->
</style>
</head>

<body vLink=#660066 topmargin=0 leftmargin=0 marginwidth=0 marginheight=0 bgcolor="#CCFFFF">
<form method="POST" name="mypage" action="out-bill.asp">

<center>
<BR>
  <h1><font face="標楷體">行政管理專區</font></h1>
<table cellpadding="0" cellspacing="0" border="0" bgcolor="#005599" width="1000" align="center">
<tr>
<td bgcolor="#A040FF" height="35" width="850" class="12word">　<font color="#ffffff">
<a href="taskmain.asp?行政作業=人資"><font color="#ffffff">人資</font></a> │ 
<a href="taskmain.asp?行政作業=財務"><font color="#ffffff">財務</font></a> │ 
<a href="taskmain.asp?行政作業=資訊"><font color="#ffffff">資訊</font></a> │ 
<a href="taskmain.asp?行政作業=總務"><font color="#ffffff">總務</font></a> │ 
<a href="taskmain.asp?行政作業=法務"><font color="#ffffff">法務</font></a> │ 
<a href="taskmain.asp?行政作業=公關"><font color="#ffffff">公關</font></a> │ 
<a href="taskmain.asp?行政作業=專案管理"><font color="#ffffff">專案管理</font></a> │ 
<a href="taskmain.asp?行政作業=職安衛"><font color="#ffffff">職安衛</font></a> │ 
<a href="taskmain.asp?行政作業=FAQ"><font color="#ffffff">FAQ</font></a> │ 
</td>
<td bgcolor="#A040FF" height="35" width="150" class="12word">
<a HREF="/" target="_top" OnMouseOver="window.status='回管理系統主畫面'; return true;" OnMouseOut="window.status='';"><font color="#ffffff">回管理系統主畫面</font></a>
</td>
</tr>
</table>

<br>
<font size="4" color="#004080" face="標楷體"><b><%=request("行政作業")%> - 行政程序檢索 (<font size="4" color="#ff0000" face="標楷體">建議 點選滑鼠右鍵 / 另存目標</font>)</font></b>

<% Select Case request("行政作業") %>

	<% Case "人資" %>
<table border="1" width="1000" align="center" cellpadding="5" cellspacing="0" class="12word">
  <tr align="center" height="33" bgcolor="#00cc99">
	<td width="300">項目</td>
	<td width="600">表單名稱</td>
	<td width="100">更新日期</td>
  </tr>
	<tr>
	<td rowspan="4">　招募任用</td>
	<td>　1.人員聘僱申請　(<a href = "./人資/招募任用_1人員聘僱申請(超過一個月)(規範).pdf" target=_blank>規範</a>)　(<a href = "./人資/招募任用_1人員聘僱申請表.docx" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.短期人員申請　(<a href = "./人資/招募任用_2短期人員申請(規範).pdf" target=_blank>規範</a>)　(<a href = "./人資/招募任用_2短期人員申請表(表單).doc" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.新人工作週誌　(<a href = "./人資/招募任用_3新人工作週誌(規範).pdf" target=_blank>規範</a>)　(<a href = "./人資/招募任用_3新進人員工作週誌(表單).doc" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.臨時工讀生基本資料　(<a href = "./人資/招募任用_4臨時工讀生基本資料.doc" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td rowspan="2">　出勤管理</td>
	<td>　1.差勤填寫及加班申請　(<a href = "./人資/出勤管理_1差勤填寫及加班申請(規範).pdf" target=_blank>規範</a>)　(<a href = "/mhot2020/mhot.htm" target="_blank">線上系統</a>)　(<a href = "./人資/出勤管理_1加班申請原則確認單.docx" target=_blank>加班暨變形申請原則確認單</a>)</td>
	<td>　110.03</td>
	</tr>
	<tr>
	<td>　2.請假　(<a href = "./人資/出勤管理_2請假(規範).pdf" target=_blank>規範</a>)　(<a href = "/rest/rest.htm" target="_blank">線上系統</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td rowspan="6">　員工發展</td>
	<td>　1.派外訓練申請　(<a href = "./人資/員工發展_1派外訓練申請(規範).pdf" target=_blank>規範</a>)　(<a href = "./人資/員工發展_1派外訓練申請表(表單).doc" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.內訓訓練申請　(<a href = "./人資/員工發展_2內訓訓練申請(規範).pdf" target=_blank>規範</a>)　(<a href = "/training/training.htm" target="_blank">線上系統</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.在職進修訓練申請　(<a href = "./人資/員工發展_3在職進修訓練申請(規範).pdf" target=_blank>規範</a>)　(<a href = "./人資/員工發展_3在職進修申請表(表單).doc" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.派訓訓練心得報告　(<a href = "./人資/員工發展_4派訓訓練心得報告(規範).pdf" target=_blank>規範</a>)　(<a href = "./人資/員工發展_4派外心得報告(表單).docx" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　5.內訓心得回饋　(<a href = "/training/training.htm" target="_blank">線上系統</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　6.職務體系暨晉升　(<a href = "./人資/員工發展_6職務體系暨晉升管理辦法(10009)(文件).pdf" target=_blank>管理辦法</a>　<a href = "./人資/員工發展_6業務部門主管晉升資格規範.pdf" target=_blank>晉升資格規範</a>　<a href = "./人資/員工發展_6晉升申請表.doc" target=_blank>晉升申請表</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td rowspan="5">　薪資福利</td>
	<td>　1.本人及眷屬加保健保/團保申請表　(<a href = "./人資/薪資福利1_本人及眷屬加保申請表(表單).docx" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.旅平險申請　(<a href = "./人資/薪資福利2_旅平險申請(規範).pdf" target=_blank>規範</a>)　(<a href = "./人資/薪資福利_計畫保險申請表.docx" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.計畫保險申請　(<a href = "./人資/薪資福利3_計畫保險申請(規範).pdf" target=_blank>規範</a>)　(<a href = "./人資/薪資福利_計畫保險申請表.docx" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.團保文件　(<a href = "./人資/薪資福利4_110年度團保計畫.pdf" target=_blank>110年團保計畫</a>)　(<a href = "./人資/薪資福利4_110年團保手冊.pdf" target=_blank>團保手冊</a>)　(<a href = "./人資/薪資福利4_本人及眷屬加保申請表(10901).docx" target=_blank>投保申請表</a>)</td>
	<td>　109.01</td>
	</tr>
	<tr>
	<td>　5.員工旅遊補助　(<a href = "./人資/薪資福利4_員工旅遊補助_申請表.doc" target=_blank>申請表</a>)　(<a href = "./人資/薪資福利4_員工旅遊補助_施行辦法.pdf" target=_blank>施行辦法</a>)</td>
	<td>　110.03.24</td>
	</tr>
	<tr>
	<td rowspan="11">　其他行政管理</td>
	<td>　1.在職證明申請　(<a href = "/stamp/stamp.asp" target="_blank">線上系統</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.年度辦公室日曆表　(<a href = "./人資/其他行政管理02_產基會109年辦公日曆表.xlsx" target=_blank>109年</a>)　(<a href = "./人資/其他行政管理02_產基會110年辦公日曆表.xlsx" target=_blank>110年</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.工作規則　(<a href = "./人資/其他行政管理03_工作規則(文件).pdf" target=_blank>文件</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.員工獎懲　(<a href = "./人資/其他行政管理04_員工獎懲(910423)(文件).pdf" target=_blank>文件</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　5.上班穿著注意事項　(<a href = "./人資/其他行政管理05_上班穿著注意事項(規範).pdf" target=_blank>規範</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　6.員工道德行為守則　(<a href = "./人資/其他行政管理06_員工道德行為守則(10707)(文件).pdf" target=_blank>文件</a>)</td>
	<td>　107.07</td>
	</tr>
	<tr>
	<td>　7.履歷調閱申請　(<a href = "./人資/其他行政管理07_履歷調閱申請表(表單).doc" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　8.員工參與團體申請　(<a href = "./人資/其他行政管理08_員工參與團體申請表(表單).doc" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　9.離職規範　(<a href = "./人資/其他行政管理09_離職申請規範.pdf" target=_blank>規範</a>)　(<a href = "./人資/其他行政管理09_離職申請表單.pdf" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　10.體溫紀錄表　(<a href = "./人資/其他行政管理10_體溫紀錄表_10907.xlsx" target=_blank>表單</a>)</td>
	<td>　109.07</td>
	</tr>
	<tr>
	<td>　11.優秀員工選拔及表揚　(<a href = "./人資/本會優秀員工選拔及表揚要點.pdf" target=_blank>實施要點</a>　<a href = "./人資/110年度優秀員工選拔實施辦法.pdf" target=_blank>實施辦法</a>　<a href = "./人資/優秀員工之優秀事蹟說明表.docx" target=_blank>優秀事蹟說明表</a>)</td>
	<td>　110.05</td>
	</tr>
</table>

	<% Case "財務" %>
<table border="1" width="1000" align="center" cellpadding="5" cellspacing="0" class="12word">
  <tr align="center" height="33" bgcolor="#00cc99">
	<td width="300">項目</td>
	<td width="600">表單名稱</td>
	<td width="100">更新日期</td>
  </tr>
	<tr>
	<td rowspan="9">　一般請款管理</td>
	<td>　1.請款作業程序　（ <a href = "./財務/01一般請款管理_01請款作業程序.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.領據　（ <a href = "./財務/01一般請款管理_02領據.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.請款單　（ <a href = "./財務/01一般請款管理_03請款單-.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.請款單+黏存單　（ <a href = "./財務/01一般請款管理_04請款單_粘存單.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　5.支付明細表　（ <a href = "./財務/01一般請款管理_05支付明細表.xlsx" target=_blank>下載</a> ）</td>
	<td>110.03.30</td>
	</tr>
	<tr>
	<td>　6.簽收回條　（ <a href = "./財務/01一般請款管理_06簽收回條.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　7.核銷規定　（ <a href = "./財務/01一般請款管理_07核銷規定.xlsx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　8.所得代扣基準　（ <a href = "./財務/01一般請款管理_08所得代扣基準.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　9.核決權限　（ <a href = "./財務/01一般請款管理_09核決權限.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td rowspan="9">　計程車及出差管理</td>
	<td>　1.差旅管理辦法　（ <a href = "./財務/02計程車及出差管理_01員工出差管理辦法.docx" target=_blank>下載</a> ）</td>
	<td>110.07.02</td>
	</tr>
	<tr>
	<td>　2.國外出差旅費報支要點　（ <a href = "./財務/02計程車及出差管理_02國外出差旅費報支要點.pdf" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.國外出差生活費日支數額表　（ <a href = "./財務/02計程車及出差管理_03國外生活費日支數額表.pdf" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.旅費報告單　（ <a href = "./財務/02計程車及出差管理_04旅費報告單.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　5.旅費報告單+黏存單　（ <a href = "./財務/02計程車及出差管理_05旅費報告單_粘存單.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　6.計程車資證明單　（ <a href = "./財務/02計程車及出差管理_06計程車資證明單.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　7.計程車資證明單+黏存單　（ <a href = "./財務/02計程車及出差管理_07計程車資證明單_黏存單.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　8.出差申請單　（ <a href = "./財務/02計程車及出差管理_08出差申請單.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　9.出差範圍認定說明　（ <a href = "./財務/02計程車及出差管理_09出差範圍認定說明.docx" target=_blank>下載</a> ）</td>
	<td>110.06.03</td>
	</tr>
	<tr>
	<td rowspan="5">　暫借款管理</td>
	<td>　1.暫借款支用管理要點　（ <a href = "./財務/03暫借款管理_01暫借款支用管理要點.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.暫借款申請單　（ 本申請單放置於「公用區文具櫃」取得 ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.專案成本估算表　（ <a href = "./財務/03暫借款管理_03專案成本估算表.xls" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.暫借款經費預估表　（ <a href = "./財務/03暫借款管理_04暫借款經費預估表.xls" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　5.暫借款核銷摘要　（ <a href = "./財務/03暫借款管理_05暫借款核銷摘要.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td rowspan="2">　零用金管理</td>
	<td>　1.零用金管理辦法　（ <a href = "./財務/04零用金管理_01零用金管理辦法.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.零用金備查簿　（ <a href = "./財務/04零用金管理_02零用金備查簿.xls" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td rowspan="3">　應收及收款管理</td>
	<td>　1.應收及收款流程　（ <a href = "./財務/05應收及收款管理_01應收帳款及收款流程.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.收款清單　（ 紙本申請單放置於「公用區文具櫃」取得 ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.收入明細表　（ <a href = "./財務/05應收及收款管理_03收入明細表.xlsx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
</table>

	<% Case "資訊" %>
<table border="1" width="1000" align="center" cellpadding="5" cellspacing="0" class="12word">
  <tr align="center" height="33" bgcolor="#00cc99">
	<td width="300">項目</td>
	<td width="600">表單名稱</td>
	<td width="100">更新日期</td>
  </tr>
	<tr>
	<td width="205"><b>　資訊安全政策</td>
	<td><b>　1.資訊安全政策　（ <a href = "./資訊/1資訊安全政策.pdf" target=_blank>下載</a> ）</td>
	<td>　109.06.23</td>
	</tr>
	<tr>
	<td width="205">　資訊需求申請</td>
	<td>　2.資訊需求申請表　（ <a href = "/routine/inform/inform.asp" target=_blank>連結</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td width="205">　資訊設備驗收管理</td>
	<td>　3.資訊設備採購驗收檢核表　（ <a href = "./資訊/3資訊設備採購驗收檢核表10304版.doc" target=_blank>下載</a> ）</td>
	<td>　103.04</td>
	</tr>
	<tr>
	<td height="55" width="205">　資訊設備採購規格 <BR>　(PC、NB、Office、其他)</td>
	<td height="55">　4.電腦採購規格多頁箋(每季更新)　（ <a href = "資訊/__ITbuynew.htm" target=_blank>說明</a> ）</td>
	<td>　109.09</td>
	</tr>
	<tr>
	<td width="205">　空白光碟領用/燒錄管理</td>
	<td>　5.光碟片領用記錄表　（請至資訊室登記）</td>
	<td>　</td>
	</tr>
	<tr>
	<td width="205">　滑鼠鍵盤更換管理</td>
	<td>　6.鍵盤/滑鼠領用登記表　（請至資訊室登記）</td>
	<td>　</td>
	</tr>
	<tr>
	<td width="205">　外接式光碟機借用管理</td>
	<td>　7.外接式DVD光碟燒錄機借用登記表　（請至資訊室登記）</td>
	<td>　</td>
	</tr>
	<tr>
	<td width="205" bgcolor=#ffff00>　本會資訊系統指引</td>
	<td bgcolor=#ffff00>　8.【<a href = "資訊/__ITmessage.htm" target=_blank>本會資訊系統指引</a>】</td>
	<td>　109.10</td>
	</tr>
</table>

	<% Case "總務" %>
<table border="1" width="1000" align="center" cellpadding="5" cellspacing="0" class="12word">
  <tr align="center" height="33" bgcolor="#00cc99">
	<td width="300">項目</td>
	<td width="600">表單名稱</td>
	<td width="100">更新日期</td>
  </tr>
	<td rowspan="5">　請採購管理</td>
	<td>　1.採購管理辦法　（ <a href = "./總務/B01採購管理辦法.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.專案委外及請採購應注意事項　（ <a href = "./總務/B02專案委外及請採購應注意事項.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.委外合約簽訂應注意事項　（ <a href = "./總務/B03委外合約簽訂應注意事項.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.採購請購單　（ <a href = "./總務/B04採購請購單.doc" target=_blank>下載</a> ）</td>
	<td>　110.01.27</td>
	</tr>
	<tr>
	<td>　5.供應商名單　（ <a href = "./總務/B05供應商名單.xlsx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td rowspan="5">　財產管理</td>
	<td>　1.財產及設備管理流程　（ <a href = "./總務/C01財產及設備管理流程.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<td>　2.財產異動單　（ <a href = "./總務/C02財產異動單.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.財產／設備報廢申請　（ <a href = "./總務/C03財產設備報廢申請單.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.筆記型電腦使用保管約定書　（ <a href = "./總務/C04筆記型電腦使用保管約定書.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　5.會議室及設備預約　（ <a href = "http://120.100.100.236/" target=_blank>會議室及設備預約系統</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td rowspan="7">　公文管理</td>
	<td>　1.收文流程及應注意事項　（ <a href = "./總務/D01收文流程及應注意事項.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.發文流程及應注意事項　（ <a href = "./總務/D02發文流程及應注意事項.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.電子公文系統　（ <a href = "https://odoc.ftis.org.tw/" target=_blank>請複製此連結後，使用Google Chrome登入此系統</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.電子公文手冊　（ <a href = "./總務/D04電子公文手冊.pdf" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　5.公文合併上陳簽核範例_收文　（ <a href = "./總務/D05公文合併上陳簽核範例_收文.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　6.公文合併上陳簽核範例_發文　（ <a href = "./總務/D06公文合併上陳簽核範例_發文.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　7.簽呈格式　（ <a href = "./總務/D07簽呈格式.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>

	<tr>
	<td rowspan="16">　其他行政管理</td>
	<td>　1.庶務用品申請須知　（ <a href = "./總務/E01庶務用品申請須知.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.北區 文具申請單（ <a href = "./總務/E02文具申請單.xls" target=_blank>下載</a> ）　　中南區 文具申請單（ <a href = "./總務/E02_中南區_文具申請單.xls" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.研討會/說明會/訓練營/宣導活動用具查核表　（ <a href = "./總務/E03研討會／說明會／訓練營／宣導活動用具查核表.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.名片/印章申請表　（ <a href = "./總務/E04名片／印章申請表.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　5.郵件寄發應注意事項　（ <a href = "./總務/E05郵件寄發注意事項.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　6.電子領標應注意事項　（ <a href = "./總務/E06電子領標應注意事項.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　7.機密文件銷毀應注意事項　（ <a href = "./總務/E07機密文件銷毀應注意事項.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　8.庫房使用規則　（ <a href = "./總務/E08庫房使用規則.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　9.茶水間使用規則　（ <a href = "./總務/E09茶水間使用規則.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　10.影印機操作說明　（ <a href = "./總務/E10影印機操作說明.ppt" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　11.會本部門禁系統使用及管理辦法　（ <a href = "./總務/E11會本部門禁系統使用及管理辦法.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　12.機票代訂申請表　（ <a href = "./總務/E12機票代訂申請表.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　13.話機/行動APP設定操作說明　（ <a href = "./總務/E13話機行動APP設定操作說明.pdf" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　14.電視牆託播使用說明　（ <a href = "./總務/E14電視牆託播使用說明.pptx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　15.分機配置圖(1樓/2樓/新生辦)　（ <a href = "./總務/E15分機配置圖_1樓.docx" target=_blank>1樓</a>　<a href = "./總務/E15分機配置圖_2樓.docx" target=_blank>2樓</a>　<a href = "./總務/E15分機配置圖_新生辦.ppt" target=_blank>新生辦</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　16.話機與行動APP分機對照表　（ <a href = "./總務/E16話機與行動APP分機對照表.xlsx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
</table>

	<% Case "法務" %>
<table border="1" width="1000" align="center" cellpadding="5" cellspacing="0" class="12word">
  <tr align="center" height="33" bgcolor="#00cc99">
	<td width="300">項目</td>
	<td width="600">表單名稱</td>
	<td width="100">更新日期</td>
  </tr>
	<tr>
	<td rowspan="9">　合約管理</td>
	<td>　1.合約管理　(<a href = "./法務/合約管理1_合約管理(規範).pdf" target=_blank>規範</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.A01委外合約範本（與公司或團體簽訂）　(<a href = "./法務/合約管理2_A01履約階段與公司團體簽訂之合作契約-1091016.doc" target=_blank>表單</a>)</td>
	<td>　109.10.16</td>
	</tr>
	<tr>
	<td>　3.A02委外合約範本（與專家學者簽訂）　(<a href = "./法務/合約管理3_A02履約階段合作契約書(與老師簽訂範例)-1091016.docx" target=_blank>表單</a>)</td>
	<td>　109.10.16</td>
	</tr>
	<tr>
	<td>　4.B01工服案合約參考　(<a href = "./法務/合約管理4_B01工服案合約參考(表單).doc" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　5.C01顧問合作協議書範本（與公司或團體簽訂）　(<a href = "./法務/合約管理5_C01投標階段合作協議書(與公司或團體簽訂)-1091016.doc" target=_blank>表單</a>)</td>
	<td>　109.10.16</td>
	</tr>
	<tr>
	<td>　6.C02顧問合作協議書範本（與專家學者簽訂）　(<a href = "./法務/合約管理6_C02投標階段合作協議書(與老師簽訂範例)-1100115.docx" target=_blank>表單</a>)</td>
	<td>　110.01.15</td>
	</tr>
	<tr>
	<td>　7.專案計畫服務完成證明書　(<a href = "./法務/合約管理7_專案計畫服務完成證明書(1040325)(表單).docx" target=_blank>表單</a>)</td>
	<td>　104.03.25</td>
	</tr>
	<tr>
	<td>　8.產基會委託代理授權書_08172011(W)　(<a href = "./法務/合約管理8_產基會委託代理授權書_08172011(W)(表單).doc" target=_blank>表單</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　9.服務完成證明書 (本會開立給分包廠商)　(<a href = "./法務/合約管理9_服務完成證明書_本會開立給分包廠商.docx" target=_blank>表單</a>)</td>
	<td>　110.05.14</td>
	</tr>


	<tr>
	<td rowspan="3">　法務審查</td>
	<td>　1.法務審查　(<a href = "./法務/法務審查_1法務審查(規範).pdf" target=_blank>規範</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.法務意見諮詢服務申請表-新(104.03)　(<a href = "./法務/法務審查_2法務意見諮詢服務申請表-新(104.03)(表單).doc" target=_blank>表單</a>)</td>
	<td>　104.03</td>
	</tr>
	<tr>
	<td>　3.法務審查申請　(<a href = "/stamp/stamp.asp" target=_blank>連結</a>)</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　印鑑使用</td>
	<td>　1.印鑑使用　(<a href = "./法務/印鑑使用_1印鑑使用(規範).pdf" target=_blank>規範</a>)　（ <a href = "/stamp/stamp.asp" target=_blank>線上系統</a> ）</td>
	<td>　</td>
	</tr>
</table>

	<% Case "公關" %>
<table border="1" width="1000" align="center" cellpadding="5" cellspacing="0" class="12word">
  <tr align="center" height="33" bgcolor="#00cc99">
	<td width="300">項目</td>
	<td width="600">表單名稱</td>
	<td width="100">更新日期</td>
  </tr>
	<tr>
	<td rowspan="12">　本會 Logo</td>
	<td>　1.圓形樣式 (jpg)　（ <a href = "./公關/本會Logo-1.圓形樣式JPG.jpg" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.圓形樣式 (ai)　（ <a href = "./公關/本會Logo-2.圓形樣式ai.ai" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.圓形樣式 (去背PNG)　（ <a href = "./公關/本會Logo-3.圓形樣式去背PNG.png" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.橫式 (jpg)　（ <a href = "./公關/本會Logo-4.橫式JPG.jpg" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　5.橫式 (ai)　（ <a href = "./公關/本會Logo-5.橫式ai.ai" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　6.橫式 (去背PNG)　（ <a href = "./公關/本會Logo-6.橫式去背PNG.png" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　7.直式 (jpg)　（ <a href = "./公關/本會Logo-7.直式JPG.jpg" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　8.直式 (ai)　（ <a href = "./公關/本會Logo-8.直式ai.ai" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　9.直式 (去背PNG)　（ <a href = "./公關/本會Logo-9.直式去背PNG.png" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　10.Loge無文字 (jpg)　（ <a href = "./公關/本會Logo-10.logo無文字JPG.jpg" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　11.Loge無文字 (ai)　（ <a href = "./公關/本會Logo-11.Logo無文字.ai" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　12.Loge無文字 (去背PNG)　（ <a href = "./公關/本會Logo-12.Logo無文字去背PNG.png" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　會內美工設計申請</td>
	<td>　1.會內美工設計申請表　（ <a href = "./公關/會內美工設計申請-1.申請表格.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
</table>

	<% Case "專案管理" %>
<table border="1" width="1000" align="center" cellpadding="5" cellspacing="0" class="12word">
  <tr align="center" height="33" bgcolor="#00cc99">
	<td width="300">項目</td>
	<td width="600">表單名稱</td>
	<td width="100">更新日期</td>
  </tr>
	<tr>
	<td rowspan="11" >　專案管理</td>
	<td>　1.計畫備標應注意事項　（ <a href = "./專案管理/A01計畫備標應注意事項.docx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.專案管理檢視表　（ <a href = "./專案管理/A02專案管理檢視表.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.開案申請表　（ <a href = "./專案管理/A03開案申請表.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　4.成本估算表　（ <a href = "./專案管理/A04成本估算表.xlsx" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　5.投標資格文件檢核表　（ <a href = "./專案管理/A05投標資格文件檢核表.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　6.委外分包申請表　(外部分包使用)　（ <a href = "./專案管理/A06委外分包申請表(外部分包使用).doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　7.法務審查申請　（ <a href = "/stamp/stamp.asp" target=_blank>連結</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　8.計畫書人力管控表　（ <a href = "./專案管理/A08計畫書人力管控表.doc" target=_blank>下載</a> ）</td>
	<td>110.03</td>
	</tr>
	<tr>
	<td>　9.履約管理檢視表　（ <a href = "./專案管理/A09履約管理檢視表.doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　10.會內分包申請表＿內部分包使用　（ <a href = "./專案管理/A10會內分包申請表(內部分包使用).doc" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　11.工服案報價流程　（ <a href = "./專案管理/A11工服案報價流程.docx" target=_blank>下載</a> ）</td>
	<td>110.08.04</td>
	</tr>

	<% Case "職安衛" %>
<table border="1" width="1000" align="center" cellpadding="5" cellspacing="0" class="12word">
  <tr align="center" height="33" bgcolor="#00cc99">
	<td width="300">項目</td>
	<td width="600">表單名稱</td>
	<td width="100">更新日期</td>
  </tr>
	<tr>
	<td rowspan="3" >　職安衛</td>
	<td>　1.人因性危害預防計畫　（ <a href = "./職安衛/1.人因性危害預防計畫.pdf" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　2.異常工作負荷促發疾病預防計畫　（ <a href = "./職安衛/2.異常工作負荷促發疾病預防計畫.pdf" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
	<tr>
	<td>　3.執行職務遭受不法侵害預防計畫　（ <a href = "./職安衛/3.執行職務遭受不法侵害預防計畫.pdf" target=_blank>下載</a> ）</td>
	<td>　</td>
	</tr>
</table>

	<% Case "FAQ" %>
<table border="1" width="1000" align="center" cellpadding="5" cellspacing="0" class="12word">
  <tr align="center" height="33" bgcolor="#00cc99">
	<td width="200">組別</td>
	<td width="200">類型</td>
	<td width="500">說明</td>
	<td width="100">更新日期</td>
	<tr>
	<td rowspan="2" >行政組</td>
	<td>行政程序FAQ</td>
	<td>常見行政程序問題 （ <a href = "./Faq/行政程序FAQ_1100707.docx" target=_blank>下載</a> ）</td>
	<td>110.07</td>
	</tr>
	<tr>
	<td>　</td>
	<td>　</td>
	<td>　</td>
	</tr>
</table>

	<% Case Else %>
	
<% End Select %>

</table>
<BR>
</center>

</form>
</body>
</html>

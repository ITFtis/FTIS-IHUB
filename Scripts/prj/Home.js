$(document).ready(function () {
    $("[name='aErp']").on("click", function () {
        var userid = $(this).attr('userid');
        var typeid = $(this).attr('typeid');

        helper.misc.showBusyIndicator();
        $.ajax({
            url: app.siteRoot + 'Home/GetUnDoneBillList',
            datatype: "json",
            type: "Get",
            data: { userid: userid, typeid: typeid },
            async: false,
            success: function (data) {

                if (data.result) {

                    content = '<ul>';
                    $.each(data.UnErps, function (index, value) {

                        var msg = '<span>單據編號(' + this.TransactionId + '&nbsp;&nbsp;' + this.TypeName + ')</span>'                            
                            + '<span class="ps-3">送審人(' + this.MakerName + ')</span>'
                            + '<span class="ps-3">送審時間(' + this.MakeTime + ')</span>';

                        content += '<li>' + msg + '</li>';
                    });

                    content += '</ul>';

                    jspAlertMsg($("body"), { autoclose: 60 * 1000, content: content }, null);

                } else {
                    alert("假單資料顯示失敗：\n" + data.errorMessage);
                }
            },
            complete: function () {
                helper.misc.hideBusyIndicator();
            },
            error: function (xhr, status, error) {
                var err = eval("(" + xhr.responseText + ")");
                alert(err.Message);
                helper.misc.hideBusyIndicator();
            }
        });
    });

    $("[name='aAlertPjs']").on("click", function () {
        var mno = $(this).attr('mno');

        helper.misc.showBusyIndicator();
        $.ajax({
            url: app.siteRoot + 'Home/GetAlertPJList',
            datatype: "json",
            type: "Get",
            data: { mno: mno },
            async: false,
            success: function (data) {

                if (data.result) {

                    content = '<ul>';
                    $.each(data.AlertPJs, function (index, value) {

                        var date3_desc = '';
                        var date4_desc = '';

                        if (this.date3_diffday >= 0) {
                            date3_desc = '剩' + (this.date3_diffday) + '天';
                        }
                        else {
                            date3_desc = '<span class = "text-primary">' + '逾' + (this.date3_diffday * -1) + '天</span>';
                        }

                        if (this.date4_diffday >= 0) {
                            date4_desc = '剩' + (this.date4_diffday) + '天';
                        }
                        else {
                            date4_desc = '<span class = "text-primary">' + '逾' + (this.date4_diffday * -1) + '天</span>';
                        }

                        var msg = '<span>(' + (index + 1) + ')' + this.pjds1 + '</span>'
                            + '<span class="ps-3">工作項目：' + this.pjds2 + '</span>'
                            + '<span class="ps-3">預定完成(' + this.date4 + ' ' + ')   ' + date4_desc + '</span>'
                            + '<span class="ps-3">合約規範(' + this.date3 + ' ' + ')   ' + date3_desc + '</span>';

                        content += '<li class="list-group pb-3">' + msg + '</li>';
                    });

                    content += '</ul>';

                    jspAlertMsg($("body"), { autoclose: 5 * 60 * 1000, content: content }, null);

                } else {
                    alert("假單資料顯示失敗：\n" + data.errorMessage);
                }
            },
            complete: function () {
                helper.misc.hideBusyIndicator();
            },
            error: function (xhr, status, error) {
                var err = eval("(" + xhr.responseText + ")");
                alert(err.Message);
                helper.misc.hideBusyIndicator();
            }
        });
    });
})
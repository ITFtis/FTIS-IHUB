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

                        var msg = '<span>(' + (index + 1) + ')' + this.pjds1 + '</span>'
                            + '<span class="ps-3">預定完成(' + this.date4 + ' ' + ')   ' + this.date4_diffday + '天</span>'
                            + '<span class="ps-3">合約規範(' + this.date3 + ' ' + ')   ' + this.date3_diffday + '天</span>';

                        content += '<li class="list-group">' + msg + '</li>';
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
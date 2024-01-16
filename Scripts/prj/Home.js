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
                    $.each(data.Erps, function (index, value) {

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

                //if (data.result) {
                    //var msg = '<ul>';
                    //$.each(data.basicuser, function (index, value) {

                    //    var strPosition = this.Position == null ? '' : this.Position;

                    //    var content = '<a href="#" style="text-decoration: none" onclick = "GoEditSpecificData(\'' + this.PId + '\')">專家(' + this.PId + ' ' + this.Name + ' ' + strPosition + ')' + '</a>'
                    //        + '<span class="ps-3">' + '建檔人(' + this.BName + ')' + '</span>';

                    //    msg += '<li class="mt-2">' + content + '</li>';
                    //});

                    //msg += '</ul>';

                    //result = msg;
                //}
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

        //jspAlertMsg($("body"), { autoclose: 5000, content: msg }, null);
    });
})
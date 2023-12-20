$(document).ready(function () {
  let tableOp = douoptions.tableOptions;

  tableOp.formatShowingRows = function () {
    return "";
  };

  tableOp.formatRecordsPerPage = function () {
    return "";
  };

  douoptions.viewable = true;

  //click table cell
  tableOp.onClickCell = function (field, value, row, $element) {
    let rowIndex = $element.parent().data("index");

    if (field == "Title") {
      $(".btn-view-data-manager").eq(rowIndex).trigger("click");

      let lastTD = $(".detail-view-field").last().next();
      let lastTDtext = lastTD.text();

      let newTDtext = `<a href = ${lastTDtext} target="_blank"> ${lastTDtext} </a>`;

      lastTD.html(newTDtext);
    }
  };

  $("#_table").DouEditableTable(douoptions);
});

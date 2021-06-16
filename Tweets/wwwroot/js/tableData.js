$('th').click(function () {
    var table = $(this).parents('table').eq(0)
    var rows = table.find('tr:gt(0)').toArray().sort(comparer($(this).index()))
    this.asc = !this.asc
    if (!this.asc) {
        rows = rows.reverse()
    }
    for (var i = 0; i < rows.length; i++) {
        table.append(rows[i])
    }
})

function comparer(index) {
    return function (a, b) {
        var valA = getCellValue(a, index),
            valB = getCellValue(b, index)
        return $.isNumeric(valA) && $.isNumeric(valB) ? valA - valB : valA.toString().localeCompare(valB)
    }
}

function getCellValue(row, index) {
    return $(row).children('td').eq(index).text()
}


$(".smartphones-filter-input").on("keyup", async function () {
    const filterValue = $(".smartphones-filter-input").val();
    const result = await $.get("/Ranks/Index", $.param({
        filterValue: filterValue,
        _pageSize: 20
    }));
    $(".smartphones-table-data").html(result);
})


$("#screenSize").click(function () {
    $("#option").fadeIn();
    $("#option").css({
        display: "flex"
    });
})

$("#lessThan, #equal, #moreThan").click(function () {
    if (this.checked) {
        $("#inputField").fadeIn();
    }
})



$("#deviceName").click(function () {
    $("#option").fadeOut();
    $("#inputField").fadeIn();
})
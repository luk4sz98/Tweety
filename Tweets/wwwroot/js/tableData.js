var dane;

function displayJsonData(data) {
    $('tbody').children('tr').remove();
    for (let index = 0; index < data.length; index++) {
        $("#tabela").append('<tr>' + '<td class="ms-5">' + data[index].rank + '</td>' +
            '<td>' + data[index].device + '</td>' + '<td>' + data[index].performance + '</td>' + '<td class="d-none d-md-table-cell">' + data[index].screen + '</td>' +
            '<td class="d-none d-md-table-cell">' + data[index].hardware + '</td>' + '<td class="d-none d-md-table-cell text-center">' + data[index].popularity + '</tr>');
    }
}

var kategoriaFiltrowania;
$("#deviceName, #screenSize").click(function () {
    switch (this.id) {
        case "deviceName":
            kategoriaFiltrowania = "device";
            break;
        case "screenSize":
            kategoriaFiltrowania = "screen";
            break;
    }
});

$("#filtruj").on('input', function () {
    var phrase = $(this).val().toLowerCase();
    var filtered;
    console.log(parseFloat(phrase));
    switch (kategoriaFiltrowania) {
        case "device":
            filtered = dane.filter(x => x.device.toLowerCase().startsWith(phrase));
            break;
        case "screen":
            if ($("#lessThan").is(':checked')) {
                filtered = dane.filter(x => x.screen <= parseFloat(phrase));
                break;
            } else if ($("#equal").is(':checked')) {
                filtered = dane.filter(x => x.screen == parseFloat(phrase));
                break;
            } else if ($("#moreThan").is(':checked')) {
                filtered = dane.filter(x => x.screen >= parseFloat(phrase));
                break;
            }
    }
    displayJsonData(filtered);
});

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

async function getJsonDataAsync() {

    const response = await fetch('https://raw.githubusercontent.com/luk4sz98/json/main/dane.json');

    if (response.status !== 200) {
        console.log("Wystąpił problem. Kod statusu: " + response.status);
        return;
    }
    const data = await response.json();
    return data;
}

$(document).ready(function () {

    getJsonDataAsync().then(data => {
        dane = data;
        displayJsonData(dane);
    })
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
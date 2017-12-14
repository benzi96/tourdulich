
    //dynamicId for text box's id
    var dynamicId = 0

    //event handler for Add button
$('#btnAdd').click(function () {
    dynamicId += 1
    $('#chitiet').append(
        "<tr>" +
        "<td>" + $('#item').val() + "</td> " +
        "<td>" + $("#item option:selected").text() + "</td>" +
        '<td><button class="btn btn-danger btnDelete">Delete</button></td>'+
        '<input type="hidden" name="ct.Index" value="' + (dynamicId - 1) +'" />'+
        '<input type="hidden" name="ct[' + (dynamicId-1) +'].idkhachhang" value="' + $('#item').val() + '" />' +
        "</tr>"
    )});

$('#btnAdd1').click(function () {
    dynamicId += 1
    $('#chitiet').append(
        "<tr>" +
        "<td>" + $('#item1').val() + "</td> " +
        "<td>" + $('#item2').val() + "</td>" +
        "<td>" + $('#item3').val() + "</td>" +
        '<td><button class="btn btn-danger btnDelete">Delete</button></td>' +
        '<input type="hidden" name="ct.Index" value="' + (dynamicId - 1) + '" />' +
        '<input type="hidden" name="ct[' + (dynamicId - 1) + '].tenchiphi" value="' + $('#item1').val() + '" />' +
        '<input type="hidden" name="ct[' + (dynamicId - 1) + '].soluong" value="' + $('#item2').val() + '" />' +
        '<input type="hidden" name="ct[' + (dynamicId - 1) + '].gia" value="' + $('#item3').val() + '" />' +
        "</tr>"
    )
});

$("#chitiet").on('click', '.btn.btn-danger.btnDelete', function () {
    $(this).closest('tr').find("input[type='hidden']").remove();
    $(this).closest('tr').remove();
});

$(function () { // will trigger when the document is ready
    $('.datepicker').datepicker({ dateFormat: 'dd-mm-yy' }); //Initialise any date pickers
});



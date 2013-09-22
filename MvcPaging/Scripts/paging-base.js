function showHideMoreBtn(url) {
    var currentPgNumber = parseInt($('#currentPage').val());
    $.ajax({
        type: 'GET',
        url: siteRoot + url,
        data: { 'currentPageNumber': currentPgNumber },
        dataType: 'json',
        success: function (data) {
            if (data === true) {
                $('#moreBtn').show();
            } else {
                $('#moreBtn').hide();
            }
        }
    });
}

function incrementPageNumber() {
    var currentPgNumber = parseInt($('#currentPage').val());
    $('#currentPage').val((currentPgNumber + 1));
}

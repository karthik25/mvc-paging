$(function () {
    showHideMoreBtn('mvcpaging/checkpostsstatus');

    $(document).on('click', '#moreBtn', function (e) {
        e.preventDefault();
        var currentPgNumber = parseInt($('#currentPage').val());
        $('#moreBtnImg').show();
        $.ajax({
            type: 'GET',
            url: siteRoot + 'mvcpaging/loadmoreposts',
            data: { 'currentPageNumber': currentPgNumber },
            dataType: 'html',
            success: function (data) {
                $('#placeholder').append(data);
                $('html, body').animate({ scrollTop: $('#moreBtn').offset().top }, 1000);
                showHideMoreBtn('mvcpaging/checkpostsstatus');
                incrementPageNumber();
                $('#moreBtnImg').hide();
            },
            error: function (a, b, ctx) {
                $('#moreBtnImg').hide();
                alert('error ' + ctx);
            }
        });
    });
});

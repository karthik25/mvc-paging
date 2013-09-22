$(function () {
    showHideMoreBtn('mustachepaging/checkpostsstatus');

    $(document).on('click', '#moreBtn', function (e) {
        e.preventDefault();
        var currentPgNumber = parseInt($('#currentPage').val());
        $('#moreBtnImg').show();
        $.ajax({
            type: 'GET',
            url: siteRoot + 'mustachepaging/loadmoreposts',
            data: { 'currentPageNumber': currentPgNumber },
            dataType: 'json',
            success: function (data) {
                var tmpl = Mustache.compile("{{#Posts}}<div class=\"post-entry\" id=\"post-{{PostId}}\"><div><div class=\"pull-left\" title=\"{{PostTitle}}\">{{PostTitle}}</div><div class=\"pull-right\" style=\"color: #BDBDBD\"><b>{{Category}}</b></div></div><br><br><br><a class=\"btn btn-primary\" href=\"/Details/ViewPost?questionId={{PostId}}\">View</a></div><hr/>{{/Posts}}");
                var output = tmpl(data);
                $('#placeholder').append(output);
                $('html, body').animate({ scrollTop: $('#moreBtn').offset().top }, 1000);
                showHideMoreBtn('mustachepaging/checkpostsstatus');
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

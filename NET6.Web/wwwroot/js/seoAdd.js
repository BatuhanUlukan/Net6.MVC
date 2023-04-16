$(document).ready(function () {

    $("#seoSave").click(function (event) {
        event.preventDefault();

        var addUrl = app.Urls.seoAddUrl;
        var redirectUrl = app.Urls.portfolioAddUrl || app.Urls.articleAddUrl || app.Urls.aboutAddUrl; // use articleAddUrl if portfolioAddUrl is empty

        var seoAddDto = {
            Author: $("input[id=seoAuthor]").val(),
            Description: $("input[id=seoDescription]").val(),
            Keywords: $("input[id=seoKeywords]").val()
        }

        var jsonData = JSON.stringify(seoAddDto);
        console.log(jsonData);
        $.ajax({
            url: addUrl,
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: jsonData,
            success: function (data) {
                setTimeout(function () {
                    window.location.href = redirectUrl;
                }, 1500);
            },
            error: function () {
                toast.error("Bir hata oluştu.", "Hata");
            }
        });
    });
}); 
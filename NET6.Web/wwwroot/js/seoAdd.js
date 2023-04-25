$(document).ready(function () {

    $("#seoSave").click(function (event) {
        event.preventDefault();

        var addUrl = app.Urls.seoAddUrl;

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
                    location.reload();
                }, 1500);
            },
            error: function () {
                toast.error("Bir hata oluştu.", "Hata");
            }
        });
    });
});

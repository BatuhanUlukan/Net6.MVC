$(document).ready(function () {

    $("#linkSave").click(function (event) {
        event.preventDefault();

        var addUrl = app.Urls.linkAddUrl;

        var linkAddDto = {
            Name: $("input[id=Name]").val(),
            Url: $("input[id=Url]").val(),
        }


        var jsonData = JSON.stringify(linkAddDto);
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
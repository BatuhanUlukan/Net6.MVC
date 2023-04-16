$(document).ready(function () {

    $("#categorySave").click(function (event) {
        event.preventDefault();

        var addUrl = app.Urls.categoryAddUrl;
        var redirectUrl = app.Urls.redirectUrl;

        var categoryAddDto = {
            Name: $("input[id=categoryName]").val()
        }

        var jsonData = JSON.stringify(categoryAddDto);
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
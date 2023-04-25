$(document).ready(function () {
    // CKEditor yüklenene kadar bekle
    CKEDITOR.on("instanceReady", function () {
        // sayfa yüklendiğinde localStorage'dan title ve content verilerini okuyun
        var titleValue = localStorage.getItem("title") || "";
        var contentValue = localStorage.getItem("content") || "";


        // ilgili input/textarea alanlarına değerleri yazın
        $("input[id=Title]").val(titleValue);
        CKEDITOR.instances.editor.setData(contentValue);

        // input/textarea alanlarının içeriği değiştiğinde localStorage'a kaydedin
        $("input[id=Title]").on("input", function () {
            var titleValue = $(this).val();
            localStorage.setItem("title", titleValue);
        });


        CKEDITOR.instances.editor.on("change", function () {
            var contentValue = CKEDITOR.instances.editor.getData();
            localStorage.setItem("content", contentValue);
        });

        // makale ekleme işlemi tamamlandığında localStorage'daki verileri silin
        $("#submit").submit(function () {
            localStorage.removeItem("title");
            localStorage.removeItem("content");

        });
    });
});

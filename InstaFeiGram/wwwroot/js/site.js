// Write your JavaScript code.

//funcion para validar el tipo de archivos a subir (imagenes)
function TestFileType(fileName, fileTypes) {
    if (!fileName) return;
    dots = fileName.split(".")
    fileType = "." + dots[dots.length - 1];
    return (fileTypes.join(".").indexOf(fileType) != -1) ?
        alert('Es una imagen valida, puedes continuar!') :
        alert("Por favor solo suba una imagen con estos tipos: \n\n" + (fileTypes.join(" .")) + "\n\nIntenta de nuevo con otro archivo.");
}


$("#btn_grises").click(function () {
    $("#img_imagen").css({ "-webkit-filter": "invert(100%)", "filter": "invert(100%)" });
    $("#grises").val("true");
});



//funcion para mostrar imagenes en el index
$(function () {
    $('#in_imagen').change(function (event) {
        var temporal = URL.createObjectURL(event.target.files[0]);
        $("#img_imagen").fadeIn("fast").attr('src', URL.createObjectURL(event.target.files[0]));
    })
});


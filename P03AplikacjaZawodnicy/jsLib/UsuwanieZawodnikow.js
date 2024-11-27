
$(document).ready(function () {
  
    $(".btn-danger").on("click", function () {

        var idUsuwanego = $(this).data("id");

        $("button[data-id=" + idUsuwanego + "]")
            .closest("tr").css("background-color","red");
        // wysylamy dane ajaxem na serwer
        //....
        $.ajax({
            method: "POST",
            url: "./services/UsunZawodnika.aspx",
            data: { idUsuwanego: idUsuwanego }
        })
            .done(function (msg) {

                $("button[data-id=" + idUsuwanego + "]")
                    .closest("tr").hide(2000, function () {
                        $(this).remove();
                    });

            });

       // alert(idUsuwanego);

       

    });
     

});
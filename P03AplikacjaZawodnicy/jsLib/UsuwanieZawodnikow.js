
$(document).ready(function () {
  
    $(".btn-danger").on("click", function () {

        var idUsuwanego = $(this).data("id");

        // wysylamy dane ajaxem na serwer
        //....

       // alert(idUsuwanego);

        $("button[data-id=" + idUsuwanego + "]")
            .closest("tr").hide(2000, function () {
                $(this).remove();
            });

    });
     

});
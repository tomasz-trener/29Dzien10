

$(document).ready(function () {

    $("#btnPolicz").on("click", function () {

        var liczba1 = $('#txtLiczba1').val();

        var liczba2 = $('#txtLiczba2').val();

        $('#txtWynik1').val('licze..');

        $.ajax({
            method: "POST",
            url: "./serv/Obliczenia.aspx",
            data: { liczba1: liczba1, liczba2: liczba2 }
        })
            .done(function (msg) {
                // alert("Data Saved: " + msg);
               // $('#txtWynik').val(msg);

                var obj = JSON.parse(msg);

                $('#txtWynik1').val(obj.WynikWlasciwy);
                $('#txtWynik2').val(obj.LiczbaZnakow);
                $('#txtWynik3').val(obj.Opis);

            });




        //var wynik = parseInt(liczba1) + parseInt(liczba2);

        //$('#txtWynik').val(wynik);
    });


});
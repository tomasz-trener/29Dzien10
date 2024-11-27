

$(document).ready(function () {
    var aktualnaStrona = 1;
    var ileRekordow = 2;
    function wczytajTrenerow(strona,ile) {

        $.ajax({
            method: "POST",
            url: "./services/StronicowanieTrenerzy.aspx",
            data: { strona: strona, ileRekordow: ile }
        })
            .done(function (msg) {
                debugger;
                var wiersze = "";
                msg.Trenerzy.forEach(function (trener) {

                    wiersze += "<tr><td>" + trener.Imie + "</td><td>" + trener.Nazwisko + "</td></tr>";
                });
                $("#tbodyTrenerzy").html(wiersze);

                $("#nrStrony").text(aktualnaStrona);

                $("#wstecz").prop("disabled", aktualnaStrona <= 1);
                $("#nastepny").prop("disabled", msg.IleStron <= aktualnaStrona);
            });
    }


    wczytajTrenerow(aktualnaStrona, ileRekordow);


    $("#wstecz").on("click", function () {
        if (aktualnaStrona > 1) {
            aktualnaStrona--;
            wczytajTrenerow(aktualnaStrona, ileRekordow);
        }
    });


    $("#nastepny").on("click", function () {
        aktualnaStrona++;
        wczytajTrenerow(aktualnaStrona, ileRekordow);
    });


});
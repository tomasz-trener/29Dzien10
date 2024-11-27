

$(document).ready(function () {

    $("#btnAjaxZapisz").on("click", function (e) {
        e.preventDefault();

        //zbieramy dane z formularza 
        var id = $("#glownyObaszar_txtId").val();
        var imie = $("#glownyObaszar_txtImie").val();
        var nazwisko = $("#glownyObaszar_txtNazwisko").val();
        var kraj= $("#glownyObaszar_txtKraj").val();
        var dataUr = $("#glownyObaszar_txtDataUr").val();
        var wzrost = $("#glownyObaszar_txtWzrost").val();
        var waga = $("#glownyObaszar_txtWaga").val();
        var trenerId = $("#glownyObaszar_ddlTrener").val();


        $.ajax({
            method: "POST",
            url: "./services/ZapiszZawodnika.aspx",
            data: {
                id: id,
                imie: imie,
                nazwisko: nazwisko,
                kraj: kraj,
                dataUr: dataUr,
                wzrost: wzrost,
                waga: waga,
                trenerId: trenerId
            }
        })
            .done(function (msg) {
                alert("Zapisano zmiany!");
            })
            .fail(function () {
                alert("Wyst¹pi³ b³¹d podczas zapisywania damin");
            })
    });


});
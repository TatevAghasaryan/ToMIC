$(function () {

    //var url = "http://api.openweathermap.org/data/2.5/weather?q=Yerevan&appid=bd82977b86bf27fb59a04b61b657fb6f";
    //var a = "https://raw.githubusercontent.com/mledoze/countries/master/countries.json";
    var urll = "https://raw.githubusercontent.com/mledoze/countries/master/countries.json";

    console.log(typeof (a));
    $.getJSON(urll, function (data) {
        $.each(data, function (i, data) {
            $('#capitals').append($('<option>').text(data.capital).attr('value', data.capital));
            console.log(data.capital);

        })
    });
    var obj = $("#capitals option:selected").text();
    var url = "http://api.openweathermap.org/data/2.5/weather?q=" + obj + "&appid=bd82977b86bf27fb59a04b61b657fb6f";

    $("#get").click(function () {
        $.getJSON(url, function (data) {

            console.log(data);

        })
    });
});







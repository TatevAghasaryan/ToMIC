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
    

    $("#get").click(function () {
        var obj = $("#capitals option:selected").text();
        var url = "http://api.openweathermap.org/data/2.5/weather?q=" + obj + "&appid=bd82977b86bf27fb59a04b61b657fb6f";
        $.getJSON(url, function (data) {
            $('#name').text(data.name);
            $('#coordLat').text(data.coord.lat);
            $('#coordLon').text(data.coord.lon);
            $('#mainHumidity').text(data.main.humidity);
            $('#mainPressure').text(data.main.pressure);
            $('#mainTemp').text(data.main.temp);
            $('#mainTempMax').text(data.main.temp_max);
            $('#mainTempMin').text(data.main.temp_min);
            
        })
    });
});







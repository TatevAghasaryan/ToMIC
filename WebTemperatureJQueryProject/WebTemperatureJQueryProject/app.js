$(function () {
    
 //   $.getJSON('https://freegeoip.net/json/')
 //    .done(function (location) {
 //        $('#country').html(location.country_name);
 //        $('#country_code').html(location.country_code);
 //        $('#region').html(location.region_name);
 //        $('#region_code').html(location.region_code);
 //        $('#city').html(location.city);
 //        $('#latitude').html(location.latitude);
 //        $('#longitude').html(location.longitude);
 //        $('#timezone').html(location.time_zone);
 //        $('#ip').html(location.ip);
    //});


    $.getJSON('https://raw.githubusercontent.com/mledoze/countries/master/countries.json')
     .done(function (location) {
         $('#country').html(location.country_name);
         $('#country_code').html(location.country_code);
         $('#region').html(location.region_name);
         $('#region_code').html(location.region_code);
         $('#city').html(location.capital);
         $('#latitude').html(location.latitude);
         $('#longitude').html(location.longitude);
         $('#timezone').html(location.time_zone);
         $('#ip').html(location.ip);
     });
});





//$(function () {
//    alert("Your location is: " + geoplugin_countryName() + ", " + geoplugin_region() + ", " + geoplugin_city());

//    var country = geoplugin_countryName();
//    $("#country").append("<option value='1' selected>" + country + "</option>");

//    var zone = geoplugin_region();
//    $("#zone").append("<option value='1' selected>" + zone + "</option>");

//    var district = geoplugin_city();
//    $("#district").append("<option value='1' selected>" + district + "</option>");
//});






//$.ajax({
//    url: 'https://raw.githubusercontent.com/mledoze/countries/master/countries.json',
//})
//.done(function (data) {
    
//    data.filter(function (data) {
//        return data.area >= 30000;
//    }).forEach(function (s) {
//        console.log(s);
//    })
//})
//.fail(function () {
//    alert("Ajax failed to fetch data")
//})

//$(function () {
//    var url = "http://api.openweathermap.org/data/2.5/weather?q=Yerevan&appid=bd82977b86bf27fb59a04b61b657fb6f";
//    var $container = $('.container');
//    var $result = $('<textarea>').addClass('result');
//    var urlFinal = url.split('=', '&');
//    var urlFi = urlFinal.split('&');
//    console.log(urlFi);
//    $.getJSON(url, function (data) {
//        var $res = data.capital;
//        $("#find").click(function () {
//            var text = $("#comment").val();
//            var $newItem = $result.clone();
//            $newItem.html(text);
//            $newItem.hide();
//            $container.append($newItem);
//            $newItem.show(500);
//        });
//    });
    

//});



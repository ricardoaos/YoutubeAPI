$(document).ready(function(){
	$("form").on("submit", function(e) {
       e.preventDefault();
	   
	$.getJSON('https://localhost:44337/api/Youtube?search='+$("#search").val(), function(data) {
		$.each(data, function (key, item) {
			//console.log(item);
			$('#results').append("<li>"+ item +"</li>");
		});
		resetVideoHeight();
       });
    });
});

function resetVideoHeight() {
    $(".video").css("height", $("#results").width() * 9/16);
}
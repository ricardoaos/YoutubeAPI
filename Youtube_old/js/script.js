function tplawesome(e,t){res=e;for(var n=0;n<t.length;n++){res=res.replace(/\{\{(.*?)\}\}/g,function(e,r){return t[n][r]})}return res}

$(document).ready(function(){	
	$.get("https://localhost:44337/api/Youtube?search=corinthians",
		function(data){
			$.each(data, function(i, item){
            $.get("tpl/item.html", function(data) {
                $("#results").append(tplawesome(data, [{"title":item.snippet.title, "videoid":item.id.videoId}]));
            });
          })
		}
	);
});
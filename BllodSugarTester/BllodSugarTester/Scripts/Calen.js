function testThis(){
$(document).ready(function(){
	
	
	
    var url = "https://www.googleapis.com/calendar/v3/users/me/calendarList";
    $.ajax({
        type : 'GET',
        data : {},
        url : url,
        dataType: 'json',
        success : function(data) {              
           
           console.log(data);

            var petfinder = data.petfinder;
            
						
        },
        error : function(request,error)
        {
            console.log("error");
        }
    });
});

 }
 

 
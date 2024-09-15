function showAlert(){
    alert("Thanks For Reading!");
}
function Visibility(paragraphId){
    var element = document.getElementById(paragraphId)
    if(element.style.display === "none"){
        element.style.display = "block";
    }
    else{
        element.style.display = "none";
    }
}
function toTrailer(url){
    window.location.href = url;
}

function ratingBackground(ratingId) {
    const ratingElement = document.getElementById(ratingId);
    const ratingText = ratingElement.textContent;
    
    const rating = parseFloat(ratingText.split(': ')[1]);

    // Change the background color based on the rating
    if (rating >= 8) {
        ratingElement.style.backgroundColor = 'green';
        ratingElement.style.color = 'white';
    } 
    else if (rating >= 6) {
        ratingElement.style.backgroundColor = 'orange';
        ratingElement.style.color = 'white';
    } 
    else {
        ratingElement.style.backgroundColor = 'red';
        ratingElement.style.color = 'white';
    }
}

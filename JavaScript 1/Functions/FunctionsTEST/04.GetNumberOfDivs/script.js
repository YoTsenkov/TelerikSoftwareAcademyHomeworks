function onClick() {
    var divCounter = document.getElementsByTagName("div").length;    
    
    appendDiv(divCounter);
}

function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
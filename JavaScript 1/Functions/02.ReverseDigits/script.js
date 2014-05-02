function onClick() {
    var number = parseInt(document.getElementById('number').value);
    var numberAsString = number.toString();
    var resultNumber = new String();

    for (var i = numberAsString.length - 1; i >= 0; i--) {
        resultNumber += numberAsString[i];
    }

    appendDiv(parseInt(resultNumber));
}

function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
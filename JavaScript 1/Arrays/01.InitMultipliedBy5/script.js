function onClick() {
    var array = [];
    var result = new String();
    for (var i = 0; i < 20; i++) {
        array.push(i * 5);
        result += array[i].toString() + ' ';
    }

    appendDiv(result);
}

function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
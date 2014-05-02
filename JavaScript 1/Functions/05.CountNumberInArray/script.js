function onClick() {
    var array = document.getElementById('array').value.split(' ');
    var number = parseInt(document.getElementById('number').value);
    var counter = 0;

    for (var i = 0; i < array.length; i++) {
        if (parseInt(array[i]) === number) {
            counter++;
        }
    }

    appendDiv(counter);
}

function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
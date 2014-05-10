function onClick() {
    var array = document.getElementById('array').value.split(' ');
    var hasBeenFound = false;

    for (var i = 1; i < array.length - 1; i++) {
        var number = array[i];

        if (number > array[i - 1] && number > array[i + 1]) {
            hasBeenFound = true;
            appendDiv("Index -> " + i);
            return;
        }
    }

    if (!hasBeenFound) {
        appendDiv(-1);
    }
}

function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
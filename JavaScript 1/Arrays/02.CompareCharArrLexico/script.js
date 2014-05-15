function onClick() {
    var first = document.getElementById('first').value.split(' ');
    var second = document.getElementById('second').value.split(' ');
    var minLength = new Number();
    var hasBeenFound = false;

    if (first.length > second.length) {
        minLength = first.length;
    }
    else {
        minLength = second.length;
    }

    for (var i = 0; i < minLength; i++) {
        if (first[i] > second[i]) {
            appendDiv('The first array is first lexicographically.')
            hasBeenFound = true;
            break;
        }
        else if (first[i] < second[i]) {
            appendDiv('The second array is first lexicographically.')
            hasBeenFound = true;
            break;
        }
        else {
            continue;
        }
    }

    if (!hasBeenFound) {
        if (first.length > second.length) {
            appendDiv('The second array is first lexicographically.')
        }
        else if (first.length < second.length) {
            appendDiv('The first array is first lexicographically.')
        }
        else {
            appendDiv('The arrays are indentical.')
        }
    }
}

function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
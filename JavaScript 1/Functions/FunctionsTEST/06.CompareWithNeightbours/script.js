function onClick() {
    var array = document.getElementById('array').value.split(' ');
    var position = parseInt(document.getElementById('position').value);
    if (position < 0 || position >= array.length) {
        appendDiv('The position is out of the boundaries of the array !');
        return;
    }
    else if (position === 0 || position === array.length - 1) {
        appendDiv('The element has only ONE neightbour.')
    }
    else {
        var number = array[position];
        var isBigger = false;

        if (number > array[position + 1] && number > array[position - 1]) {
            isBigger = true;
        }

        appendDiv('Is the element at position ' + position + ' is bigger than its two neightbours? -> ' + isBigger);
    }



}

function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
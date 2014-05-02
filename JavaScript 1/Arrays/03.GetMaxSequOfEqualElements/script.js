function onClick() {
    var array = document.getElementById('array').value.split(' ');
    var maxSeq = 1;
    var startIndex = new Number();
    var endIndex = new Number();

    for (var index in array) {
        array[index] = parseInt(array[index]);
    }

    for (var i = 0; i < array.length - 1; i++) {
        var currentSeq = 1;

        for (var k = i + 1; k < array.length; k++) {
            if (array[i] === array[k]) {
                currentSeq++;
                if (currentSeq > maxSeq) {
                    maxSeq = currentSeq;
                    startIndex = i;
                    endIndex = k;
                }
            }
            else {
                break;
            }
        }
    }
    appendDiv(maxSeq + ' times');

    var result = new String();
    for (var i = startIndex; i <= endIndex; i++) {
        result += array[i].toString() + ' ';
    }
    appendDiv(result);
}



function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
function onClick() {
    var array = document.getElementById('array').value.split(' ');
    var maxCount = new Number();
    var number = new Number();

    for (var i = 0; i < array.length - 1; i++) {
        var currentCount = 1;
        for (var k = i + 1; k < array.length; k++) {
            if (array[i] === array[k]) {
                currentCount++;
                if (currentCount > maxCount) {
                    maxCount = currentCount;
                    number = array[i];
                }
            }
        }
    }

    appendDiv(number.toString() + '(' + maxCount.toString() + ' times)');
}

function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
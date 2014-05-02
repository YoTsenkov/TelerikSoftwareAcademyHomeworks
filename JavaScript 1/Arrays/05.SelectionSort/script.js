function onClick() {
    var array = document.getElementById('array').value.split(' ');
    var smallest = new Number();
    var smallestIndex = new Number();
    var smallerFound = false;

    for (var i = 0; i < array.length - 1; i++) {
        smallest = array[i];
        smallerFound = false;

        for (var k = i + 1; k < array.length; k++) {
            if (array[k] < smallest) {
                smallest = array[k];
                smallestIndex = k;
                smallerFound = true;
            }
        }
        if (smallerFound) {
            var buff = array[i];
            array[i] = array[smallestIndex];
            array[smallestIndex] = buff;
        }
    }
    var result = new String();
    for (var index in array) {
        result += array[index].toString() + ' ';
    }
    appendDiv(result);
}



function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
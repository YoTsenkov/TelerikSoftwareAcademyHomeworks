function onClick() {
    var array = document.getElementById('array').value.split(' ');
    var key = parseInt(document.getElementById('key').value);
    var found = false;

    //maxIndex is never used..I just have some weird problem with assigning value to
    //the max variable and this seems to fix it (no idea why).. if I remove it my max variable
    //gets assigned value 1.5 (no idea why)
    var maxIndex = array.length;

    for (var index in array) {
        array[index] = parseInt(array[index]);
    }

    
    var max = array.length;
    var min = 0;    

    while (max >= min) {
        var mid = Math.floor((min + max) / 2);
        if (array[mid] === key) {
            appendDiv('Key index -> ' + mid);
            found = true;
            break;
        }
        else if (array[mid] < key) {
            min = mid + 1;
        }
        else {
            max = mid - 1;
        }
    }

    if (!found) {
        appendDiv('Key not found');
    }
}

function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
function onClick() {
    var number = parseInt(document.getElementById('number').value);

    var lastDigit = number % 10;

    switch (lastDigit) {
        case 0:
            appendDiv('Zero');
            break;
        case 1:
            appendDiv('One');
            break;
        case 2:
            appendDiv('Two');
            break;
        case 3:
            appendDiv('Three');
            break;
        case 4:
            appendDiv('Four');
            break;
        case 5:
            appendDiv('Five');
            break;
        case 6:
            appendDiv('Six');
            break;
        case 7:
            appendDiv('Seven');
            break;
        case 8:
            appendDiv('Eight');
            break;
        case 9:
            appendDiv('Nine');
            break;
        default:

    }
}

function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
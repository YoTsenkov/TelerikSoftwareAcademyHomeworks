function generateRandomNumber(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function generateRandomColor() {
    var red = generateRandomNumber(0, 255),
        green = generateRandomNumber(0, 255),
        blue = generateRandomNumber(0, 255);

    return 'rgb(' + red + ',' + green + ',' + blue + ')';
}

function createDiv() {
    var div = document.createElement('div'),
        strong = document.createElement('strong');

    div.style.width = generateRandomNumber(20, 100) + 'px';
    div.style.height = generateRandomNumber(20, 100) + 'px';
    div.style.background = generateRandomColor();
    div.style.color = generateRandomColor();
    div.style.position = 'absolute';
    div.style.top = generateRandomNumber(0, window.innerWidth) + 'px';
    div.style.left = generateRandomNumber(0, window.innerHeight) + 'px';
    strong.innerText = 'div';
    div.appendChild(strong);
    div.style.borderRadius = generateRandomNumber(0, 100) + 'px';
    div.style.borderColor = generateRandomColor();
    div.style.borderWidth = generateRandomNumber(1, 20) + 'px';
    div.style.textAlign = 'center';
    return div;
}

window.onload = function () {
    var container = new DocumentFragment();

    for (var i = 0; i < 50; i += 1) {
        container.appendChild(createDiv());
    }

    document.body.appendChild(container);
};
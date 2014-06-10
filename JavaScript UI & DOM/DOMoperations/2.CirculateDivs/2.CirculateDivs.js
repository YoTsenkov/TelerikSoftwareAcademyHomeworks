window.onload = function () {
    var divs = document.querySelectorAll('div'),
        center = {
            x: 500,
            y: 300
        },
        radius = 150,
        angle = 0;

    for (var i = 0, len = divs.length; i < len; i++) {
        divs[i].style.width = '30px';
        divs[i].style.height = '20px';
        divs[i].style.position = 'relative';
        divs[i].style.border = '1px solid black';
    }

    function drawDiv(divElement, x, y) {
        divElement.style.top = y + 'px';
        divElement.style.left = x + 'px';
    }

    function rotateDivs (){
        angle += 0.1;
        var lol = 0;
        for (var i = 0, len = divs.length; i < len; i++) {
            var x = center.x + radius * Math.cos(angle + lol),
                y = center.y + radius * Math.sin(angle + lol);
            drawDiv(divs[i], x, y);
            lol += 360/5;
        }

        setTimeout(rotateDivs, 100);
    }

    //they look strange because the top left corners are attached to the circle and not the div center ;D
    rotateDivs();
};
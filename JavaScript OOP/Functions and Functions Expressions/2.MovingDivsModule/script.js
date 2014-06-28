var movingShapes = function () {
    "use strict";
    var rect = {
            x: 50,
            y: 50,
            width: 100,
            height: 100
        },
        center = {
            x: 500,
            y: 300
        },
        radius = 150,
        angle = 0;

    function generateRandomNumber(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    function generateRandomColor() {
        var red = generateRandomNumber(0, 255),
            green = generateRandomNumber(0, 255),
            blue = generateRandomNumber(0, 255);

        return 'rgb(' + red + ',' + green + ',' + blue + ')';
    }

    function add(trajectoryType) {
        if (trajectoryType === 'rect') {
            appendRectDiv();
        } else if (trajectoryType === 'ellipse') {
            appendCircDiv();
        }
    }

    function createRectDiv() {
        "use strict";
        var div = document.createElement('div');
        div.style.width = '30px';
        div.style.height = '20px';
        div.style.position = 'absolute';
        div.style.border = '1px solid black';
        div.style.top = rect.y + 'px';
        div.style.left = rect.x + 'px';
        div.className = 'rect';
        div.style.background = generateRandomColor();
        div.style.borderColor = generateRandomColor();

        return div;
    }

    function createCircDiv() {
        "use strict";
        var div = document.createElement('div');
        div.style.width = '30px';
        div.style.height = '20px';
        div.style.position = 'absolute';
        div.style.border = '1px solid black';
        div.className = 'ellipse';
        div.style.background = generateRandomColor();
        div.style.borderColor = generateRandomColor();

        return div;
    }

    function appendRectDiv() {
        var div = createRectDiv();
        document.body.appendChild(div);
    }

    function appendCircDiv() {
        var div = createCircDiv();
        document.body.appendChild(div);
    }

    function updateRectDivs() {
        "use strict";
        var rectDivs = document.querySelectorAll('div.rect');
        for (var i = 0, len = rectDivs.length; i < len; i += 1) {
            if (rectDivs[i].offsetLeft < rect.x + rect.width && rectDivs[i].offsetTop === rect.y) {
                rectDivs[i].style.left = (rectDivs[i].offsetLeft + 1) + 'px';
            }

            if (rectDivs[i].offsetLeft === rect.x + rect.width && rectDivs[i].offsetTop <= rect.y + rect.height) {
                rectDivs[i].style.top = (rectDivs[i].offsetTop + 1) + 'px';
            }

            if (rectDivs[i].offsetTop === rect.y + rect.height && rectDivs[i].offsetLeft > rect.x) {
                rectDivs[i].style.left = (rectDivs[i].offsetLeft - 1) + 'px';
            }

            if (rectDivs[i].offsetTop >= rect.y && rectDivs[i].offsetLeft === rect.x) {
                rectDivs[i].style.top = (rectDivs[i].offsetTop - 1) + 'px';
            }
        }

        setTimeout(updateRectDivs, 10);
    }

    function updateCircDivs() {
        var circDivs = document.querySelectorAll('div.ellipse');
        angle += 0.1;
        var lol = 0;
        for (var i = 0, len = circDivs.length; i < len; i += 1) {
            var x = center.x + radius * Math.cos(angle + lol),
                y = center.y + radius * Math.sin(angle + lol);
            circDivs[i].style.top = y + 'px';
            circDivs[i].style.left = x + 'px';
            lol += 360 / 5;
        }

        setTimeout(updateCircDivs, 10);
    }

    updateRectDivs();
    updateCircDivs();

    return {
        add: add
    };

}();

movingShapes.add('rect');
movingShapes.add('ellipse');
movingShapes.add('ellipse');
movingShapes.add('ellipse');

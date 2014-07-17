var drawingShapes = (function () {
    var canvas = document.getElementById('canvas'),
        ctx = canvas.getContext('2d');

    canvas.style.width = window.innerWidth;
    canvas.style.height = window.innerHeight;

    function drawRect(x, y, width, height) {
        ctx.beginPath();
        ctx.strokeRect(x, y, width, height);
    }

    function drawCircle(x, y, r) {
        ctx.beginPath();
        ctx.arc(x, y, r, 0, 2 * Math.PI);
        ctx.stroke();
    }

    function drawLine(startX, startY, endX, endY) {
        ctx.beginPath();
        ctx.moveTo(startX, startY);
        ctx.lineTo(endX, endY);
        ctx.stroke();
    }

    return {
        drawRect: drawRect,
        drawCircle: drawCircle,
        drawLine: drawLine
    }
}());

drawingShapes.drawRect(50, 50, 100, 100);
drawingShapes.drawCircle(200, 100, 10);
drawingShapes.drawLine(220, 100, 250, 120);
window.onload = function () {
    var canvas = document.getElementById('canvas');
    canvas.style.border = '1px solid black';
    var ctx = canvas.getContext('2d');
    var x = 400,
        y = 300,
        xVelocity = 5,
        yVelocity = 10;

    function init() {       
        return setInterval(draw, 10);
    }

    function draw() {
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        
        ctx.beginPath();
        ctx.arc(x, y, 50, 0, 2 * Math.PI);
        ctx.closePath();
        ctx.fill();
        if (x >= 750 || x <= 50) {            
            if (xVelocity > 0) {
                xVelocity = -Math.random() * 5;
            }
            else {
                xVelocity = Math.random() * 5;
            }
        }
        if (y >= 550 || y <= 50) {            
            if (yVelocity > 0) {
                yVelocity = -Math.random() * 5;
            }
            else {
                yVelocity = Math.random() * 5;
            }
        }
        
        x += xVelocity;
        y += yVelocity;      
    }

    init()
}
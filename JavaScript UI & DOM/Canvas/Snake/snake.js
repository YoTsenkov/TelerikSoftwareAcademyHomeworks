/**
 * Created by Dani on 6/5/2014.
 */
var initialHeadElement = {
        x: 400,
        y: 300
    },
    snakeBody = [],
    xVelocity = -10,
    yVelocity = 0,
    lastPressedKeyCode = 37,
    hasEaten = false;


function createBodyElement(x, y) {
    return {
        x: x,
        y: y
    };
}
function initializeSnake() {
    snakeBody = [];
    snakeBody.push(initialHeadElement);
    for (var i = 0; i < 3; i++) {
        var bodyElement = createBodyElement(snakeBody[i].x + 10, snakeBody[i].y);
        snakeBody.push(bodyElement);
    }
}

function drawSnake(ctx) {
    ctx.fillStyle = '#9E51CF';
    ctx.fillRect(snakeBody[0].x, snakeBody[0].y, 10, 10);
    ctx.fillStyle = '#C89AE6';
    for (var i = 1; i < snakeBody.length; i += 1) {
        ctx.fillRect(snakeBody[i].x, snakeBody[i].y, 10, 10);
    }

}

function updateSnake() {
    if(!hasEaten) {
        snakeBody.pop();
    }
    var newHead = createBodyElement(snakeBody[0].x + xVelocity, snakeBody[0].y + yVelocity);
    snakeBody.unshift(newHead);
    hasEaten = false;
}

function checkCollision() {
    if (snakeBody[0].x < 0 || snakeBody[0].y < 0 ||
        snakeBody[0].x >= WINDOW_WIDTH || snakeBody[0].y >= WINDOW_HEIGHT) {

        window.clearInterval(intervalID);
    }

    for (var index = 1; index < snakeBody.length; index += 1) {
        if (snakeBody[0].x < snakeBody[index].x + 10 && snakeBody[0].x + 10 > snakeBody[index].x &&
            snakeBody[0].y < snakeBody[index].y + 10 && snakeBody[0].y + 10 > snakeBody[index].y) {


            window.clearInterval(intervalID);
        }
    }

    if (snakeBody[0].x < food.x + 10 && snakeBody[0].x + 10 > food.x &&
        snakeBody[0].y < food.y + 10 && snakeBody[0].y + 10 > food.y) {

        hasEaten = true;

        food = generateFood();
    }
}

document.onkeydown = function () {
    switch (window.event.keyCode) {
        case 37:
            if (39 !== lastPressedKeyCode) {

                lastPressedKeyCode = 37;
                xVelocity = -10;
                yVelocity = 0;
            }
            break;
        case 38:
            if (40 !== lastPressedKeyCode) {
                lastPressedKeyCode = 38;
                xVelocity = 0;
                yVelocity = -10;
            }
            break;
        case 39:
            if (37 !== lastPressedKeyCode) {
                lastPressedKeyCode = 39;
                xVelocity = 10;
                yVelocity = 0;
            }
            break;
        case 40:
            if (38 !== lastPressedKeyCode) {
                lastPressedKeyCode = 40;
                xVelocity = 0;
                yVelocity = 10;
            }
            break;
    }
};
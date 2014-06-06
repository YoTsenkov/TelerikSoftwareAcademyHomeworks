/**
 * Created by Dani on 6/5/2014.
 */
var food,
    intervalID,
    currentScore = 0;

function startNewGame(ctx) {
    initializeSnake();
    currentScore = 0;
    food = generateFood();
    intervalID = window.setInterval(function () {
            ctx.clearRect(0, 0, WINDOW_WIDTH, WINDOW_HEIGHT);
            drawFood(ctx, food);
            drawSnake(ctx);
            updateSnake();
            checkCollision();
        }, 100
    );
}

function checkCollision() {
    if (snakeBody[0].x < 0 || snakeBody[0].y < 0 ||
        snakeBody[0].x >= WINDOW_WIDTH || snakeBody[0].y >= WINDOW_HEIGHT) {

        alert('SCORE ' + currentScore)
        window.clearInterval(intervalID);
    }

    for (var index = 1; index < snakeBody.length; index += 1) {
        if (snakeBody[0].x < snakeBody[index].x + 10 && snakeBody[0].x + 10 > snakeBody[index].x &&
            snakeBody[0].y < snakeBody[index].y + 10 && snakeBody[0].y + 10 > snakeBody[index].y) {

            alert('SCORE ' + currentScore)
            window.clearInterval(intervalID);
        }
    }

    if (snakeBody[0].x < food.x + 10 && snakeBody[0].x + 10 > food.x &&
        snakeBody[0].y < food.y + 10 && snakeBody[0].y + 10 > food.y) {

        hasEaten = true;
        currentScore += 1;

        food = generateFood();
    }
}



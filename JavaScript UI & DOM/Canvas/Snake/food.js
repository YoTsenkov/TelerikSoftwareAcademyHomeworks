/**
 * Created by Dani on 6/5/2014.
 */
function getRandomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1) + min);
}

function getRandomX() {
    return getRandomInt(0, 79) * 10;
}

function getRandomY() {
    return getRandomInt(0, 59) * 10;
}

function generateFood(){
    return {
        x: getRandomX(),
        y: getRandomY()
    };
}

function drawFood(ctx, food){
    ctx.fillStyle = '#4EF5A7';
    ctx.fillRect(food.x,food.y,10,10);
}

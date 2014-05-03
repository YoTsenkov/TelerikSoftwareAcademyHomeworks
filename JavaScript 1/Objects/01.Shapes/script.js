function createPoint(x, y) {
    return {
        x: x,
        y: y
    }
}

function createLine(startPoint, endPoint) {
    return {
        x1: startPoint.x,
        y1: startPoint.y,
        x2: endPoint.x,
        y2: endPoint.y,
        length: function () {
            var length = getDistance(startPoint, endPoint);
            return length;
        }
    }
}

function getDistance(pointOne, pointTwo) {
    var distance = Math.sqrt(Math.pow((pointOne.x - pointTwo.x), 2) + Math.pow((pointOne.y - pointTwo.y), 2));
    return distance;
}

function canFormTriangle(lineOne, lineTwo, lineThree) {
    if ((lineOne.length() + lineTwo.length()) > lineThree.length() &&
        (lineOne.length() + lineThree.length()) > lineTwo.length() &&
        (lineTwo.length() + lineThree.length()) > lineOne.length()) {
        return true;
    }
    else {
        return false;
    }
}

//test getDistance
var pointOne = createPoint(2, 5);
var pointTwo = createPoint(5, 8);
console.log(getDistance(pointOne, pointTwo));

//test length()
var lineOne = createLine(pointOne, pointTwo);
console.log(lineOne.length());

//test canFormTriangle
var lineTwo = createLine(createPoint(5, 7), createPoint(6, 9));
var lineThree = createLine(createPoint(6, 7), createPoint(3, 5));
console.log(canFormTriangle(lineOne, lineTwo, lineThree));




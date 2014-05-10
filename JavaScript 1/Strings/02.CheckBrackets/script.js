function checkBrackets(expression) {
    var openingBrackets = 0;
    var closingBrackets = 0;

    for (var i = 0; i < expression.length; i++) {
        if (expression[i] === '(') {
            openingBrackets++;
        }

        if (expression[i] === ')') {
            closingBrackets++;
        }
    }

    if (openingBrackets === closingBrackets) {
        console.log('Correct brackets');
    }
    else {
        console.log('Incorrect brackets');
    }
}

var expression = '((a+b) / 5 - d)';

checkBrackets(expression);

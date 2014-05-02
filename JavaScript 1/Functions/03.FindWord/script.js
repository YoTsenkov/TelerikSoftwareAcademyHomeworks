function onClick(caseMode) {
    var initialWord = document.getElementById('word').value;

    if (caseMode === 'insensitive') {
        var text = document.getElementById('text').value.toUpperCase();        
        var word = initialWord.toUpperCase();
    }
    else {
        var text = document.getElementById('text').value;
        var word = document.getElementById('word').value;
    }

    var occurances = new Number();
    var textSplit = text.split(' ');

    for (var i = 0; i < textSplit.length; i++) {
        if (textSplit[i] === word) {
            occurances++;
        }
    }

    appendDiv('The word ' + initialWord + ' occures ' + occurances + ' times.');
}

function appendDiv(message) {
    var element = document.createElement('div');
    element.innerHTML = message;
    document.body.appendChild(element);
}
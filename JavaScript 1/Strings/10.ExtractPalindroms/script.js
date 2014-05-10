var text = 'afggfa gasvd asj bsad a nsb exe asduiasbpi  ghhg niocvoi[ tyuyt';
var splitText = text.split(' ');
var palindroms = [];

for (var index in splitText) {
    var wordLength = splitText[index].length;
    var firstHalf = splitText[index].slice(0, Math.floor(wordLength / 2));
    var secondHalf;
    if (wordLength % 2 === 0) {
        secondHalf = splitText[index].slice(Math.floor(wordLength / 2), wordLength);
    }
    else {
        secondHalf = splitText[index].slice(Math.floor(wordLength / 2) + 1, wordLength);
    }

    var reversedSecondHalf = new String();
    for (var i = secondHalf.length - 1; i >= 0; i--) {
        reversedSecondHalf += secondHalf[i];
    }
    if (firstHalf === reversedSecondHalf) {
        palindroms.push(splitText[index])
    }
}

for (var i in palindroms) {
    console.log(palindroms[i]);
}

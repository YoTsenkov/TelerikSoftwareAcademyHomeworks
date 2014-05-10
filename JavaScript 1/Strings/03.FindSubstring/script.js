function searchText(text, substring) {
    var text = text.toUpperCase();
    var regex = new RegExp(substring.toUpperCase(), 'g');
    var resultArray = text.match(regex);

    if (resultArray === null) {
        return 0;
    }
    else {
        return resultArray.length;
    }
}

var text = 'This is Sparta!';
var substring = 'SpAr';

console.log(searchText(text, substring));
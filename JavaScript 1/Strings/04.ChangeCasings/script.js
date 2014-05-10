function changeCasings(text) {
    var array;

    while (true) {
        array = text.match(/<mixcase>(.*?)<\/mixcase>/);
        if (array === null) {
            break;
        }

        var initialString = array[1].toString();
        var mixCased = new String();
        for (var i = 0; i < array[1].length; i++) {
            var random = Math.random();
            if (random < 0.5) {
                mixCased += initialString[i].toUpperCase()
            }
            else {
                mixCased += initialString[i].toLowerCase();;
            }
        }

        text = text.replace(array[0].toString(), mixCased);
    }

    while (true) {
        array = text.match(/<upcase>(.*?)<\/upcase>/);
        if (array === null) {
            break;
        }

        text = text.replace(array[0].toString(), array[1].toString().toUpperCase());
    }

    while (true) {
        array = text.match(/<lowcase>(.*?)<\/lowcase>/);
        if (array === null) {
            break;
        }

        text = text.replace(array[0].toString(), array[1].toString().toLowerCase());
    }

    return text;
}

var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>ANYTHING</lowcase> else.';

console.log(changeCasings(text));


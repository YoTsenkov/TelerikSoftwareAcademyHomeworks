function replaceTags(text) {
    while (true) {
        var matched = text.match(/<a(.*?)>/);
        if (matched === null) {
            break;
        }
        var innerText = matched[1];
        var innerMatched = innerText.match(/"(.*?)"/);
        var href = innerMatched[1];
        var newTag = '[URL=' + href + ']';

        text = text.replace(matched[0], newTag)
        text = text.replace('</a>', '[/URL]');
    }

    return text;
}

var text = '<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
console.log(replaceTags(text));
var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net",
    "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC",
    "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS",
    "javascript", "javascript", "javascript", "javascript", "javascript", "javascript", "javascript",
    "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml",
    "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml", "xaml",
    "xaml", "xaml", "ASP.NET MVC", "ASP.NET MVC", "ASP.NET MVC", "ASP.NET MVC", "ASP.NET MVC",
    "html", "html", "html", "html", "html", "html", ];

generateTagCloud(tags, 17, 42);

function generateTagCloud(tags, minFontSize, maxFontSize) {
    var countedTags = [],
        len = tags.length,
        currentTag = new String(),
        counter = 1,
        div = document.createElement('div'),
        fontSize;

    div.style.border = '1px solid black';
    div.style.width = '150px';
    div.style.padding = '10px';
    for (var i = 0; i < len; i += 1) {
        if (tags[i].toLowerCase() !== 'recorded') {
            currentTag = tags[i].toLowerCase();
            counter = 1;
            for (k = i + 1; k < len; k += 1) {
                if (tags[k].toLowerCase() === currentTag) {
                    counter += 1;
                    tags[k] = 'recorded';
                }
            }

            countedTags[currentTag] = counter;
        }
    }

    for (var tagName in countedTags) {
        fontSize = minFontSize + countedTags[tagName];
        if (fontSize > maxFontSize) {
            fontSize = maxFontSize;
        }

        var newSpan = document.createElement('span');
        newSpan.style.fontSize = fontSize + 'px';
        newSpan.innerText = ' ' + tagName;
        div.appendChild(newSpan);
    }

    document.body.appendChild(div);
}

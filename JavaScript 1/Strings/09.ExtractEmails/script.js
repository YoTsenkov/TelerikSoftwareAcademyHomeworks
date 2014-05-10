var text = 'ivan.petkanov@gmail.com twfdsf dfjg nas[d sami sdf spaidy@abv.bg dhfsvb gd fgui';

function extractEmails(text) {
    var buffText = text;
    var regex = /\S*@\S*\.\S*/;
    var emailArr = [];
    while (true) {
        var result = buffText.match(regex);
        if (result === null) {
            break;
        }

        emailArr.push(result[0]);
        buffText = buffText.replace(regex, '');
    }

    return emailArr;
}

var emails = extractEmails(text);
for (var index in emails) {
    console.log(emails[index]);
}
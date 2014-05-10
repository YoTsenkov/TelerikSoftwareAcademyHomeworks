function stringFormat(format, zero, one, two, three, four, five,
                            six, seven, eight, nine, ten, eleven,
                            twelve, thirteen, fourteen, fiftheen,
                            sixteen, seventeen, eighteen, nineteen,
                            twenty, twentyone, twentytwo, twentythree,
                            twentyfour, twentyfive, twentysix, twentyseven,
                      twentyeight, twentynine) {
    var text = format;
    text = text.replace(/\{0\}/g, zero);
    text = text.replace(/\{1\}/g, one);
    text = text.replace(/\{2\}/g, two);
    text = text.replace(/\{3\}/g, three);
    text = text.replace(/\{4\}/g, four);
    text = text.replace(/\{5\}/g, five);
    text = text.replace(/\{6\}/g, six);
    text = text.replace(/\{7\}/g, seven);
    text = text.replace(/\{8\}/g, eight);
    text = text.replace(/\{9\}/g, nine);
    text = text.replace(/\{10\}/g, ten);
    text = text.replace(/\{11\}/g, eleven);
    text = text.replace(/\{12\}/g, twelve);
    text = text.replace(/\{13\}/g, thirteen);
    text = text.replace(/\{14\}/g, fourteen);
    text = text.replace(/\{15\}/g, fiftheen);
    text = text.replace(/\{16\}/g, sixteen);
    text = text.replace(/\{17\}/g, seventeen);
    text = text.replace(/\{18\}/g, eighteen);
    text = text.replace(/\{19\}/g, nineteen);
    text = text.replace(/\{20\}/g, twenty);
    text = text.replace(/\{21\}/g, twentyone);
    text = text.replace(/\{22\}/g, twentytwo);
    text = text.replace(/\{23\}/g, twentythree);
    text = text.replace(/\{24\}/g, twentyfour);
    text = text.replace(/\{25\}/g, twentyfive);
    text = text.replace(/\{26\}/g, twentysix);
    text = text.replace(/\{27\}/g, twentyseven);
    text = text.replace(/\{28\}/g, twentyeight);
    text = text.replace(/\{29\}/g, twentynine);

    return text;
}

var format = '{0}, {1}, {0} text {2}';
console.log(stringFormat(format, 1, 'Pesho', 'Gosho'));

var format1 = '{0}, {1}, {2}, {3}, {4}, {5}!';
console.log(stringFormat(format1, 'This', 'function', 'is', 'working', 1337, 'time'));
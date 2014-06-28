var specialConsole = function () {

    function formatString(format, zero, one, two, three, four, five, six,
                          seven, eight, nine, ten, eleven, twelve, thirteen,
                          fourteen, fiftheen, sixteen, seventeen, eighteen,
                          nineteen, twenty, twentyone, twentytwo, twentythree,
                          twentyfour, twentyfive, twentysix, twentyseven, twentyeight,
                          twentynine) {
        var text = format.toString();
        if (arguments.length !== 1) {
            if (zero !== undefined) {
                text = text.replace(/\{0\}/g, zero.toString());
            }
            if (one !== undefined) {
                text = text.replace(/\{1\}/g, one.toString());
            }
            if (two !== undefined) {
                text = text.replace(/\{2\}/g, two.toString());
            }
            if (three !== undefined) {
                text = text.replace(/\{3\}/g, three.toString());
            }
            if (four !== undefined) {
                text = text.replace(/\{4\}/g, four.toString());
            }
            if (five !== undefined) {
                text = text.replace(/\{5\}/g, five.toString());
            }
            if (six !== undefined) {
                text = text.replace(/\{6\}/g, six.toString());
            }
            if (seven !== undefined) {
                text = text.replace(/\{7\}/g, seven.toString());
            }
            if (eight !== undefined) {
                text = text.replace(/\{8\}/g, eight.toString());
            }
            if (nine !== undefined) {
                text = text.replace(/\{9\}/g, nine.toString());
            }
            if (ten !== undefined) {
                text = text.replace(/\{10\}/g, ten.toString());
            }
            if (eleven !== undefined) {
                text = text.replace(/\{11\}/g, eleven.toString());
            }
            if (twelve !== undefined) {
                text = text.replace(/\{12\}/g, twelve.toString());
            }
            if (thirteen !== undefined) {
                text = text.replace(/\{13\}/g, thirteen.toString());
            }
            if (fourteen !== undefined) {
                text = text.replace(/\{14\}/g, fourteen.toString());
            }
            if (fiftheen !== undefined) {
                text = text.replace(/\{15\}/g, fiftheen.toString());
            }
            if (sixteen !== undefined) {
                text = text.replace(/\{16\}/g, sixteen.toString());
            }
            if (seventeen !== undefined) {
                text = text.replace(/\{17\}/g, seventeen.toString());
            }
            if (eighteen !== undefined) {
                text = text.replace(/\{18\}/g, eighteen.toString());
            }
            if (nineteen !== undefined) {
                text = text.replace(/\{19\}/g, nineteen.toString());
            }
            if (twenty !== undefined) {
                text = text.replace(/\{20\}/g, twenty.toString());
            }
            if (twentyone !== undefined) {
                text = text.replace(/\{21\}/g, twentyone.toString());
            }
            if (twentytwo !== undefined) {
                text = text.replace(/\{22\}/g, twentytwo.toString());
            }
            if (twentythree !== undefined) {
                text = text.replace(/\{23\}/g, twentythree.toString());
            }
            if (twentyfour !== undefined) {
                text = text.replace(/\{24\}/g, twentyfour.toString());
            }
            if (twentyfive !== undefined) {
                text = text.replace(/\{25\}/g, twentyfive.toString());
            }
            if (twentysix !== undefined) {
                text = text.replace(/\{26\}/g, twentysix.toString());
            }
            if (twentyseven !== undefined) {
                text = text.replace(/\{27\}/g, twentyseven.toString());
            }
            if (twentyeight !== undefined) {
                text = text.replace(/\{28\}/g, twentyeight.toString());
            }
            if (twentynine !== undefined) {
                text = text.replace(/\{29\}/g, twentynine.toString());
            }
        }

        return text;
    }

    function writeLine(format, zero, one, two, three, four, five, six,
                       seven, eight, nine, ten, eleven, twelve, thirteen,
                       fourteen, fiftheen, sixteen, seventeen, eighteen,
                       nineteen, twenty, twentyone, twentytwo, twentythree,
                       twentyfour, twentyfive, twentysix, twentyseven, twentyeight,
                       twentynine) {


        console.log(formatString(format, zero, one, two, three, four, five, six,
            seven, eight, nine, ten, eleven, twelve, thirteen,
            fourteen, fiftheen, sixteen, seventeen, eighteen,
            nineteen, twenty, twentyone, twentytwo, twentythree,
            twentyfour, twentyfive, twentysix, twentyseven, twentyeight,
            twentynine));
    }

    function writeError(format, zero, one, two, three, four, five, six,
                        seven, eight, nine, ten, eleven, twelve, thirteen,
                        fourteen, fiftheen, sixteen, seventeen, eighteen,
                        nineteen, twenty, twentyone, twentytwo, twentythree,
                        twentyfour, twentyfive, twentysix, twentyseven, twentyeight,
                        twentynine){
        "use strict";
       console.error(formatString(format, zero, one, two, three, four, five, six,
           seven, eight, nine, ten, eleven, twelve, thirteen,
           fourteen, fiftheen, sixteen, seventeen, eighteen,
           nineteen, twenty, twentyone, twentytwo, twentythree,
           twentyfour, twentyfive, twentysix, twentyseven, twentyeight,
           twentynine));
    }

    function writeWarning(format, zero, one, two, three, four, five, six,
                        seven, eight, nine, ten, eleven, twelve, thirteen,
                        fourteen, fiftheen, sixteen, seventeen, eighteen,
                        nineteen, twenty, twentyone, twentytwo, twentythree,
                        twentyfour, twentyfive, twentysix, twentyseven, twentyeight,
                        twentynine){
        "use strict";
       console.warn(formatString(format, zero, one, two, three, four, five, six,
           seven, eight, nine, ten, eleven, twelve, thirteen,
           fourteen, fiftheen, sixteen, seventeen, eighteen,
           nineteen, twenty, twentyone, twentytwo, twentythree,
           twentyfour, twentyfive, twentysix, twentyseven, twentyeight,
           twentynine));
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    }
}();

specialConsole.writeLine('LEL');
specialConsole.writeLine("Message: {0}", "hello");
specialConsole.writeError("Error: {0}", "Something happened");
specialConsole.writeWarning("Warning: {0}", "A warning");

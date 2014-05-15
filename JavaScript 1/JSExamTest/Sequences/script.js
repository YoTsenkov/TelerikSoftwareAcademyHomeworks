function Solve(args) {
    var numbers = [];
    for (var i = 1; i < args.length; i++) {
        numbers.push(parseInt(args[i]));
    }

    var sequences = 0;
    for (var i = 0; i < numbers.length - 1; i++) {
        var number = numbers[i];        
        for (var k = i + 1; k < numbers.length; k++) {
            if (numbers[k] >= number) {
                number = numbers[k];                
                if (k === numbers.length - 1) {
                    sequences++;
                }
            }
            else {
                sequences++;
                i = k - 1;

                break;
            }
        }
    }

    if (numbers[numbers.length - 1] < numbers[numbers.length - 2]) {
        sequences++;
    }
    return sequences;
}

//var arr = [9,
//1,
//8,
//8,
//7,
//6,
//5,
//7,
//7,
//6, ]

//var arr2 = [7, 1,
//2,
//-3,
//4,
//4,
//0,
//1,
//]
//console.log(Solve(arr));


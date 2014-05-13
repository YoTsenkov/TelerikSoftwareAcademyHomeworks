function Solve(args) {
    var splitSizeAndJumps = args[0].split(' ');
    var rows = parseInt(splitSizeAndJumps[0]);
    var cols = parseInt(splitSizeAndJumps[1]);
    var jumps = parseInt(splitSizeAndJumps[2]);

    var splitStartPosition = args[1].split(' ');
    var startRow = parseInt(splitStartPosition[0]);
    var startCol = parseInt(splitStartPosition[1]);

    var value = 1;
    var valuesArray = [];
    for (var i = 0; i < rows; i++) {
        var valuesRow = [];
        for (var k = 0; k < cols; k++) {
            valuesRow.push(value);
            value++;
        }
        valuesArray.push(valuesRow);
    }

    var numberOfJumps = 0;
    var sum = 0;
    while (true) {
        for (var i = 2; i < args.length; i++) {
            var splitMove = args[i].split(' ');
            var rowMove = parseInt(splitMove[0]);
            var colMove = parseInt(splitMove[1]);

            sum += valuesArray[startRow][startCol];
            numberOfJumps++;
            valuesArray[startRow][startCol] = -1;
            startRow += rowMove;
            startCol += colMove;

            if (startRow < 0 || startRow > rows - 1 || startCol < 0 || startCol > cols - 1) {
                var answer = 'escaped ' + sum;
                return answer;
            }

            if (valuesArray[startRow][startCol] === -1) {
                var answer = 'caught ' + numberOfJumps;
                return answer;
            }
        }
    }    
}

//var arr = ['6 7 3', '0 0', '2 2', '-2 2', '3 -1'];

//console.log(Solve(arr));



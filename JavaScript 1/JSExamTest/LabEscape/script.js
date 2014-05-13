function Solve(args) {
    var size = args[0].split(' ');
    var rows = parseInt(size[0]);
    var cols = parseInt(size[1]);
    var startingPoint = args[1].split(' ');
    var startingRow = parseInt(startingPoint[0]);
    var startingCol = parseInt(startingPoint[1]);
    var directionsArray = [];
    for (var i = 2; i < args.length; i++) {
        var directionsRow = args[i].split('');
        directionsArray.push(directionsRow);
    }

    var valuesArray = [];
    var value = 1;
    for (var i = 0; i < rows; i++) {
        var valuesRow = [];
        for (var k = 0; k < cols; k++) {
            valuesRow.push(value)
            value++;
        }
        valuesArray.push(valuesRow);
    }

    var sum = 0;
    var cells = 0;
    while (true) {        
        sum += valuesArray[startingRow][startingCol];
        cells++;
        valuesArray[startingRow][startingCol] = -1;
        var command = directionsArray[startingRow][startingCol];
        switch (command) {
            case 'l':                
                startingCol--;
                break;
            case 'r':                
                startingCol++;
                break;
            case 'u':
                startingRow--;
                break;
            case 'd':
                startingRow++;
                break;
            default:
                break;
        }

        if (startingRow < 0 || startingRow > rows - 1 || startingCol < 0 || startingCol > cols - 1) {
            var answer = 'out ' + sum;
            break;
        }

        if (valuesArray[startingRow][startingCol] === -1) {
            var answer = 'lost ' + cells;
            break;
        }
    }

    return answer;
}


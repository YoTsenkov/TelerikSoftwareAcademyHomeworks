function Solve(params) {
    var answer = 0;
    var inputArray = params;
    inputArray[inputArray.length - 1] = 'def answer ' + inputArray[inputArray.length - 1];
    var variablesArray = [];

    function getValues(arr, arr2) {
        var resultValues = arr;
        var variablesArray = arr2;
        var numbersCount = 0;


        for (var i in resultValues) {
            if (!isNaN(resultValues[i])) {
                numbersCount++;
            }
        }

        var length = resultValues.length;
        if (numbersCount === length) {
            return resultValues;
        }



        for (var z in resultValues) {
            if (isNaN(resultValues[z])) {
                var variableName = resultValues[z];
                if (variablesArray.hasOwnProperty(variableName)) {
                    if (variablesArray[variableName] instanceof Array) {
                        resultValues.splice(z, 1);
                        for (var o in variablesArray[variableName]) {
                            resultValues.push(variablesArray[variableName][o])
                        }
                    }
                    else {
                        resultValues.splice(z, 1);
                        resultValues.push(variablesArray[variableName]);
                    }
                }
            }
        }

        getValues(resultValues, variablesArray);
    }
    
    for (var i = 0; i < inputArray.length; i++) {
        var operation = null;
        var command = inputArray[i];
        var index = command.indexOf('[');
        var cut = command.slice(0, index).replace(/\W+/g, ' ').trim();
        var splitCut = cut.split(' ');
        var name = splitCut[1];
        if (splitCut.length === 3) {
            operation = splitCut[2];
        }

        var arrString = command.slice(index + 1, command.length - 1);
        var splitArrString = arrString.replace(/\s+/g, '').split(',');
        splitArrString = getValues(splitArrString, variablesArray);

        for (var z in splitArrString) {
            splitArrString[z] = parseInt(splitArrString[z]);
        }

        //calculate value
        if (operation === null) {
            if (splitArrString.length === 1) {
                variablesArray[name] = splitArrString[0];
            }
            else {
                variablesArray[name] = splitArrString;
            }
        }
        else {
            switch (operation) {
                case 'min':
                    var value = Math.min.apply(null, splitArrString);
                    variablesArray[name] = value;
                    break;
                case 'max':
                    var value = Math.max.apply(null, splitArrString);
                    variablesArray[name] = value;
                    break;
                case 'avg':
                    var sum = splitArrString.reduce(function (a, b) {
                        return a + b;
                    });
                    var value = Math.floor(sum / splitArrString.length);
                    variablesArray[name] = value;
                    break;
                case 'sum':
                    var value = splitArrString.reduce(function (a, b) {
                        return a + b;
                    });
                    variablesArray[name] = value;
                    break;
                default:
                    break;
            }
        }
    }


    return variablesArray['answer'];
}




var testArr = [
 'def maxy max[100]',
'def summary [0]',
'combo [maxy, maxy,maxy,maxy, 5,6]',
'summary sum[combo, maxy, -18000]',
'def pe6o avg[summary,maxy]',
    'sum[7, pe6o]',


];

console.log(Solve(testArr));

//var testArr = [
//    'def func sum[5, 3, 7, 2, 6, 3]',
//    'def func2 [5, 3, 7, 2, 6, 3]',
//    'def func3 min[func2]',
//    'def func4 max[5, 3, 7, 2, 6, 3]',
//    'def func5 avg[5, 3, 7, 2, 6, 3]',
//    'def func6 sum[func2, func3, func4 ]',
//    'sum[func6, func4]'
//];

//console.log(Solve(testArr));
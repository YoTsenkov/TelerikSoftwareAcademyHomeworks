function Solve(params) {
    var input = params,
        functionsStorage = [],
        command,
        index,
        firstHalf,
        secondHalf,
        functionName,
        operator,
        functionArray = [],
        openingBracketsCount = 0,
        functionValue = 0,
        answer,
        splitCommand;

    input[input.length - 1] = '(def answer ' + input[input.length - 1] + ')';
    function removeEmptyStrings(array) {
        var index = array.indexOf('');
        while ((index !== -1)) {
            array.splice(index, 1);
            index = array.indexOf('');
        }
        return array;
    }

    function replaceWithValues(arr, arr2) {
        var funcArray = arr,
            funcStorage = arr2,
            numbersCount = 0,
            elementsCount = funcArray.length,
            funcName;

        for (var i in funcArray) {
            if (!isNaN(funcArray[i])) {
                numbersCount++;
            }
        }

        if (numbersCount === elementsCount) {
            for (var element in funcArray) {
                funcArray[element] = parseInt(funcArray[element]);
            }
            return funcArray;
        }

        for (var j in funcArray) {
            if (isNaN(funcArray[j])) {
                funcName = funcArray[j];
                if (funcStorage.hasOwnProperty(funcName)) {
                    if (funcStorage[funcName] instanceof Array) {
                        funcArray.splice(j, 1);
                        for (var o in funcStorage[funcName]) {
                            funcArray.splice(j, 0, funcStorage[funcName][o]);
                        }
                    }
                    else {
                        funcArray.splice(j, 1, funcStorage[funcName]);
                    }
                }
            }
        }

        return replaceWithValues(funcArray, funcStorage);
    }

    for (var i = 0; i < input.length; i++) {
        command = input[i];
        functionValue = 0;
        openingBracketsCount = 0;
        functionArray = [];
        for (var j in command) {
            if (command[j] === '(') {
                openingBracketsCount++;
            }
        }

        if (openingBracketsCount === 1) {
            splitCommand = removeEmptyStrings(command.slice(1, command.length - 1).split(' '));
            functionName = splitCommand[1];
            functionValue = replaceWithValues([splitCommand[2]], functionsStorage)[0];
            functionsStorage[functionName] = functionValue;
        }
        else {
            index = command.lastIndexOf('(');
            index2 = command.indexOf(')');
            firstHalf = removeEmptyStrings(command.slice(1, index).split(' '));
            functionName = firstHalf[1];
            secondHalf = removeEmptyStrings(command.slice(index + 1, index2).split(' '));
            operator = secondHalf[0];
            for (var k = 1; k < secondHalf.length; k++) {
                functionArray.push(secondHalf[k]);
            }

            functionArray = replaceWithValues(functionArray, functionsStorage);

            switch (operator) {
                case '+':
                    for (var number in functionArray) {
                        functionValue += functionArray[number];
                    }

                    functionsStorage[functionName] = functionValue
                    break;
                case '-':
                    functionValue = functionArray[0];
                    for (var k = 1; k < functionArray.length; k++) {
                        functionValue -= functionArray[k];
                    }

                    functionsStorage[functionName] = functionValue
                    break;
                case '*':
                    functionValue = 1;
                    for (var number in functionArray) {
                        functionValue *= functionArray[number];
                    }

                    functionsStorage[functionName] = functionValue
                    break;
                case '/':
                    functionValue = functionArray[0];
                    for (var k = 1; k < functionArray.length; k++) {
                        if (functionArray[k] === 0) {
                            answer = 'Division by zero! At Line:' + (i + 1);
                            return answer;
                        }
                        functionValue /= functionArray[k];
                    }

                    functionsStorage[functionName] = Math.floor(functionValue);
                    break;
                default:
                    break;
            }
        }
    }

    return functionsStorage['answer'];  
}


var wtf = [
    '(def func 10)',
'(def newFunc (+  func 2))',
'(def sumFunc (+ func func newFunc 0 0 0))',
  '  (* sumFunc 2)'

]

Solve(wtf);
console.log();
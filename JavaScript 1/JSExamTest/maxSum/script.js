function Solve(numbers) {
    var answer = 0;
    var array = [];
    var maxSum = -2000000;
    for (var i = 1; i < numbers.length; i++) {
        array.push(parseInt(numbers[i]));
    }

    for (var i = 0; i < array.length - 1; i++) {
        var currentSum = array[i];
        if (currentSum > maxSum) {
            maxSum = currentSum;
        }

        for (var k = i + 1; k < array.length; k++) {
            currentSum += array[k]
            if (currentSum > maxSum) {
                maxSum = currentSum;
            }
        }
    }

    answer = maxSum;
    return answer;
}

//var arr = [9,
//-9,
//-8,
//-8,
//-7,
//-6,
//-5,
//-1,
//-7,
//-6,
//];

//console.log(Solve(arr));

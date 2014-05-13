var command = 'def     varName   sum   [    2,3,12 ,            4,   1         ]';
//get the name, operation
var index = command.indexOf('[');
var cut = command.slice(0, index).replace(/\W+/g, ' ').trim();
var splitCut = cut.split(' ');
var name = splitCut[1];
var operation = splitCut[2];

//get the array with numbers
var arrString = command.slice(index);
var numbers = arrString.match(/\d+/g);
for (var index in numbers) {
    numbers[index] = parseInt(numbers[index]);
}

console.log(typeof numbers[2]);



var commandsArray = [];
commandsArray[name] = numbers;

console.log()

function myfunction() {
    console.log(arguments.length);
}

myfunction('sad', 'wtf', 'ugjh');
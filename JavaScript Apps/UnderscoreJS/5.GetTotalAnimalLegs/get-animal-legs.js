(function () {
    "use strict";
    var animals = [
            {species: 'rhino', legs: 4},
            {species: 'dog', legs: 8},
            {species: 'kangaroo', legs: 2},
            {species: 'rhino', legs: 100},
            {species: 'cat', legs: 6},
            {species: 'dog', legs: 4},
        ],
        totalNumbrOfLegs = 0;

    _.each(animals, function (animal) {
        totalNumbrOfLegs += animal.legs;
    });


    console.log(totalNumbrOfLegs);
}());
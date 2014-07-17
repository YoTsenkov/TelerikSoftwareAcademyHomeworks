(function () {
    "use strict";
    var animals = [
        {species: 'rhino', legs: 4},
        {species: 'dog', legs: 3},
        {species: 'kangaroo', legs: 2},
        {species: 'rhino', legs: 4},
        {species: 'cat', legs: 5},
        {species: 'dog', legs: 4},
    ];

    var groupedAndSortedAnimals = _.chain(animals)
        .groupBy(function (animal) {
            return animal.species;
        })
        .sortBy('legs')
        .value();

    console.log(groupedAndSortedAnimals);
}());
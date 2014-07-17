(function () {
    'use strict';

    var people = [
            {firstName: 'Hristo', lastName: 'Manolov'},
            {firstName: 'Ivan', lastName: 'Stamatov'},
            {firstName: 'Zlatomir', lastName: 'Manolov'},
            {firstName: 'Hristo', lastName: 'Vatev'},
            {firstName: 'Hristo', lastName: 'Waaaat'},
            {firstName: 'Jiggy', lastName: 'Wizzy'},
            {firstName: 'Jiggy', lastName: 'Stoimenov'},
            {firstName: 'Krasimir', lastName: 'Manolov'},
        ],
        mostPopularFirstName,
        mostPopularLastName,
        getMostPopular;

    getMostPopular = function getMostPopular(array, attr) {
        return  _.chain(array)
            .groupBy(attr)
            .sortBy(attr)
            .value()[0][0][attr];
    };

    mostPopularFirstName = getMostPopular(people, 'firstName');

    mostPopularLastName = getMostPopular(people, 'lastName');

    console.log('most popular first name -> ' + mostPopularFirstName);
    console.log('most popular last name -> ' + mostPopularLastName);
}());

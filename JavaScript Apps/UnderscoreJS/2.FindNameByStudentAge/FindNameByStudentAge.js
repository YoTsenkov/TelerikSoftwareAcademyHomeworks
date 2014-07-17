(function () {
    'use strict';
    var students = [
        {firstName: "Ivan", lastName: 'Todorov', age: 21},
        {firstName: "Todor", lastName: 'Ivanov', age: 26},
        {firstName: "Petra", lastName: 'Georgieva', age: 14},
        {firstName: "Georgi", lastName: 'Petrov', age: 11},
        {firstName: "Stamina", lastName: 'Staminova', age: 19},
        {firstName: "Ivan", lastName: 'Jodorov', age: 20}
    ];

    _.chain(students)
        .filter(function (student) {
            return student.age >= 18 && student.age <= 24;
        })
        .each(function (student) {
            console.log('firstName: ' + student.firstName +
                ' lastName: ' + student.lastName)
        });
}());
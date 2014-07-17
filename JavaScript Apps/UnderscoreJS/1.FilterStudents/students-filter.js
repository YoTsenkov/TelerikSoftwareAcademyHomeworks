(function () {
    "use strict";
    var students = [
        {firstName: "Ivan", lastName: 'Todorov', age: 21},
        {firstName: "Todor", lastName: 'Ivanov', age: 11},
        {firstName: "Petra", lastName: 'Georgieva', age: 14},
        {firstName: "Georgi", lastName: 'Petrov', age: 11},
        {firstName: "Stamina", lastName: 'Staminova', age: 19},
        {firstName: "Ivan", lastName: 'Jodorov', age: 19}
    ];

    _.chain(students)
        .filter(function (student) {
            if (student.lastName > student.firstName) {
                return student;
            }
        })
        .sortBy(function (student) {
            var fullName = student.firstName + ' ' + student.lastName;
            return fullName;
        })
        .reverse()
        .each(function (student) {
            "use strict";
            console.log(student.firstName + ' ' + student.lastName)
        });

}());
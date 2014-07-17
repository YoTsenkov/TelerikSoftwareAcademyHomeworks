(function () {
    "use strict";
    var students = [
        {firstName: "Ivan", lastName: 'Todorov', mark: 21},
        {firstName: "Todor", lastName: 'Ivanov', mark: 11},
        {firstName: "Petra", lastName: 'Georgieva', mark: 14},
        {firstName: "Georgi", lastName: 'Petrov', mark: 11},
        {firstName: "Stamina", lastName: 'Staminova', mark: 19},
        {firstName: "Ivan", lastName: 'Jodorov', age: 19}
    ];

   var studentWithHighestMark =  _.chain(students)
        .max(function (student) {
            return student.mark;
        })
        .value();

    console.log(studentWithHighestMark);
}());

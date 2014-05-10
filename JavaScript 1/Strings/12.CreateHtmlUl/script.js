var people = [
    { name: 'Peter', age: 14 },
    { name: 'Ivan', age: 15 },
    { name: 'Kosio', age: 16 },
    { name: 'Hasinta', age: 23 },
    { name: 'Miro', age: 45 },
    { name: 'Zlatomir', age: 28 },
];
var tmpl = document.getElementById('list-item').innerHTML;

function generateList(people, template) {
    var peopleList = '<ul>';
    for (var index in people) {
        peopleList += '<li>' + template.replace(/\-\{name\}\-/, people[index].name).replace(/\-\{age\}\-/, people[index].age) + '</li>';
    }
    peopleList += '</ul>';

    return peopleList;
}

console.log(generateList(people, tmpl));
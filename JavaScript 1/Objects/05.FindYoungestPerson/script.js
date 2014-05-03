var persons = [
  { firstname: "Much", lastname: "Script", age: 32 },
  { firstname: "Wow", lastname: "Wow", age: 81 },
  { firstname: "Such", lastname: "Code", age: 25 },
  { firstname: "Dat", lastname: "Javascript", age: 3 }
];

function getYoungest(array) {
    var youngest = array[0];
    for (var index in array) {
        if (array[index].age < youngest.age) {
            youngest = array[index];
        }
    }

    return youngest;
}

var youngest = getYoungest(persons);
var fullName = youngest.firstname + ' ' + youngest.lastname;
console.log(fullName);
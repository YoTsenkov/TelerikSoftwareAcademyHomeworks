function hasProperty(obj, propertyName) {
    var hasProperty = false;
    for (var prop in obj) {
        if (obj.hasOwnProperty(propertyName)) {
            hasProperty = true;
            break;
        }
    }

    return hasProperty;
}

var object = {
    name: 'wtf',
    length: 'rly?',
    numberOfLegs: 5
}

console.log(hasProperty(object, 'numberOfLegs'));

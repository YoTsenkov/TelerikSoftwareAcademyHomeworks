Array.prototype.remove = function (value) {
    for (var index in this) {
        if (this[index] === value) {
            this.splice(index, 1);
        }
    }
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, "1"];
arr.remove(1); //arr = [2,4,3,4,111,3,2,"1"];

for (var index in arr) {
    console.log(arr[index]);
}


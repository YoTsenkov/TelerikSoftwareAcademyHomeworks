var arr = [1,5,-5,8,4,3,10];

arr.sort(function(a, b){
    return b - a;
});

var newArr = arr.map(function(el){
    return el + 100;
});


newArr.forEach(function(element){
    console.log(element);
});


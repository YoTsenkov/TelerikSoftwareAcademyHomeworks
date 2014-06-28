var div = document.createElement("div"),
    header = document.createElement('h1'),
    ul = document.createElement('ul'),
    listContainer = document.createElement('div'),
    addBtn = document.createElement('input'),
    showBtn = document.createElement('input'),
    discription = document.createElement('input'),
    date = document.createElement('input'),
    time = document.createElement('input'),
    isVisible = true;

discription.type = 'text';
discription.setAttribute("placeholder", 'Enter discription');
discription.id = 'discription';
date.type = 'text';
date.setAttribute("placeholder", 'Enter date dd/mm/yyyy');
date.id = 'date';
time.type = 'text';
time.setAttribute("placeholder", 'Enter time hh:mm');
time.id = 'time';
addBtn.type = 'button';
addBtn.value = 'Add TODO';
addBtn.id = 'add-btn';
showBtn.type = 'button';
showBtn.value = 'Hide TODO List';
showBtn.id = 'show-btn';
header.innerText = 'TODO List';
header.style.fontSize = '18px';
ul.id = 'list';
listContainer.id = 'list-container';

//Appending the elements to the DOM
listContainer.appendChild(header);
listContainer.appendChild(ul);
div.appendChild(showBtn);
div.appendChild(discription);
div.appendChild(date);
div.appendChild(time);
div.appendChild(addBtn);
div.appendChild(listContainer);
document.body.appendChild(div);

//Event handler for show/hide list
document.getElementById('show-btn').addEventListener('click', function () {
    if (isVisible) {
        document.getElementById('list-container').style.display = 'none';
        document.getElementById('show-btn').value = 'Show TODO List';
        isVisible = false;
    }
    else {
        document.getElementById('list-container').style.display = 'block';
        document.getElementById('show-btn').value = 'Hide TODO List';
        isVisible = true;
    }
});

//Event handler for Add new item
document.getElementById('add-btn').addEventListener('click', function () {
    var newLi = document.createElement('li'),
        removeBtn = document.createElement('input');
    newLi.innerText = document.getElementById('date').value + ' ' + document.getElementById('discription').value + ' ' + document.getElementById('time').value;
    removeBtn.type = 'button';
    removeBtn.value = 'Remove';
    removeBtn.addEventListener('click', function () {
        removeBtn.parentNode.parentNode.removeChild(newLi);
    });
    newLi.appendChild(removeBtn);
    document.getElementById('list').appendChild(newLi);
});






var options = [{
    value: 1,
    text: 'One'
}, {
    value: 2,
    text: 'Two'
}, {
    value: 3,
    text: 'Three'
}, {
    value: 4,
    text: 'Four'
}, {
    value: 5,
    text: 'Five'
}];
var selectTemplateHtml = document.getElementById('select-template').innerHTML;
var selectTemplate = Handlebars.compile(selectTemplateHtml);
document.body.innerHTML += selectTemplate({
    options: options
});





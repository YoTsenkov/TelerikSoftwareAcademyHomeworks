var courses = [{
    id: 0,
    name: 'Course Introduction',
    firstDate: 'Wed 18:00, 28-May-2014',
    secondDate: 'Thu 14:00 29-May-2014'
}, {
    id: 1,
    name: 'Document Object Model',
    firstDate: 'Wed 18:00, 28-May-2014',
    secondDate: 'Thu 14:00 29-May-2014'
}, {
    id: 2,
    name: 'HTML5 Canvas',
    firstDate: 'Wed 18:00, 29-May-2014',
    secondDate: 'Thu 14:00 30-May-2014'
}, {
    id: 3,
    name: 'Kinetic JS Overview',
    firstDate: 'Wed 18:00, 29-May-2014',
    secondDate: 'Thu 14:00 30-May-2014'
}, {
    id: 4,
    name: 'SVG and RaphaelJS',
    firstDate: 'Wed 18:00, 04-Jun-2014',
    secondDate: 'Thu 14:00 05-May-2014'
}, {
    id: 5,
    name: 'Animations with Canvas and SVG',
    firstDate: 'Wed 18:00, 04-Jun-2014',
    secondDate: 'Thu 14:00 05-Jun-2014'
}, {
    id: 6,
    name: 'DOM Operations',
    firstDate: 'Wed 18:00, 05-Jun-2014',
    secondDate: 'Thu 14:00 06-Jun-2014'
}, {
    id: 7,
    name: 'Event Model',
    firstDate: 'Wed 18:00, 11-Jun-2014',
    secondDate: 'Thu 14:00 11-Jun-2014'
}];

coursesTemplateHtml = document.getElementById('course-template').innerHTML;
coursesTemplate = Handlebars.compile(coursesTemplateHtml);
document.body.innerHTML += coursesTemplate({
    courses: courses
});
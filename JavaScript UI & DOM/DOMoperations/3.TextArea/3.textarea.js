window.onload = function () {
    var elementsContainer = new DocumentFragment(),
        textarea = document.createElement('textarea'),
        fontColorPicker = document.createElement('input'),
        backgroundColorPicker = document.createElement('input');

    textarea.style.width = '200px';
    textarea.style.height = '100px';
    textarea.style.border = '1px solid black';
    fontColorPicker.type = 'color';
    fontColorPicker.id = 'font-color-picker';
    backgroundColorPicker.type = 'color';
    backgroundColorPicker.id = 'bg-color-picker';

    elementsContainer.appendChild(textarea);
    elementsContainer.appendChild(fontColorPicker);
    elementsContainer.appendChild(backgroundColorPicker);
    document.body.appendChild(elementsContainer);

    var text = document.getElementsByTagName('textarea')[0],
        fontPicker = document.getElementById('font-color-picker'),
        bgPicker = document.getElementById('bg-color-picker');

    fontPicker.addEventListener('change', function () {
        text.style.color = fontPicker.value;
    });
    bgPicker.addEventListener('change', function () {
        text.style.backgroundColor = bgPicker.value;
    });
};
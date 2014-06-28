var domModule = function () {
    var appendChild,
        removeChild,
        addHandler,
        appendToBuffer;

    appendChild = function (childTag, parentSelector) {
        var child = document.createElement(childTag);
        child.innerText = 'LEL';
        document.querySelector(parentSelector).appendChild(child);
    };

    removeChild = function (parentSelector, childSelector) {
        var parent = document.querySelector(parentSelector),
            childrenToBeRemoved = parent.querySelectorAll(childSelector);
        for (var i = 0, len = childrenToBeRemoved.length; i < len; i += 1) {
            parent.removeChild(childrenToBeRemoved[i]);
        }
    };

    addHandler = function (elementSelector, eventType, eventHandler) {
        var elementsToGetAttachment = document.querySelectorAll(elementSelector);
        for (var i = 0, len = elementsToGetAttachment.length; i < len; i += 1) {
            elementsToGetAttachment[i].addEventListener(eventType, eventHandler);
        }
    };

    return{
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler
    }
}();

domModule.appendChild('div', '#wrapper');
domModule.removeChild('div', 'div');
domModule.addHandler("a.button", 'click',
    function () {
        alert("Clicked")
    });


var domModule = (function () {

    function appendElemetnToParent(elementToAppend,parentSelector) {
        var parent = document.querySelector(parentSelector);

        if (!parent) {
            throw new Error("Can not append element to non existing parent.");
        }

        parent.appendChild(elementToAppend);
    }

    function removeDOMElement(selector) {
        var element = document.querySelector(selector);
        var parent = element.parentNode;

        parent.removeChild(element);
    }

    function attachEvent(selector, eventType, eventHandler) {
        var element = document.querySelectorAll(selector);

        for (var i = 0; i < element.length; i++) {
            element[i].addEventListener(eventType, eventHandler, true);
        }
    }

    var buffer = {};
    var MAX_BUFFER_SIZE = 100;

    //function appendToBuffer(parentSelector, element) {
    //    var parent = document.querySelector(parentSelector);

    //    if (!buffer[parent]) {
    //        buffer[parent] = [];
    //    }

    //    buffer[parent].push(element);

    //    if (buffer[parent].length >= MAX_BUFFER_SIZE) {
    //        var fragment = document.createDocumentFragment();

    //        for (var i = 0; i < buffer[parent].length; i++) {
    //            fragment.appendChild(buffer[parent][i]);
    //        }

    //        parent.appendChild(fragment);
    //        buffer[parent] = [];
    //    }
    //}

    function appendToBuffer(parentSelector, element) {
        var parent = document.querySelector(parentSelector);

        if (!buffer[parent]) {
            buffer[parent] = [];
        }

        buffer[parent].push(element);

        if (buffer[parent].length == MAX_BUFFER_SIZE) {
            var fragment = document.createDocumentFragment();

            for (var i = 0; i < buffer[parent].length; i++) {
                var child = buffer[parent][i];

                fragment.appendChild(child);
            }

            parent.appendChild(fragment);
            buffer[parent] = [];
        }
    }

    function getElementByCSSSelector(selector) {
        return document.querySelector(selector);
    }

    return {
        appendElemetnToParent: appendElemetnToParent,
        removeDOMElement: removeDOMElement,
        attachEvent: attachEvent,
        appendToBuffer: appendToBuffer
    }
}());
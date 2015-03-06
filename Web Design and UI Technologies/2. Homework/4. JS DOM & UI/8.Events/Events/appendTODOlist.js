(function () {

    var getDivHolder = document.getElementById('listHolder'),
        docFragment = document.createDocumentFragment(),
        input = document.createElement('input'),
        ulList = document.createElement('ul'),
        addButton = document.createElement('button'),
        showButton = document.createElement('button'),
        hideButton = document.createElement('button');
    
    addButton.innerHTML = 'ADD';
    showButton.innerHTML = 'SHOW';
    hideButton.innerHTML = 'HIDE';

    addButton.addEventListener('click', onButtonClick, false);   

    function onButtonClick() {
        if (input.value === "") {
            return;
        }

        var currentLi = document.createElement('li'),
            currentButton = addButton = document.createElement('button');

        currentButton.innerHTML = 'DELETE';
        currentButton.addEventListener('click', function () {
            ulList.removeChild(this.parentElement);
        })

        currentLi.innerHTML = input.value;
        currentLi.appendChild(currentButton);
        input.value = "";

        ulList.appendChild(currentLi);
    }

    showButton.addEventListener('click', function () {
        ulList.style.display = 'block';
    }, false);

    hideButton.addEventListener('click', function () {
        ulList.style.display = 'none';
    }, false);

    docFragment.appendChild(input);
    docFragment.appendChild(addButton);
    docFragment.appendChild(showButton);
    docFragment.appendChild(hideButton);
    docFragment.appendChild(ulList);

    getDivHolder.appendChild(docFragment);
}());
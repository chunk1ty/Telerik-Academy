(function () {

    var numbersOfDiv = document.getElementById('text-input'),
        btnGenerator = document.getElementById('btn-generate');

    btnGenerator.addEventListener('click', createDiv);

    function createDiv() {
        var dFrag = document.createDocumentFragment(),
            count = numbersOfDiv.value || 5;

        for (var i = 0; i < count; i++) {
            var currentDiv = document.createElement('div');

            currentDiv.style.width = generateRandomNumber(20, 100) + 'px';
            currentDiv.style.height = generateRandomNumber(20, 100) + 'px';

            currentDiv.style.backgroundColor = generateRandomColor();
            currentDiv.style.color = generateRandomColor();

            currentDiv.style.position = 'absolute';
            currentDiv.style.top = generateRandomNumber(0, screen.height / 2) + 'px';
            currentDiv.style.left = generateRandomNumber(0, screen.width / 2) + 'px';

            currentDiv.innerHTML = genereteStrongElement();

            currentDiv.style.borderStyle = 'solid';
            currentDiv.style.borderRadius = generateRandomNumber(1, 25) + 'px';
            currentDiv.style.borderColor = generateRandomColor();
            currentDiv.style.borderWidth = generateRandomNumber(1, 20) + 'px';

            dFrag.appendChild(currentDiv);
        }

        document.body.appendChild(dFrag);
    }

    function generateRandomNumber(min, max) {
        // | 0 is for round
        return (Math.random() * (max - min) + min) | 0;
    }

    function generateRandomColor() {
        var red = generateRandomNumber(0, 255),
            green = generateRandomNumber(0, 255),
            blue = generateRandomNumber(0, 255);

        return 'rgb(' + red + ',' + green + ',' + blue + ')';      
    }

    function genereteStrongElement() {        
        return '<strong> div </strong>';
    }
}());
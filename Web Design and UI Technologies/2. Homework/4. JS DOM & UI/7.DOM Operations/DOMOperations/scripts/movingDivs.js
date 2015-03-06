(function () {

    function getRandomInt(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }
    function getRandomColor() {
        return "rgb(" +
                getRandomInt(0, 255) + "," +
                getRandomInt(0, 255) + "," +
                getRandomInt(0, 255) + ")";
    }

    function generateDiv() {
        var div = document.createElement('div');

        div.style.position = 'absolute';
        div.style.width = '50px';
        div.style.height = '50px';
        div.style.border = '3px solid ' + getRandomColor();
        div.style.borderRadius = '25px';
        div.style.backgroundColor = getRandomColor();

        document.body.appendChild(div);
    }

    function rotateDivs() {
        for (i = 0; i < 5; i++) {
            allDivs[i].style.left = Math.cos(angle + 2 * Math.PI / allDivs.length * i) / radius * 3000 + centerX + 'px';
            allDivs[i].style.top = Math.sin(angle + 2 * Math.PI / allDivs.length * i) / radius * 3000 + centerY + 'px';
        }
        angle = angle + 0.15;
        setTimeout(rotateDivs, 100);
    }

    var i = 0;

    for (i = 0; i < 5; i++) {
        generateDiv();
    }

    var allDivs = document.querySelectorAll('div');
    var angle = 0;
    var radius = 50;
    var centerX = 300;
    var centerY = 300;
    rotateDivs();
}());
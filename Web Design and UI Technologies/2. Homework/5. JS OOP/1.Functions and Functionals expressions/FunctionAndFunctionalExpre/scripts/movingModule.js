var movingShapes = (function () {
    var DIV_WIDTH = 50 + 'px',
        DIV_HEIGHT = 50 + 'px',
        DIV_BORDER_RADIUS = 10 + 'px',
        DIV_MOVE_SPEED = 12,
        RECT_WIDTH = 300,
        RECT_HEIGHT = 300,
        DIV_MOVE_SPEED = 12,
        ELLIPSE_CENTER_X = 150,
        ELLIPSE_CENTER_Y = 150,
        ELLIPSE_RADIUS = 150;

    function add(shape, top, left) {
        var div = generateDiv();

        document.body.appendChild(div);

        if (shape == 'ellipse') {
            moveDivEllipse(div);
        }
        else if (shape == 'rect') {
            moveDivRectangular(div);
        }
    }

    function moveDivRectangular(div) {
        var top = parseInt(div.style.top.substring(0, div.style.top.length - 2));
        var left = parseInt(div.style.left.substring(0, div.style.left.length - 2));

        var startTop = top;
        var startLeft = left;

        var leftSpeed = DIV_MOVE_SPEED;
        var topSpeed = 0;

        function moveOnRect() {

            if (left + DIV_WIDTH + 2 >= RECT_WIDTH) {
                leftSpeed = 0;
                topSpeed = DIV_MOVE_SPEED;

                left = RECT_WIDTH - DIV_WIDTH;
            }
            if (top + DIV_HEIGHT + 2 >= RECT_HEIGHT) {
                leftSpeed = -DIV_MOVE_SPEED;
                topSpeed = 0;

                top = RECT_HEIGHT - DIV_HEIGHT;
            }
            if (left < startLeft) {
                leftSpeed = 0;
                topSpeed = -DIV_MOVE_SPEED;

                left = startLeft;
            }
            if (top < startTop) {
                leftSpeed = DIV_MOVE_SPEED;
                topSpeed = 0;

                top = startTop;
            }

            div.style.top = top + 'px';
            div.style.left = left + 'px';

            left += leftSpeed;
            top += topSpeed;
        }

        setInterval(moveOnRect, 100);
    }

    function moveDivEllipse(div) {
        var movementAngle = 0;

        function moveOnEllipse() {
            movementAngle += 3;
            if (movementAngle == 360) {
                movementAngle = 0;
            }

            var left = ELLIPSE_CENTER_X + Math.cos((2 * Math.PI / 180) * (movementAngle)) * ELLIPSE_RADIUS;
            var right = 2 * (ELLIPSE_CENTER_Y + Math.sin((2 * Math.PI / 180) * (movementAngle)) * ELLIPSE_RADIUS);
            div.style.left = left + "px";
            div.style.top = right + "px";
        }

        setInterval(moveOnEllipse, 100);
    }

    function generateDiv(top, left) {
        var div = document.createElement('div');
        div.style.width = DIV_WIDTH;
        div.style.height = DIV_HEIGHT;        

        div.style.backgroundColor = getRandomColor();
        div.style.color = getRandomColor();
        div.style.borderColor = getRandomColor();

        div.style.positon = 'absolute';
        div.innerHTML = 'ANK';
        div.style.top = top + 'px';
        div.style.left = left + 'px';

        return div;
    }

    function getRandomColor() {
        var letters = '0123456789ABCDEF'.split('');
        var color = '#';
        for (var i = 0; i < 6; i++) {
            color += letters[Math.floor(Math.random() * 16)];
        }
        return color;
    }

    return {
        add: add
    }
}());

var Drawer = (function () {
    var RECT_WIDHT = 100,
        RECT_HEIGHT = 200,
        BORDER_COLOR = 'red',
        FILL_COLOR = 'blue';

    function Drawer(canvasID) {
        //John resig Constructor fix - if constructor not used with new
        if (!(this instanceof arguments.callee)) {
            return new Drawer(canvasID);
        }

        this._ctx = document.getElementById(canvasID).getContext('2d');
    }

    Drawer.prototype.rect = function rect(x, y) {
        this._ctx.beginPath();

        this._ctx.strokeStyle = BORDER_COLOR;
        this._ctx.fillStyle = FILL_COLOR;

        this._ctx.rect(x, y, RECT_WIDHT, RECT_HEIGHT);

        this._ctx.fill();
        this._ctx.stroke();
    }

    Drawer.prototype.circle = function cirlce(x, y, r) {
        this._ctx.beginPath();

        this._ctx.strokeStyle = BORDER_COLOR;
        this._ctx.fillStyle = FILL_COLOR;

        this._ctx.arc(x, y, r, 0, 2 * Math.PI, true);

        this._ctx.fill();
        this._ctx.stroke();
    }

    Drawer.prototype.line = function line(x1, y1, x2, y2) {
        this._ctx.beginPath();

        this._ctx.strokeStyle = BORDER_COLOR;

        this._ctx.moveTo(x1, y1);
        this._ctx.lineTo(x2, y2);
       
        this._ctx.stroke();
    }

    return Drawer;
}());
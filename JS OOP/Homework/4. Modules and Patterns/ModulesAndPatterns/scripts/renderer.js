var GameRenderer = function () {
    function drawCell(x, y, fillColor, stroke, gameSettingsData, ctx) {
        ctx.fillStyle = fillColor;
        ctx.fillRect(x * gameSettingsData.CELL_SIZE, y * gameSettingsData.CELL_SIZE, gameSettingsData.CELL_SIZE, gameSettingsData.CELL_SIZE);

        //add the stroke if it is defined
        if (typeof stroke !== "undefined") {
            ctx.strokeStyle = stroke;
            ctx.strokeRect(x * gameSettingsData.CELL_SIZE, y * gameSettingsData.CELL_SIZE, gameSettingsData.CELL_SIZE, gameSettingsData.CELL_SIZE);
        }
    }

    function drawSnake(snake, gameSettingsData, ctx) {
        for (var i = 0; i < snake.length; i++) {
            var s = snake[i];

            if (i == 0) {
                drawCell(s.x, s.y, 'red', '#333', gameSettingsData, ctx);
            }
            else {
                drawCell(s.x, s.y, '#999', '#333', gameSettingsData, ctx);
            }
        }
    }

    function drawFood(food, gameSettingsData, ctx) {
        drawCell(food.x, food.y, 'green', '#333', gameSettingsData, ctx);
    }

    return {
        drawSnake: drawSnake,
        drawFood: drawFood
    }

};
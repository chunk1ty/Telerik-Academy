function GameEngine() {
    var gameSettingsData,
        renderer,
        canvas,
        ctx;

    var collisionDetector,
        snake,
        food,
        score,
        gameEnded,
        direction;

    document.onkeydown = function (event) {
        var keyCode = event.keyCode;

        switch (keyCode) {
            // left
            case gameSettingsData.LEFT_ARROW_KEY_NUMBER:
                if (direction != gameSettingsData.RIGHT_DIRECTION) {
                    direction = gameSettingsData.LEFT_DIRECTION;
                }
                break;
                // up
            case gameSettingsData.UP_ARROW_KEY_NUMBER:
                if (direction != gameSettingsData.DOWN_DIRECTION) {
                    direction = gameSettingsData.UP_DIRECTION;
                }
                break;
                // right
            case gameSettingsData.RIGHT_ARROW_KEY_NUMBER:
                if (direction != gameSettingsData.LEFT_DIRECTION) {
                    direction = gameSettingsData.RIGHT_DIRECTION;
                }
                break;
                // down
            case gameSettingsData.DOWN_ARROW_KEY_NUMBER:
                if (direction != gameSettingsData.UP_DIRECTION) {
                    direction = gameSettingsData.DOWN_DIRECTION;
                }
                break;
            default:
                break;
        }
    };

    function createFood() {
        var foodX = Math.floor(Math.random() * ((gameSettingsData.FIELD_WIDTH / gameSettingsData.CELL_SIZE) - 1));
        var foodY = Math.floor(Math.random() * ((gameSettingsData.FIELD_HEIGHT / gameSettingsData.CELL_SIZE) - 1));
        for (var k = 0; k < snake.length; k++) {
            if (collisionDetector.checkIfEatFood({ x: foodX, y: foodY }, snake[k])) {
                createFood();
            }
        }

        return {
            x: foodX,
            y: foodY
        };
    }

    function initSnake() {
        var length = gameSettingsData.SNAKE_INITIAL_LENGTH;
        var initialSnake = [];
        for (var i = length - 1; i >= 0; i--) {
            initialSnake.push({ x: i, y: 0 });
        }

        return initialSnake;
    }

    function initializeGameSettings() {
        gameSettingsData = new GameData();
        renderer = new GameRenderer();
        canvas = document.getElementById('canvas-field');
        ctx = canvas.getContext('2d');

        snake = initSnake();
        collisionDetector = new CollisionDetector();
        food = createFood();
        score = 0;
        gameEnded = false;
        direction = 'right';
    }

    function moveSnake() {
        if (!gameEnded) {
            var headX = snake[0].x;
            var headY = snake[0].y;

            // change head position
            if (direction == gameSettingsData.RIGHT_DIRECTION) {
                headX++;
            }
            else if (direction == gameSettingsData.LEFT_DIRECTION) {
                headX--;
            }
            else if (direction == gameSettingsData.UP_DIRECTION) {
                headY--;
            }
            else if (direction == gameSettingsData.DOWN_DIRECTION) {
                headY++;
            }

            // tail of the snake goes as head of the snake
            var tail = snake.pop();
            tail.x = headX;
            tail.y = headY;
            snake.unshift(tail);
        }
    }

    function startGame() {
        moveSnake();

        var head = snake[0];

        if (collisionDetector.checkIfBiteItself(snake, gameSettingsData) || collisionDetector.checkIfHitWall(snake, gameSettingsData)) {
            ctx.clearRect(0, 0, gameSettingsData.FIELD_WIDTH, gameSettingsData.FIELD_HEIGHT);
            ctx.fillText("GAME OVER", 100, 100);
            ctx.fillText("SCORE: " + score, 100, 120);

            gameEnded = true;
            return;
        }
        else if (collisionDetector.checkIfEatFood(food, snake[0], gameSettingsData)) {
            ctx.clearRect(food.x, food.y, gameSettingsData.CELL_SIZE, gameSettingsData.CELL_SIZE);

            score += 10;

            var x = snake[snake.length - 1].x;
            var y = snake[snake.length - 1].y;

            snake.push({ x: x, y: y });

            food = createFood();
        }
        else {
            ctx.clearRect(0, 0, gameSettingsData.FIELD_WIDTH, gameSettingsData.FIELD_HEIGHT);
            ctx.beginPath();

            renderer.drawSnake(snake, gameSettingsData, ctx);
            renderer.drawFood(food, gameSettingsData, ctx);
        }
    }

    return {
        initializeGameSettings: initializeGameSettings,
        startGame: startGame
    };
}
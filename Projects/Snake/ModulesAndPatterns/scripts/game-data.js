var GameData = function () {
    return Object.freeze({
        CELL_SIZE: 10,
        FIELD_WIDTH: 600,
        FIELD_HEIGHT: 450,

        SNAKE_INITIAL_LENGTH: 4,
        LEFT_ARROW_KEY_NUMBER: 37,
        UP_ARROW_KEY_NUMBER: 38,
        RIGHT_ARROW_KEY_NUMBER: 39,
        DOWN_ARROW_KEY_NUMBER: 40,
        UP_DIRECTION: 'up',
        DOWN_DIRECTION: 'down',
        LEFT_DIRECTION: 'left',
        RIGHT_DIRECTION: 'right'
    })
};
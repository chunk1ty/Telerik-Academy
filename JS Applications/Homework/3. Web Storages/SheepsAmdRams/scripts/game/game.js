define(['jquery', 'numberGenerator', 'processUserInput', 'localStorageManager'], function ($, GuessNumberUtils, UserInputProcessor, LocalStorageManager) {
    var userMoves = 0;

    function start() {
        GuessNumberUtils.initializeGuessNumber();

        attachEventHandlers();
    }

    function attachEventHandlers() {
        $('#user-guess-button').on('click', function () {
            userMoves += 1;
            var userResult = UserInputProcessor.getUserGuessResult($('#user-input').val());

            if (userResult[10] === '4') {
                $('#game-information-wrapper').fadeOut(2000, function () {
                    $('#user-win-game').fadeIn(2500);
                });
            } else {
                var userResultAsHtml = $('<div />').html(userResult);
                $('#user-guess-result').append(userResultAsHtml);
            }
        });

        $('#submit-username-button').on('click', function () {
            var username = $('#user-username').val();

            LocalStorageManager.saveUser(username, userMoves);
            LocalStorageManager.showAllUsers();
        });
    }

    return {
        start: start
    };
});
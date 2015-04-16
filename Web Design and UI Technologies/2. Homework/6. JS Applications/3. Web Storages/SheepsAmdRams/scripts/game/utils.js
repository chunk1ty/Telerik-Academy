define(['jquery', 'numberGenerator'], function ($, guessNumberUtils) {
    function getUserGuessResult() {
        var userInputAsString = $('#user-input').val().toString(),
            guessNumberAsString = guessNumberUtils.getGuessNumber().toString(),
            guessResult;

        if (isUserInputValid(userInputAsString)) {
            guessResult = findRamsAndSheeps(userInputAsString, guessNumberAsString);
        } else {
            guessResult = 'Invalid entered number. Number must contain four different digits and can not start with 0.';
        }

        return guessResult;
    }

    function isUserInputValid(userInput) {
        var userInputLength = userInput.length,
            i,
            j;

        if (userInput[0] === '0') {
            return false;
        }

        if (userInputLength != 4) {
            return false;
        }

        for (i = 0; i < userInputLength - 1; i += 1) {
            for (j = i + 1; j < userInputLength; j += 1) {
                if (userInput[i] === userInput[j]) {
                    return false;
                }
            }
        }

        return true;
    }

    function findRamsAndSheeps(userInput, numberToGuess) {
        var usedDigits = [];
        var rams = findRams(userInput, numberToGuess);
        var sheeps = findSheeps(userInput, numberToGuess);

        return 'You have: ' + rams + ' ram(s) and ' + sheeps + ' sheep(s)';

        function findRams(userInput, numberToGuess) {
            var rams = 0,
                userInputLength = userInput.length,
                i;

            for (i = 0; i < userInputLength; i += 1) {
                if (userInput[i] === numberToGuess[i]) {
                    rams += 1;
                    usedDigits[i] = true;
                }
            }

            return rams;
        }

        function findSheeps(userInput, numberToGuess) {
            var sheeps = 0,
                userInputLength = userInput.length,
                i,
                j;

            for (i = 0; i < userInputLength; i += 1) {
                for (j = 0; j < userInputLength; j += 1) {
                    if (usedDigits[j]) {
                        continue;
                    }

                    if (userInput[i] === numberToGuess[j]) {
                        sheeps += 1;
                        usedDigits[j] = true;
                    }
                }
            }
            return sheeps;
        }
    }

    return {
        getUserGuessResult: getUserGuessResult
    }
}
);
define(function () {
    var guessNumber;

    function initializeGuessNumber() {
        var possibleDigits = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9],
            possibleDigitsLength = 10,
            i,
            digitIndex;

        guessNumber = '';

        for (i = 0; i < 4; i += 1) {
            if (i !== 0) {
                digitIndex = getIndex(0, possibleDigitsLength);
            } else {
                digitIndex = getIndex(1, possibleDigitsLength);
            }

            guessNumber += possibleDigits[digitIndex];
            possibleDigitsLength -= 1;
            possibleDigits.splice(digitIndex, 1);
        }

        function getIndex(min, max) {
            return Math.floor(Math.random() * (max - min) + min);
        }
    }

    function getGuessNumber() {
        if (guessNumber) {
            return guessNumber;
        }
    }

    return {
        initializeGuessNumber: initializeGuessNumber,
        getGuessNumber: getGuessNumber
    }
});
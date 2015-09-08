function solve(input) {
    var firstLine = input[0].split(' ');
    var row = parseInt(firstLine[0]);
    var col = parseInt(firstLine[1]);
    var currentPositionRow = 0;
    var currentPositionCol = 0;

    var matrixWithDigits = [];
    var matrixWithDirections = [];
    var counter = 1;
    var sum = 0;
    var direction = '';

    parseMatrices();

    while (true) {
        if (!isInRange()) {
            return console.log('successed with ' + sum);
        }
        if (matrixWithDirections[currentPositionRow][currentPositionCol] === 'X') {
            return console.log('failed at (' + currentPositionRow + ', ' + currentPositionCol + ')');
        }

        sum += matrixWithDigits[currentPositionRow][currentPositionCol];

        var currentDir = matrixWithDirections[currentPositionRow][currentPositionCol];

        matrixWithDirections[currentPositionRow][currentPositionCol] = 'X';

        directions(currentDir);
    }

    function parseMatrices() {
        for (var i = 0; i < row; i++) {
            matrixWithDigits[i] = [];
            matrixWithDirections[i] = [];
            var currentLine = input[i + 1].split(' ');
            for (var j = 0; j < col; j++) {
                matrixWithDigits[i][j] = counter;
                counter++;

                matrixWithDirections[i][j] = currentLine[j];
            }
            counter = 0;
            counter = 1 << i + 1;
        }
    }

    function directions(dir) {
        switch (dir) {
            case 'ul': currentPositionRow -= 1;
                currentPositionCol -= 1;
                break;
            case 'ur': currentPositionRow -= 1;
                currentPositionCol += 1;
                break;
            case 'dl': currentPositionRow += 1;
                currentPositionCol -= 1;
                break;
            case 'dr': currentPositionRow += 1;
                currentPositionCol += 1;
                break;
            default:
                console.log('incorrect input');
                break;
        }
    }

    function isInRange() {
        if (currentPositionRow >= 0 && currentPositionRow < row && currentPositionCol >= 0 && currentPositionCol < col) {
            return true;
        }

        return false;
    }

    //console.log(sum);
}
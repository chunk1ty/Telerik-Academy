var consoleModule = (function () {
    function writeLine(obj) {
        var parsedText = parseFormatText(arguments);

        console.log(parsedText);
    }

    function writeError(textOrFormat) {
        var parsedText = parseFormatText(arguments);

        console.error(parsedText);
    }

    function writeWarning(textOrFormat) {
        var parsedText = parseFormatText(arguments);

        console.warn(parsedText);
    }

    function parseFormatText(args) {
        var argsLength = args.length,
            formatText = args[0],
            textToReplace = '',
            symbolsToBeReplaced = '',
            indexOfSymbols = 0;

        if (argsLength > 1) {
            for (var i = 1; i < argsLength; i++) {
                textToReplace = args[i];
                symbolsToBeReplaced = '{' + (i - 1) + '}';
                indexOfSymbols = formatText.indexOf(symbolsToBeReplaced, indexOfSymbols);

                while (indexOfSymbols != -1) {
                    formatText = formatText.replace(symbolsToBeReplaced, textToReplace);

                    indexOfSymbols = formatText.indexOf(symbolsToBeReplaced, indexOfSymbols + 1);
                }
            }
        }

        return convertToString(formatText);
    }

    function convertToString(arg) {
        if (arg === null) {
            throw new Error('Cannot convert null value.');
        }
        else if (arg === undefined) {
            throw new Error('Cannot convert undefined value.');
        }
        else if (arg.hasOwnProperty('isArray')) {
            return arg;
        }
        else if (typeof arg === "object") {
            var result = "{";
            for (var key in arg) {
                result += key + ": " + convertToString(arg[key]) + ", ";
            }

            result = result.trim();
            result += "}";
            return result;
        }
        else {
            return arg.toString();
        }
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    };
}());
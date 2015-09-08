define(function () {
    var UsernameValidator = (function () {
        function isValidUsername(username) {
            var isUsernameTypeValid = username && typeof username == 'string',
                isUsernameLengthValid = username.length >= 3 && username.length <= 15;

            return (isUsernameTypeValid && isUsernameLengthValid);
        }

        return {
            isValidUsername: isValidUsername
        }
    }());

    return UsernameValidator;
});
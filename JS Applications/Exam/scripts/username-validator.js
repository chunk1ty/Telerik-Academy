define(function () {
    var UsernameValidator = (function () {
        var MIN_USERNAME_LENGTH = 6,
            MAX_USERNAME_LENGTH = 40;
        function isValidUsername(username) {
            var isUsernameTypeValid = username && typeof username == 'string',
                isUsernameLengthValid = username.length >= MIN_USERNAME_LENGTH && username.length <= MAX_USERNAME_LENGTH;

            return (isUsernameTypeValid && isUsernameLengthValid);
        }

        return {
            isValidUsername: isValidUsername
        }
    }());

    return UsernameValidator;
});
define(['http-requester', 'sha1', 'jquery'], function (HttpRequester, Sha1, $) {
    var UserController = (function () {
        var RESOURCE_URL = 'http://localhost:3000';
        var UserController = function () {
            this._resourceUrl = RESOURCE_URL;
        };

        UserController.prototype = {
            _getSessionKey: function () {
                return localStorage.getItem("sessionKey");
            },
            _getUsername: function () {
                return localStorage.getItem("username");
            },
            _setSessionKey: function (value) {
                localStorage.setItem("sessionKey", value);
            },
            _setUsername: function (value) {
                this.username = value;
                localStorage.setItem("username", value);
            },
            _clearSessionKey: function () {
                localStorage.removeItem("sessionKey");
            },
            _clearUsername: function () {
                localStorage.removeItem("username");
            },
            register: function (username, password) {
                var registerUrl = this._resourceUrl + '/user';

                return HttpRequester.postJSON(registerUrl, null, {
                    username: username,
                    authCode: CryptoJS.SHA1(username + password).toString()
                });
            },
            login: function (username, password) {
                var loginUrl = this._resourceUrl + '/auth',
                    _this = this;

                return HttpRequester.postJSON(loginUrl, null, {
                    username: username,
                    authCode: CryptoJS.SHA1(username + password).toString()
                }).then(function (result) {
                    _this._setSessionKey(result.sessionKey);
                    _this._setUsername(result.username);
                }, function (err) {
                    var $invalidUsernameOrPassword = $('#invalid-username-or-password').show();
                    $invalidUsernameOrPassword.html('Invalid username or password.');

                    $invalidUsernameOrPassword.fadeOut(2500);

                    return err;
                });
            },
            logout: function () {
                var logoutUrl = this._resourceUrl + '/user',
                    headers = {
                        'X-SessionKey': this._getSessionKey()
                    },
                    _this = this;

                return HttpRequester.putJSON(logoutUrl, headers, null)
                    .then(function () {
                        _this._clearSessionKey();
                        _this._clearUsername();
                    });
            },
            isUserLoggedIn: function () {
                return (this._getUsername() != null);
            },
            getCurrentUserData: function () {
                return {
                    username: this._getUsername(),
                    sessionKey: this._getSessionKey()
                }
            },
            createPost: function () {

            }
        };

        return UserController;
    }());

    return UserController;
});
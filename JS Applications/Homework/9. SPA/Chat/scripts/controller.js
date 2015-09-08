define(['http-requester', 'username-validator', 'ui-controller', 'jquery'], function (HttpRequester, UsernameValidator, UI, $) {
    var Controller = (function () {
        var MAX_MESSAGES_SHOWN_COUNT = 20,
            REFRESH_TIME_MS = 1500;
        
        function getLastMessages(url) {
            HttpRequester.getJSON(url)
                .then(function (messages) {
                    var chatRoomHtml = UI.createChatRoomHtml(messages, MAX_MESSAGES_SHOWN_COUNT);
                    $('#chat-room').html(chatRoomHtml);
                });
        }

        var Controller = function (resourceUrl) {
            this.resourceUrl = resourceUrl;
        };

        Controller.prototype = {
            getUsername: function () {
                return localStorage.getItem('username');
            },
            setUsername: function (username) {
                username = username || 'unknown';
                localStorage.setItem('username', username);
            },
            isLoggedIn: function () {
                return this.getUsername() != null;
            },
            clearUsername: function () {
                localStorage.clear();
            },
            viewAllMessages: function () {
                var _this = this;

                $.get('views/chat.html', function (chatHtml) {
                    $('#main-content').html(chatHtml);
                    $('#user-username').html(_this.getUsername());

                    getLastMessages(_this.resourceUrl);
                    setInterval(function () {
                        getLastMessages(_this.resourceUrl);
                    }, REFRESH_TIME_MS);
                })
            },
            loadLogin: function () {
                $('#main-content').load('views/login.html');
            },
            attachEventHandlers: function () {
                var _this = this,
                    $mainContent = $('#main-content');

                $mainContent.on('click', '#login-button', function () {
                    var username = $('#username').val();

                    _this.setUsername(username);
                });

                $mainContent.on('click', '#send-message-button', function () {
                    var messageToSend = $('#message-to-send').val().trim(),
                        messageUser = _this.getUsername();

                    if (messageToSend) {
                        HttpRequester.postJSON(_this.resourceUrl, null, {
                            user: messageUser,
                            text: messageToSend
                        }).then(function (data) {
                            console.log(data);
                            $('#message-to-send').val('');
                            var messageHtml = UI.createMessageHtml({ by: messageUser, text: messageToSend });
                            $('#chat-room').prepend(messageHtml);
                        }, function (err) {
                            $('#main-content').html(err);
                        })
                    }
                });

                $mainContent.on('click', '#logout-button', function () {
                    var exit = confirm("Are you sure you want to end the session?");
                    if (exit === true) {
                        _this.clearUsername();
                    }
                });
            }
        };

        return Controller;
    }());

    return Controller;
});
define(['jquery'], function ($) {
    var UI = (function () {
        var MAX_MESSAGE_LENGTH = 40;

        var $strong = $('<strong />'),
            $span = $('<span />'),
            $div = $('<div />');

        $div.append($strong)
            .append($span);

        function createMessageHtml(message) {
            var postBy = message.by.trim(),
                postText = message.text.trim();

            if (!postBy || !postText) {
                return;
            }

            if (postText.length > MAX_MESSAGE_LENGTH) {
                postText = postText.substr(0, MAX_MESSAGE_LENGTH) + '...';
            }

            $strong.html(postBy + ': ');
            $span.html(postText);

            return $div.clone(true);
        }

        function createChatRoomHtml(messages, skipMessagesCount) {
            var $chatRoom = $('<div />'),
                messagesLength = Math.max(messages.length - skipMessagesCount, 0);

            for (var i = messages.length - 1; i > messagesLength; i -= 1) {
                var message = messages[i],
                    messageHtml = createMessageHtml(message);

                if (!messageHtml) {
                    continue;
                }

                $chatRoom.append(messageHtml);
            }

            return $chatRoom;
        }

        return {
            createMessageHtml: createMessageHtml,
            createChatRoomHtml: createChatRoomHtml
        }
    }());

    return UI;
});
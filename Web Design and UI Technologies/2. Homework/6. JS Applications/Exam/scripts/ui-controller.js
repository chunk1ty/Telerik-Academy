define(['jquery'], function ($) {
    var UI = (function () {
        function addPost(post, parentSelector) {
            var username = '';
            if (post.user) {
                username = post.user.username;
            } else {
                username = localStorage.getItem('username');
            }

            var div = $('<div />'),
                postedBy = $('<strong />'),
                title = $('<h2 />'),
                content = $('<p />'),
                postDate = post.postDate;

            var postedByHtml = 'Posted by: ' + username;

            if (postDate) {
                postedByHtml += ' on: ' + post.postDate;
            }

            postedBy.html(postedByHtml);
            title.html('Title: ' + post.title);
            content.html('Content: ' + post.body);

            div.append(title);
            div.append(postedBy);
            div.append(content);

            $('#' + parentSelector).append(div);
        }

        return {
            addPost: addPost
        }
    }());

    return UI;
});
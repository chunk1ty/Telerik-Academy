define(['http-requester', 'underscore'], function (HttpRequester, _) {
    var PostsController = (function () {
        var RESOURCE_URL = 'http://localhost:3000/post/';
        var PostsController = function () {
            this._resourceUrl = RESOURCE_URL;
        };

        PostsController.prototype = {
            createPost: function (post, sessionKey) {
                return HttpRequester.postJSON(this._resourceUrl, { 'X-SessionKey': sessionKey}, post);
            },
            getAllPosts: function () {
                return HttpRequester.getJSON(this._resourceUrl, null);
            },
            getPostsSortedByTitle: function (data) {
                var posts = data.slice(0);

                return _.sortBy(posts, function (post) {
                    return post.title.toLowerCase();
                });
            },
            getPostsSortedByDate: function (data) {
                var posts = data.slice(0);

                return _.sortBy(posts, function (post) {
                    return post.postDate;
                });
            },
            getPostsByUsername: function (username) {
                return HttpRequester.getJSON(this._resourceUrl + '?user=' + username);
            },
            getPostsByPattern: function(pattern) {
                return HttpRequester.getJSON(this._resourceUrl + '?pattern=' + pattern);
            },
            getPostsByBoth: function(pattern, username) {
                return HttpRequester.getJSON(this._resourceUrl + '?pattern=' + pattern + '&user=' + username);
            }
        };

        return PostsController;
    }());

    return PostsController;
});
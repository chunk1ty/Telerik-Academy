define(['jquery', 'user-controller', 'posts-controller', 'ui-controller', 'username-validator'],
    function ($, UserController, PostsController, UI, UsernameValidator) {
        var HandlersAttacher = (function () {
            var userController = new UserController(),
                postsController = new PostsController(),
                $mainContent = $('#main-content');

            function showWantedPosts(selector, responseData) {
                var $posts = $('#' + selector);
                $posts.html('');
                $posts.show();

                for (var i in responseData) {
                    UI.addPost(responseData[i], selector);
                }
            }

            function attachGoToRegister() {
                $mainContent.on('click', '#go-to-register-button', function () {
                    $mainContent.load('views/registration-form.html');
                });
            }

            function attachLogout() {
                $mainContent.on('click', '#logout-button', function () {
                    userController.logout();
                    window.location = '#/';
                });
            }

            function attachPostCreate() {
                $mainContent.on('click', '#post-create-button', function () {
                    var post = {
                        title: $('#post-title').val(),
                        body: $('#post-body').val()
                    };

                    UI.addPost(post);
                    postsController.createPost(post, userController._getSessionKey());
                });
            }

            function attachRegister() {
                $mainContent.on('click', '#register-button', function () {
                    var username = $('#registration-username-input').val(),
                        password = $('#registration-password-input').val();

                    var isValidUsername = UsernameValidator.isValidUsername(username);

                    if (isValidUsername) {
                        userController.register(username, password)
                            .then(function () {
                                $('#main-content').load('views/login-form.html');
                            }, function (err) {
                                $('#main-content').html(err);
                            });
                    } else {
                        var $invalidUsernameOrPassword = $('#register-invalid-username-or-password');
                        $invalidUsernameOrPassword.html('Invalid username. The username must be between 6 and 40 symbols!');
                        $invalidUsernameOrPassword.fadeOut(2500);
                    }
                });
            }

            function attachLogin() {
                $mainContent.on('click', '#login-button', function () {
                    var username = $('#user-username-input').val(),
                        password = $('#user-password-input').val();

                    if (UsernameValidator.isValidUsername(username)) {
                        userController.login(username, password)
                            .then(function () {
                                $('#main-content').load('views/crowd-share.html');
                            }).then(function (err) {
                                $('#main-content').html(err);
                            });
                    } else {
                        var $invalidUsernameOrPassword = $('#invalid-username-or-password');
                        $invalidUsernameOrPassword.html('Invalid username or password.');

                        $invalidUsernameOrPassword.fadeOut(2500);
                    }
                });
            }

            function attachShowAllPosts() {
                $mainContent.on('click', '#get-all-posts-button', function () {
                    postsController.getAllPosts()
                        .then(function (responseData) {
                            showWantedPosts('posts', responseData);
                        });
                });

                $mainContent.on('click', '#not-logged-get-all-posts-button', function () {
                    $('#not-logged-user-posts-container').show();
                    postsController.getAllPosts()
                        .then(function (responseData) {
                            showWantedPosts('not-logged-user-posts-container', responseData);
                        });
                })
            }

            function attachHideAllPosts() {
                $mainContent.on('click', '#hide-all-posts-button', function () {
                    $('#posts').hide();
                });

                $mainContent.on('click', '#not-logged-hide-all-posts-button', function () {
                    $('#not-logged-user-posts-container').hide();
                });
            }

            function attachShowPostsOrderedBy() {
                $mainContent.on('click', '#get-posts-ordered-by-date-button', function () {
                    postsController.getAllPosts().then(function (responseData) {
                        var sorted = postsController.getPostsSortedByDate(responseData);
                        console.log(sorted);
                        showWantedPosts('posts', sorted);
                    });
                });

                $mainContent.on('click', '#get-posts-ordered-by-title-button', function () {
                    postsController.getAllPosts().then(function (responseData) {
                        var sorted = postsController.getPostsSortedByTitle(responseData);
                        console.log(sorted);
                        showWantedPosts('posts', sorted);
                    });
                });
            }

            function attachSearch() {
                $mainContent.on('click', '#search-by-username-button', function () {
                    postsController.getPostsByUsername($('#search-by-username-input').val())
                        .then(function (responseData) {
                            showWantedPosts('posts', responseData);
                        });
                });

                $mainContent.on('click', '#search-by-pattern-button', function () {
                    postsController.getPostsByPattern($('#search-by-pattern-input').val())
                        .then(function (responseData) {
                            showWantedPosts('posts', responseData);
                        });
                });

                $mainContent.on('click', '#search-by-both-button', function () {
                    postsController.getPostsByBoth($('#search-by-pattern-input').val(), $('#search-by-username-input').val())
                        .then(function (responseData) {
                            console.log(responseData);
                            showWantedPosts('posts', responseData);
                        });
                });
            }

            function attachHandlers() {
                attachGoToRegister();
                attachLogout();
                attachPostCreate();
                attachRegister();
                attachLogin();
                attachShowAllPosts();
                attachHideAllPosts();
                attachShowPostsOrderedBy();
                attachSearch();
            }

            return {
                attachHandlers: attachHandlers,
                user: userController,
                posts: postsController
            }
        }());

        return HandlersAttacher;
    });
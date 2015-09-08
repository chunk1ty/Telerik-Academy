(function () {
    require.config({
        paths: {
            'jquery': '../libs/jquery',
            'q': '../libs/q',
            'underscore': '../libs/underscore-min',
            'http-requester': './http-requester',
            'sammy': '../libs/sammy-latest.min',
            'sha1': '../libs/cryptojs-sha1',
            'user-controller': './user-controller',
            'username-validator': './username-validator',
            'posts-controller': './posts-controller',
            'ui-controller': './ui-controller'
        }
    });

    require(['jquery', 'sammy', 'main-controller'],
        function ($, Sammy, MainController) {

            MainController.attachHandlers();

            var app = Sammy('#main-content', function () {
                this.get('#/', function () {
                    $('#main-content').load('views/login-form.html');
                });

                this.get('#/crowd-share', function () {
                    if(MainController.user.isUserLoggedIn()) {
                        $('#main-content').load('views/crowd-share.html');
                    } else {
                        $('#main-content').load('views/login-form.html');
                    }
                })
            });

            app.run('#/');
        });
}());
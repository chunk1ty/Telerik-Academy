(function () {
    require.config({
       paths: {
           'q': '../libs/q',
           'jquery': '../libs/jquery',
           'underscore': '../libs/underscore-min',
           'mocha': '../libs/mocha',
           'chai': '../libs/chai',
           'http-requester': '../scripts/http-requester',
           'posts-controller': '../scripts/posts-controller'
       }
    });

    require(['chai', 'mocha', 'posts-controller'], function(chai) {
        mocha.setup('bdd');

        // maybe better to use chai in all the test files and refer chai
        expect = chai.expect;
        assert = chai.assert;
        should = chai.should;

        // all test files in the [] to run them
        require(['./test'], function() {
            mocha.run();
        });
    });
}());
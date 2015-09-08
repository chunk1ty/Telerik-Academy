(function () {
    require.config({
        paths: {
            'jquery': '../libs/jquery.min',
            'numberGenerator': './game/numberGenerator',
            'processUserInput': './game/processUserInput',
            'localStorageManager': './game/localStorageManager'
        }
    });

    require(['game/game'], function (Game) {
        Game.start();
    });
}());
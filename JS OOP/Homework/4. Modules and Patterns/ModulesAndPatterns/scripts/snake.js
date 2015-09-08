function snake() {
    var gameEngine = new GameEngine();
    gameEngine.initializeGameSettings();

    var loop;
    if (typeof loop !== "undefined") {
        clearInterval(loop);
    }
    else {
        loop = setInterval(gameEngine.startGame, 75);
    }
}
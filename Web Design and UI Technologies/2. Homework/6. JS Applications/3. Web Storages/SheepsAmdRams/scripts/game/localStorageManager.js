define(['jquery'], function ($) {
    function saveUserToLocalStorage(username, userMoves) {
        username = username || 'unknown';

        localStorage.setItem(username, userMoves);

        showAllUsers();
    }

    function showAllUsers() {
        var allUsers = $('<div />');
        for (var i in localStorage) {

            var userInfo = i + ': ' + localStorage[i] + ' moves.';
            var currentUser = $('<div />').html(userInfo);

            allUsers.append(currentUser);
        }

        $('#user-win-game').hide();
        $('#users-results').show();

        $('#users-results').find('div').remove();
        $('#users-results').append(allUsers);
    }

    return {
        saveUser: saveUserToLocalStorage,
        showAllUsers: showAllUsers
    }
});
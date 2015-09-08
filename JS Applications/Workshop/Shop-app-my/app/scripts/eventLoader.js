import data from 'scripts/data.js'

export default {
    loginPageEvents: function($container) {
        $container.on('click','#btn-login', function(ev){
            var username = $('#input-username').val(),
                password = $('#input-password').val();

            data.users.login(username, password);
        })

        $container.on('click','#btn-reg', function(ev){
            var username = $('#input-username').val(),
                password = $('#input-password').val();

            data.users.register(username, password);
        })
    },
    
    navigationEvents: function ($container) {
        $container.on('click', 'btn-logout', function(ev) {
            data.users.logout();
        })
    }
}
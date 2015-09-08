import 'sammy'
import 'jquery'
import templates from 'scripts/templates.js'
import eventLoader from 'scripts/eventLoader.js'
import notifier from 'scripts/notifier.js'

var containerId = '#container',
    $container = $(containerId);

var sammyApp = Sammy(containerId, function(){
    this.get('#/',function(){
        this.redirect('#/home')
    });

    this.get('#/home',function(){
        templates.load('home')
            .then(function(templateHtml){
                $container.html(templateHtml);
            })
    });

    this.get('#/shops',function(){
        templates.load('shops')
            .then(function(templateHtml){
                $container.html(templateHtml);
            })
    })

    this.get('#/login',function(){
        templates.load('login')
            .then(function(templateHtml){
                $container.html(templateHtml);
            })

        eventLoader.loginPageEvent($container);
    })

    templates.load('loginlogout')
        .then(function(templateHtml) {
                $('#wrapper nav').append(templateHtml);
            })
});

sammyApp.run('#/home');
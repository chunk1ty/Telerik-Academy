/// <reference path = "libs/controls.js" />
/// <reference path = "libs/controls.js" />
(function () {

    require.config({
        paths: {
            "jquery": "libs/jquery.min",
            "handlebars": "libs/handlebars.min"
        }
    });

    require(['jquery', 'controls', 'data'], function (unUsed$, controls, data) {
        var comboBox = controls.ComboBox(data);
        var template = $('#person-template').html();
        var comboBoxHtml = comboBox.render(template);        
        $('#holder').html(comboBoxHtml);
    });

}());
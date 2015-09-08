/// <reference path="../libs/jquery-2.0.3.js" />

define(["jquery"], function ($) {
    var controls = {};

    var ComboBox = function (items) {
        if (!(items instanceof Array)) {
            throw { name: 'Combo box items exception', message: 'Items in combo box must be an instance of Array' };
        }
        this.items = items;
    };

    ComboBox.prototype.render = function (template) {
        var $itemsList = $('<ul />');
        $itemsList.addClass('person-list');

        var $listItem = $('<li />');

        for (var i = 0; i < this.items.length; i += 1) {
            $listItem.attr('id', this.items[i].id);
            $listItem.html(template(this.items[i]));
            $itemsList.append($listItem.clone(true));
        }

        $itemsList.children().hide();

        $itemsList.children()
            .first()
            .addClass('selected')
            .show();

        return $itemsList;
    };


    controls.ComboBox = function (itemsSource) {
        return new ComboBox(itemsSource);
    };

    return controls;
});
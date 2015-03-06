define(function () {
  'use strict';
  var Section;
  Section = (function () {
    function Section(title) {
      this._title = title;
      this._items = [];
    }

    Section.prototype = {
      add: function (item) {
        this._items.push(item);
        return this;
      },
      getData: function () {
        var dataItems, i, len, item;

        dataItems = [];
        for (i = 0, len = this._items.length; i < len; i += 1) {
          item = this._items[i];
          dataItems.push(item.getData());
        }

        return {
          title: this._title,
          items: dataItems
        };
      }
    };
    return Section;
  }());
  return Section;
});
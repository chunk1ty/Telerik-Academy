///< reference path="libs/item.js" /> 

define(['tech-store-models/item'], function (Item) {
    'use strict'
    var Store;
    Store = (function () {
        function Store(name) {
            validateName(name);

            this._name = name;
            this._items = [];
        }
        
        function validateName(name) {
            var nameLen = name.length;
            if (nameLen < 6 || nameLen > 30) {
                throw { type: 'name', message: 'Invalid range' }
            }
        }

        function sortItemsByName(items) {
            items.sort(function (firstItem, secondItem) {
                return firstItem._name.localeCompare(secondItem._name);
            });

            return items;
        }

        function getItemType(type, items) {
            var itemsToReturn = [];


            for (var i in items) {
                var item = items[i];

                if (item._type === type) {
                    itemsToReturn.push(item);
                }
            }

            return itemsToReturn;
        }

        function sortItemsByPrice(items) {
            items.sort(function (firstItem, secondItem) {
                return firstItem._price - secondItem._price;
            });

            return items;
        }

        function getItemsByPriceRange(options, items) {
            var min = 0,
                max = Number.POSITIVE_INFINITY;

            if (options) {
                min = options.min || 0;
                max = options.max || Number.POSITIVE_INFINITY;
            }           
            
            var result = [];
            
            for (var prop in items) {
                var currentItem = items[prop];

                if (currentItem._price > min && currentItem._price < max) {
                    result.push(currentItem);
                }
            }

            return result;
        }
        
        Store.prototype.addItem = function (item) {
            this._items.push(item);
            return this;
        }
       
        Store.prototype.getAll = function () {
            return sortItemsByName(this._items);
        }

        Store.prototype.getSmartPhones = function () {
            var smartPhones = getItemType('smart-phone', this._items);            
            return sortItemsByName(smartPhones);
        }

        Store.prototype.getMobiles = function () {
            var smartPhones = getItemType('smart-phone', this._items);
            var tablet = getItemType('tablet', this._items);
            var mobiles = smartPhones.concat(tablet);
            return sortItemsByName(mobiles);
        }

        Store.prototype.getComputers = function () {
            var pc = getItemType('pc', this._items);
            var notebook = getItemType('notebook', this._items);
            var computers = pc.concat(notebook);
            return sortItemsByName(computers);
        }

        Store.prototype.filterItemsByType = function (filterType) {
            var filteredItems = getItemType(filterType, this._items);
            return sortItemsByName(filteredItems);
        }

        Store.prototype.filterItemsByPrice = function (options) {
            var itemsInPriceRange = getItemsByPriceRange(options, this._items);
            return sortItemsByPrice(itemsInPriceRange);
        }

        Store.prototype.countItemsByType = function () {
            var itemsAsDictionary = {};

            for (var i = 0; i < this._items.length; i++) {
                var currentItem = this._items[i];

                if (itemsAsDictionary[currentItem._type] === undefined) {
                    itemsAsDictionary[currentItem._type] = 1;
                }
                else {
                    itemsAsDictionary[currentItem._type]++;
                }
            }

            return itemsAsDictionary;
        }

        Store.prototype.filterItemsByName = function (partOfName) {
            var sortedCollection = [];
            partOfName = partOfName.toLowerCase();
            var pattern = /partOfName/gi;
            for (var i = 0; i < this._items.length; i++) {
                var currentItem = this._items[i];
                var currentItemName = currentItem._name.toLowerCase();
                if (currentItemName.search(partOfName) !== -1) {
                    sortedCollection.push(currentItem);
                }
            }

            return sortedCollection;
        }

        return Store;
    })();
    return Store;
})
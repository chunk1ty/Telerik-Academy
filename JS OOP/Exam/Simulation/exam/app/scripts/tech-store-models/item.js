///< reference path="libs/store.js" />
define([], function () {
    'use strict';
    var Item;
    Item = (function () {
        function Item(type, name, price) {
            validateType(type);
            validateName(name);
            //validatePrice(price);

            this._type = type;
            this._name = name;
            this._price = price;
        }
        
        function validateType(type) {
            var allowedTypes = ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'];

            var isVallid = false;
            for (var i = 0; i < allowedTypes.length; i++) {
                if (type === allowedTypes[i]) {
                    isVallid = true;
                }
                if (isVallid) {
                    break;
                }
            }

            if (!isVallid) {
                throw { type: 'IncorrectType', message: 'Invalid type'}
            }
        }

        function validateName(name) {
            var nameLen = name.length;
            if (nameLen < 6 || nameLen > 40) {
                throw { type: 'name', message: 'Invalid range' }
            }
        }

        function validateprice(price) {            
            if (isNaN(price)) {
                throw { type: 'price', message: 'invalid decimal number' }
            }
        }

        return Item;
    })();
    return Item;
});
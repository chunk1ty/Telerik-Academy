define(['todo-list/section'],function (Section) {
	'use strict';
	var Container;
	Container = (function () {
		//hidden data only accessible for Container instances
		var lastContainerId = 0;
		function Container() {
			this._id = ++lastContainerId;
			this._sections = [];
		}

		Container.prototype = {
			add: function (section) {
				if(!(section instanceof Section)){
					throw {
						message: 'Not a section in'
					};
				}
				this._sections.push(section);
				return this;
			},
			getData: function () {
				var i, section, dataSections, len;

				dataSections = [];

				for (i = 0, len = this._sections.length; i < len; i += 1) {
					section = this._sections[i];
					dataSections.push(section.getData());
				}
				return dataSections;
			}
		};
		return Container;
	}());
	return Container;
});
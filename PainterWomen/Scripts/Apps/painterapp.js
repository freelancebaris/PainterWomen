'use strict';
var painterapp = angular.module('painterapp', []);

painterapp.directive('copyHidden', function () {
    return function (scope, element, attrs) {
        if (attrs.ngModel) {
            debugger;
            scope[attrs.ngModel] = element.val();
        }
    };
});
var getBaseUrl = function () {
    return location.protocol + "//" + location.hostname +
        (location.port && ":" + location.port) + "/";
};
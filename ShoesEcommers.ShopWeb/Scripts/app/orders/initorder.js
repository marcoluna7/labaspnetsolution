var factoryModule = angular.module("factoryModule", []);
factoryModule.factory("factoryGlobal", function ($http, $q) {
    var service = {};
    service.get = function (url) {
        var deferred = $q.defer();
        $http.get(url).
        success(function (data, status, headers, config) {
            deferred.resolve(data);
        }).
        error(function (data, status, headers, config) {
            deferred.reject('Error');
        });
        return deferred.promise;
    };

    service.post = function (url, parameters) {
        var deferred = $q.defer();
        $http.post(url, parameters).
        success(function (data, status, headers, config) {
            deferred.resolve(data);
        }).
        error(function (data, status, headers, config) {
            deferred.reject('Error');
        });
        return deferred.promise;
    };

    service.delete = function (url, parameters) {
        var deferred = $q.defer();
        $http.delete(url, parameters).
        success(function (data, status, headers, config) {
            deferred.resolve(data);
        }).
        error(function (data, status, headers, config) {
            deferred.reject('Error');
        });
        return deferred.promise;
    }
    return service;
});
var orderApp = angular.module('orderApp', ['ngRoute', 'factoryModule']);
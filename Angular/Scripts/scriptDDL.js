var app = angular.module('MyApp', []);
app.controller('MyController', function ($scope) {
    $scope.MyVal = "Welcome to Angular.js";
    $scope.MyFunc = function () {
        alert('Hello World: ');
    }
    $scope.MyFunc2 = function (val) {
        alert('parameter passed: ' + val);
    }
});
var app = angular.module('CabinetApp', ["kendo.directives", "ui.bootstrap", "ngRoute"]);
app.controller('MainCtrl', function ($scope, $modal, $http, $interval, Data) {
    $scope.CurrentView = "authentification.html";
    $scope.profil = {};
    loginCtrl($scope, $http);
    $scope.fctpatient = function () {
        $scope.CurrentView1 = "patient.html";
    };
    $scope.fctcalendar = function () {
        $scope.CurrentView1 = "calendar.html";
    };
    $scope.fcttreatment = function () {
        $scope.CurrentView1 = "contact.html";
    };
    patientCtrl($scope, $modal, $http);

    $scope.theTime = new Date().toLocaleTimeString();
    $interval(function () {
        $scope.theTime = new Date().toLocaleTimeString();
    }, 1000);

});



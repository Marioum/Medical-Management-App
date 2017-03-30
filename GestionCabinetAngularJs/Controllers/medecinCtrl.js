//app.config(function ($routeProvider, $locationProvider, $httpProvider) {
//    $routeProvider.when('/patient',
//    {
//        templateUrl: 'patient.html',
//        controller: 'Ctrl'
//    });
//    $routeProvider.when('/about',
//    {
//        templateUrl: 'about.html',
//        controller: 'AboutCtrl'
//    });
//    $routeProvider.when('/contact',
//    {
//        templateUrl: 'contact.html',
//        controller: 'ContactCtrl'
//    });
//    $routeProvider.otherwise(
//    {
//        redirectTo: '',
//        controller: 'Ctrl',
//    }
//  );
//});

//app.controller('NavCtrl', ['$scope', '$location', function ($scope, $location) {
//    $scope.navClass = function (page) {
//        var currentRoute = $location.path().substring(1) || 'patient';
//        return page = currentRoute ? 'active' : '';
//    };
  
//   // $scope.souspageview = "patient.html";

//}]);

//app.controller('AboutCtrl', function ($scope, $compile) {
   
//    console.log('inside about controller');

//});

//app.controller('Ctrl', function ($scope, $compile,$modal,$http) {
//    patientCtrl($scope, $modal, $http);
//    console.log('inside patient controller');
   
//});

//app.controller('ContactCtrl', function ($scope, $compile) {
//    console.log('inside contact controller');
   
//});


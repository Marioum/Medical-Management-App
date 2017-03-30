var loginCtrl = function ($scope, $http) {
    $scope.profil = {};
    $scope.user = {};
    $scope.fctSubmit = function () {


        $http({
            method: "GET",
            url: "/api/authentifier",
            params: { log: $scope.profil.login, pw: $scope.profil.psw },
            headers: { 'Content-Type': 'application/json' },
            datatype: 'json'
        }).success(function (response) {
            if (response == null)
                alert("login or passewrd not correct!");
            else {
                $scope.user = response;
                if ($scope.user.role == "Medecin   ") {
                    $scope.CurrentView = "medecin.html";
                }
                else {
                    $scope.CurrentView = "secretaire.html";
                }
                
            }

        }).error(function (error) {
            alert("error!");
        });

    }
};
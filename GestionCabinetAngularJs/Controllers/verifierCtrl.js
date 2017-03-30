var verifierCtrl = function ($scope, $http, $modal, $modalInstance, datapatientupdated) {
    $scope.yesUpdate = function () {
        $http({
            method: "GET",
            url: "/api/updatepatients",
            params: { patient: datapatientupdated },
            headers: { 'Content-Type': 'application/json' },
            datatype: 'json'
        }).success(function (response) {
            //patientCtrl($scope, $modal, $http);
            //$scope.getallpatient();
            $modalInstance.close();
           

        }).error(function (error) {
            alert("error!!!!!");
        });
        
    }

    $scope.noUpdate = function () {
        $modalInstance.close();
    }
}
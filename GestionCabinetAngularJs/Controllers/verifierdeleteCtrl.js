var verifierdeleteCtrl = function ($scope, $http, $modalInstance, datapatientdelete, $modal, mainGridOptions) {
    $scope.yesDelete = function () {
        $http({
            method: "GET",
            url: "/api/deletepatients",
            params: { patien: datapatientdelete },
            headers: { 'Content-Type': 'application/json' },
            datatype: 'json'
        }).success(function (response) {
            //patientCtrl($scope, $modal, $http);
            //$scope.getallpatient();
            $scope.getpatients();
            $modalInstance.close();
        }).error(function (error) {
            alert("error!");
        });
        
    };



    $scope.getpatients = function () {

        $http({
            method: "GET",
            url: "/api/getpatients",

            headers: { 'Content-Type': 'application/json' },
            datatype: 'json'
        }).success(function (response) {
           mainGridOptions.dataSource.data = response;
        }).error(function (error) {
            alert("error!");
        });

    }
    $scope.noDelete = function () {
        $modalInstance.close();
    }
}
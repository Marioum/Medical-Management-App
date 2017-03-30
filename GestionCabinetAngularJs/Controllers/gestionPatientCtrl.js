var gestionPatientCtrl = function ($scope, $http, $modal, $modalInstance, dataPatient, mainGridOptions) {
    
    $scope.addPatient = function (newp) {
        var patientajout = newp;
       patientajout.dateNaissance = new Date();
        $http({
            method: "GET",
            url: "/api/addpatients",
            params: { newpatient: patientajout, datenaissance: newp.dateNaissance },
            headers: { 'Content-Type': 'application/json' },
            datatype: 'json'
        }).success(function (response) {
            $scope.getpatients();
            $modalInstance.close();


        }).error(function (error) {
            alert("Add error!");
        });

    }

    $scope.yesDelete = function () {
        $http({
            method: "GET",
            url: "/api/deletepatients",
            params: { patien: dataPatient },
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

    //pour remplir formulaire edit patient
    $scope.patient = {};
    $scope.patient = dataPatient;

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
   
    $scope.yesUpdate = function (patient) {
        $http({
            method: "GET",
            url: "/api/updatepatients",
            params: { patient: patient },
            headers: { 'Content-Type': 'application/json' },
            datatype: 'json'
        }).success(function (response) {
            $scope.getpatients();
            $modalInstance.close();
            $("#Modaledit").remove();
            $('.modal-backdrop').remove();

        }).error(function (error) {
            alert("error!!!!!");
        });

    }

    //$scope.updatepatient = function (patient) {
    //    var p = dataPatient;
    //    $scope.modalInstance = $modal.open({
    //        templateUrl: 'verifier.html',
    //        controller: verifierCtrl,
    //        size: 'lg',
    //        resolve: {
    //            datapatientupdated: function () {
    //                return p;
    //            }
    //        }
    //    });
    //}

    $scope.cancelpatient = function () {
        $modalInstance.close();
    }
}
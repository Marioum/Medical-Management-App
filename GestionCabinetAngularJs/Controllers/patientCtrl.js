var patientCtrl = function ($scope, $modal, $http) {
    //$scope.profil = {};
    //$scope.user = {};
    $scope.pat = {};

    $scope.mainGridOptions = {
        columns: [
            { field: "numCin", title: "CIN", width: "80px" },
            { field: "nom", title: "Nom", width: "80px" },
            { field: "prenom", title: "Prénom", width: "80px" },
            { field: "dateNaissance", title: "Date de naissance", width: "130px" },
            { field: "sexe", title: "Sexe", width: "60px" },
            { field: "poids", title: "Poids", width: "60px" },
            { field: "taille", title: "Taille", width: "60px" },
            { field: "profession", title: "Profession", width: "80px" },
            { field: "etatCivil", title: "Etat Civil", width: "90px" },
            { field: "nbreEnfant", title: "Enfants", width: "90px" },
            {
                title: "&nbsp;", width: "160px",
                template: "<button type= 'button' class='btn btn-warning' ng-click=patientedit(dataItem)>Update</button> <button type= 'button' class='btn btn-danger' ng-click=patientdelete(dataItem)>Delete</button>"
            }],
        pageable: true,
        dataSource: {
            pageSize: 7,
            data: []
        }
    }

    $scope.patientedit = function (dataitem) {
        $scope.modalInstance = $modal.open({
            templateUrl: 'editpatient.html',
            controller: gestionPatientCtrl,
            size: 'lg',
            resolve: {
                dataPatient: function () {
                    return dataitem;
                },
                mainGridOptions: function () {
                    return $scope.mainGridOptions;
                }
            }
        });
    }

    $scope.getallpatient = function () {

        $http({
            method: "GET",
            url: "/api/getpatients",

            headers: { 'Content-Type': 'application/json' },
            datatype: 'json'
        }).success(function (response) {
            $scope.mainGridOptions.dataSource.data = response;
        }).error(function (error) {
            alert("error!");
        });

    }
    $scope.getallpatient();

    $scope.addnewpatient = function () {

        $scope.modalInstance = $modal.open({
            templateUrl: 'addPatient.html',
            controller: gestionPatientCtrl,
            size: 'lg',
            resolve: {
                dataPatient: function () {
                    return null;
                },
                mainGridOptions: function () {
                    return $scope.mainGridOptions;
                }
            }
        })
    }

    $scope.patientdelete = function (dataitem) {
       
        $scope.modalInstance = $modal.open({
            templateUrl: 'verifierdelete.html',
            controller: gestionPatientCtrl,
            size: 'lg',
            resolve: {
                dataPatient: function () {
                    return dataitem;
                },
                mainGridOptions: function () {
                    return $scope.mainGridOptions;
                }
            
            }
        })    
    }
};
var editpatientCtrl = function ($scope, $http, $modal, $modalInstance, dataPatientToEdit) {
    $scope.patient = {};
    $scope.patient = dataPatientToEdit;

    $scope.updatepatient = function () {
        var p = dataPatientToEdit;
        $scope.modalInstance = $modal.open({
            templateUrl: 'verifier.html',
            controller: verifierCtrl,
            size: 'lg',
            resolve: {
                datapatientupdated: function () {
                    return p;
                }
            }
        });
    }

        $scope.cancelpatient = function () {
            $modalInstance.close();
        }
}
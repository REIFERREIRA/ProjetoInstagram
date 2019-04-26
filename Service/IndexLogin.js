angular.module('projeto').service('serviceProjeto',
    ['$http',
        '$q',
        'constants',
        function ($http, $q, constants) {
            this.getByPassword = function (password, username) {
                return $http.get(constants.serviceApiUrl + '/serviceProjeto/getbypassword/');
            };

            this.getMore10 = function () {
                return $http.get(constants.serviceApiUrl + '/compensatorytime/PositiveCompensatoryTime/');
            };

            this.getLess10 = function () {
                return $http.get(constants.serviceApiUrl + '/compensatorytime/NegativeCompensatoryTime/');
            };


        }
    ]
);
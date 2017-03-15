(function() {
    'use strict';

    angular
        .module('app.core')
        .factory('dataService', dataService);

    dataService.$inject = ['$http', 'apiConfig'];

    function dataService($http, apiConfig) {
        var service = {
            get: get
        }

        return service;

        function get(id) {
            return $http({
                url: apiConfig.apiUrl + '/api/movies/' + id,
                method: 'GET'
            }).then(function (res) {
                return res.data;
            });
        }
    };
})();

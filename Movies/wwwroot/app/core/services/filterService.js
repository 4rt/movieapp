(function() {
    'use strict';

    angular
        .module('app.core')
        .factory('filterService', filterService);

    filterService.$inject = ['$http', 'apiConfig'];

    function filterService($http, apiConfig) {
        var service = {
            getByCategory: getByCategory,
            getCategories: getCategories
        }

        return service;

        function getCategories() {

            return $http({
                url: apiConfig.apiUrl + '/api/movies/categories',
                method: 'GET'
            }).then(function (res) {
                return res.data;
            });
        }

        function getByCategory(category) {

            return $http({
                url: apiConfig.apiUrl + '/api/movies/categoried/' + category,
                method: 'GET'
            }).then(function(res) {
                return res.data;
            });
        }
    };
})();
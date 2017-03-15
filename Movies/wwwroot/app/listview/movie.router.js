(function() {
    'use strict';
    angular
        .module('app.movies')
        .config(route);

    route.$inject = ['$stateProvider'];

    function route($stateProvider) {
        $stateProvider
            .state('list', {
                url: '/list',
                templateUrl: 'listview/list.html',
                controller: 'listCtrl',
                controllerAs: 'vm',
                resolve: {
                    list: ['dataService', function(dataService) {
                        return dataService.get('');
                    }],

                    categories: ['filterService', function (filterService) {
                        return filterService.getCategories('');
                    }]
                }
            })
    }
})();

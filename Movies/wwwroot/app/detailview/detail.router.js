(function() {
    'use strict';
    angular
        .module('app.detail')
        .config(route);

    route.$inject = ['$stateProvider'];

    function route($stateProvider) {
        $stateProvider
            .state('movie', {
                url: '/movie/:id',
                templateUrl: 'detailview/detail.html',
                controller: 'detailCtrl',
                controllerAs: 'vm',
                resolve: {
                    detail: ['$stateParams', 'dataService', function($stateParams, dataService) {
                        return dataService.get($stateParams.id);
                    }]
                }
            })
    }
})();

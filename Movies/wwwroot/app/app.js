(function() {

    'use strict';

    // Declare app level module which depends on views, and components
    angular
        .module('app', [
            'ui.router',
            'app.movies',
            'app.detail',
            'app.core'
        ])
        .config(['$stateProvider', '$urlRouterProvider', '$locationProvider', function($stateProvider, $urlRouterProvider, $locationProvider) {
            $urlRouterProvider.otherwise('/list');
        }])
        .constant('apiConfig', {
            apiUrl: 'http://localhost:3552'
        });

})();

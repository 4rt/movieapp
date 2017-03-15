(function() {
    'use strict';

    angular
        .module('app.detail')
        .controller('detailCtrl', detailCtrl);

    detailCtrl.$inject = ['$scope', '$state', '$http', 'detail'];

    function detailCtrl($scope, $state, $http, detail) {
        var vm = this;

        vm.data = detail;

    }
})();

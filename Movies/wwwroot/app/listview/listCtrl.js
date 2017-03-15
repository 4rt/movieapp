(function() {
    'use strict';

    angular
        .module('app.movies')
        .controller('listCtrl', listCtrl);

    listCtrl.$inject = ['$scope', '$http', 'dataService', 'list', 'categories', 'filterService'];

    function listCtrl($scope, $http, dataService, list, categories, filterService) {
        var vm = this;
        vm.data = list;
        vm.categories = categories;

        vm.selection = [];

        vm.toggleSelection = function toggleSelection(categorie) {
            var idx = vm.selection.indexOf(categorie);

            if (idx > -1) {
                vm.selection.splice(idx, 1);
                if (vm.selection.length) {
                    vm.categorize(vm.selection);
                } else {
                    $('.spinner').show();
                    dataService.get('').then(function (res) {
                        vm.data = res;
                    });
                }
            }

            else {
                vm.selection.push(categorie);
                vm.categorize(vm.selection);
            }
        };

        vm.categorize = function (category) {
            $('.spinner').show();
            filterService.getByCategory(category).then(function (res) {
                vm.data = res;
            });
        }
    }

})();

(function() {
    'use strict';

    angular.module('app.core')
        .directive('spinner', spinner);

    function spinner() {
        return {
            restrict: 'A',
            link: function (scope) {

                scope.$watch('$viewContentLoaded', function () { 
                });


                scope.$watch('vm.data', function (newValue, oldValue, scope) {
                    $('.spinner').hide();
                });

            }
        };
    }

})();

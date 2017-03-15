(function () {
    'use strict';

    angular.module('app.core')
        .directive('starLoader', starLoader);

    function starLoader() {
        return {
            restrict: 'E',
            replace: true,
            link: function (scope, element, attr) {
                var rating = parseInt(scope.movie.rating);
                scope.rating = rating;

                for (var i = rating; i > 0; i--) {

                    $(element).append('<li class="star"><svg height="25" width="23" class="star rating"><polygon points="9.9, 1.1, 3.3, 21.78, 19.8, 8.58, 0, 8.58, 16.5, 21.78" style="fill-rule:nonzero;"/></svg></li>');

                }

            },

            template: '<ul class="rating"></ul>'
        };
    }
})();
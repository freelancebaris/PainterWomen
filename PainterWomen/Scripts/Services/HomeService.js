painterapp.factory('homeService', function($http,$q) {
    return {
        getLinks: function (selectedPage) {
            var deferred = $q.defer();
            $http({
                url: getBaseUrl() + 'Ajax' + '/Public/GetMenuLinks',
                method: 'POST'
            }).success(function (response) {
                debugger;
                if (response.success) {
                    response.menuList[selectedPage].className += " current";
                    deferred.resolve(response.menuList);
                }
            });
            return  deferred.promise;
        }
    };
});
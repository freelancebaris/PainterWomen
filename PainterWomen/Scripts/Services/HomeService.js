painterapp.factory('homeService', function($http,$q) {
    return {
        getLinks: function (selectedPage) {
            debugger;
            var deferred = $q.defer();
            $http({
                url: getBaseUrl() + 'Ajax/Public/GetMenuLinks',
                method: 'POST'
            }).success(function (response) {
                debugger;
                if (response.success) {
                    response.menuList[selectedPage].ClassName += " current";
                    deferred.resolve(response.menuList);
                }
            });
            return  deferred.promise;
        }
    };
});
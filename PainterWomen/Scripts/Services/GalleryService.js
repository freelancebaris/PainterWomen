painterapp.factory('galleryService', function ($http, $q) {
    return {        
      getAlbums : function() {
          var deferred = $q.defer();
          $http({
              url: getBaseUrl() + 'Ajax/Gallery/GetAlbums',
              method: 'POST',
          }).success(function(response) {
              if (response.success) {
                  deferred.resolve(response.albums);
              }
          });
          return deferred.promise;
      }  
    };
});
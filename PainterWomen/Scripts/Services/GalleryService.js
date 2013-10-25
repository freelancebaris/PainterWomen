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
      },
      getThumpImages: function() {
          return [
     { Id: 1, src: '/images/slider/thump/t1.jpg' },
     { Id: 2, src: '/images/slider/thump/t2.jpg' },
     { Id: 3, src: '/images/slider/thump/t3.jpg' },
     { Id: 4, src: '/images/slider/thump/t4.jpg' },
     { Id: 5, src: '/images/slider/thump/t5.jpg' },
     { Id: 6, src: '/images/slider/thump/t6.jpg' },
     { Id: 7, src: '/images/slider/thump/t7.jpg' },
     { Id: 8, src: '/images/slider/thump/t8.jpg' },
     { Id: 9, src: '/images/slider/thump/t9.jpg' },
     { Id: 10, src: '/images/slider/thump/t10.jpg' },
     { Id: 11, src: '/images/slider/thump/t1.jpg' },
     { Id: 12, src: '/images/slider/thump/t2.jpg' },
     { Id: 13, src: '/images/slider/thump/t3.jpg' },
     { Id: 14, src: '/images/slider/thump/t4.jpg' },
     { Id: 15, src: '/images/slider/thump/t5.jpg' },
     { Id: 16, src: '/images/slider/thump/t6.jpg' },
     { Id: 17, src: '/images/slider/thump/t7.jpg' },
     { Id: 18, src: '/images/slider/thump/t8.jpg' },
     { Id: 19, src: '/images/slider/thump/t9.jpg' }
          ];
      },
      getSliderImages: function() {
          return [
       { Id: 1, src: '/images/slider/1.jpg' },
       { Id: 2, src: '/images/slider/2.jpg' },
       { Id: 3, src: '/images/slider/3.jpg' },
       { Id: 4, src: '/images/slider/4.jpg' },
       { Id: 5, src: '/images/slider/5.jpg' },
       { Id: 6, src: '/images/slider/6.jpg' },
       { Id: 7, src: '/images/slider/7.jpg' },
       { Id: 8, src: '/images/slider/8.jpg' },
       { Id: 9, src: '/images/slider/9.jpg' },
       { Id: 10, src: '/images/slider/10.jpg' },
       { Id: 11, src: '/images/slider/1.jpg' },
       { Id: 12, src: '/images/slider/2.jpg' },
       { Id: 13, src: '/images/slider/3.jpg' },
       { Id: 14, src: '/images/slider/4.jpg' },
       { Id: 15, src: '/images/slider/5.jpg' },
       { Id: 16, src: '/images/slider/6.jpg' },
       { Id: 17, src: '/images/slider/7.jpg' },
       { Id: 18, src: '/images/slider/8.jpg' },
       { Id: 19, src: '/images/slider/9.jpg' }
          ];
      }
    };
});
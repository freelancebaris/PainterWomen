painterapp.controller('GalleryController', function ($scope, galleryService) {
    $scope.albums = galleryService.getAlbums();
    debugger;
});
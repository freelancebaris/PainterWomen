painterapp.controller('GalleryController', function ($scope, galleryService,$timeout) {
    $scope.albums = galleryService.getAlbums();

    $scope.thumpImages = galleryService.getThumpImages();
    $scope.sliderImages = galleryService.getSliderImages();
    
    var imageIndex = 0;
    $scope.isPlay = false;
    $scope.selectedImage = $scope.sliderImages[imageIndex];
    $scope.setImage = function (image) {
        var index = image.Id - 1;
        $scope.selectedImage = $scope.sliderImages[index];
        imageIndex = index;
    };
    $scope.scrollBack = function () {
        $scope.delay = $timeout($scope.scrollBack, 50);
        var scrollLeft = document.getElementsByClassName('thumpList')[0].scrollLeft;
        document.getElementsByClassName('thumpList')[0].scrollLeft = scrollLeft - 10;
    };
    $scope.scrollForward = function () {
        $scope.delay = $timeout($scope.scrollForward, 50);
        var scrollLeft = document.getElementsByClassName('thumpList')[0].scrollLeft;
        document.getElementsByClassName('thumpList')[0].scrollLeft = scrollLeft + 10;
    };
    $scope.scrollRelease = function () {
        $timeout.cancel($scope.delay);
    };
    $scope.playSlide = function () {
        $scope.isPlay = true;
        console.log($scope.isPlay);
        $scope.autoPlayDelay = $timeout($scope.playSlide, 2000);
        if ($scope.selectedImage == undefined) {
            $scope.selectedImage = $scope.sliderImages[0];
        }
        if ($scope.selectedImage.Id >= $scope.sliderImages.length) {
            console.log($scope.selectedImage.Id);
            imageIndex = 0;
            $scope.selectedImage = $scope.sliderImages[imageIndex];
            document.getElementsByClassName('thumpList')[0].scrollLeft = 0;
        }
        $scope.selectedImage = $scope.sliderImages[imageIndex];
        var scrollLeft = document.getElementsByClassName('thumpList')[0].scrollLeft;
        document.getElementsByClassName('thumpList')[0].scrollLeft = scrollLeft + 70;
        imageIndex++;
    };
    $scope.stopSlide = function () {
        $timeout.cancel($scope.autoPlayDelay);
        $scope.isPlay = false;
    };
});
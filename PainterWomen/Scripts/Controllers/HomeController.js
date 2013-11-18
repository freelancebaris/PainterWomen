'use strict';
painterapp.controller('HomeController', function ($scope,homeService) {

    $scope.links = homeService.getLinks($scope.pagenum);
    $scope.sliders = [
        { imgSrc: '/Content/images/slide-1.jpg' },
        { imgSrc: '/Content/images/slide-2.jpg' },
        { imgSrc: '/Content/images/slide-3.jpg' },
        { imgSrc: '/Content/images/slide-4.jpg' },
        { imgSrc: '/Content/images/slide-5.jpg' },
        
    
    ];
    $scope.pageNums = [];
    for (var i = 0; i < $scope.sliders.length; i++) {
        $scope.pageNums.push({ number: i+1 });
    }
});
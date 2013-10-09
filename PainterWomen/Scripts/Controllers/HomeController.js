'use strict';
painterapp.controller('HomeController', function ($scope) {
    $scope.links = [
        { href: '', text: 'Anasayfa' },
    { href: '', text: 'Hakkımda' },
    { href: '', text: 'Blog' },
    { href: '', text: 'Çalışmalarım', className: 'li-left' },
    { href: '', text: 'İletişim' }
    ];
    $scope.sliders = [
        { imgSrc: '/Content/images/slide-1.jpg' },
        { imgSrc: '/Content/images/slide-2.jpg' },
        { imgSrc: '/Content/images/slide-3.jpg' },
        { imgSrc: '/Content/images/slide-4.jpg' },
        { imgSrc: '/Content/images/slide-5.jpg' }
    ];
});
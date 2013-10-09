painterapp.factory('homeService', function() {
    return {
        getLinks: function (pageNumber) {
            var links = [
                { href: '', text: 'Anasayfa', className: 'li-none' },
                { href: '', text: 'Hakkımda' },
                { href: '', text: 'Blog' },
                { href: '', text: 'Galeri', className: 'li-left li-none' },
                { href: '', text: 'Hayattan' },
                { href: '', text: 'İletişim' }
            ];
            links[pageNumber].className += " current";
            return links;
        }
    };
});
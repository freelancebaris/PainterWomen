var About = {
    init: function () {
        $('#dvAbout').jtable({
            title: 'About',
            paging: true,
            sorting: false,
            actions: {
                listAction: '/About/GetAbout',
                deleteAction: '/About/GetAbout',
                updateAction: '/About/GetAbout',
                createAction: '/About/GetAbout'
            },

            fields: {
                Id: {
                    key: true,
                    create: false,
                    edit: false,
                    list: false
                },

                Title: {
                    title: '',
                },

                Content1: {
                    title: '',
                },

                Content2: {
                    title: '',
                    width: '17%',
                },
                
                Content3: {
                    title: '',
                    width: '17%',
                },
                
                Lang: {
                    title: '',
                    width: '17%',
                }
            }
        });

        //Load student list from server
        $('#dvEtsoCodeGrid').jtable('load');
    }
};

$(document).ready(function () {
    EtsoCode.init();
});
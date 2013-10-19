using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Abstraction.Business;
using Foundation.Abstraction.Repository;
using Foundation.Abstraction.Services;
using Foundation.Model.Gallery;

namespace Business
{
    public class GalleryBusiness:IGalleryBusiness
    {
        private readonly ISessionHelper _sessionHelper;
        private readonly IGalleryRepository _repository;
        public GalleryBusiness(ISessionHelper sessionHelper, IGalleryRepository repository)
        {
            _sessionHelper = sessionHelper;
            _repository = repository;
        }

        public List<Album> GetAlbums()
        {
            var lang = _sessionHelper.UserContext.SelectedLanguage;
            List<Album> albums = _repository.GetAlbums(lang);
            return albums;
            //var albums  = new List<Album>();
            //for (int i = 0; i < 10; i++)
            //{
            //    albums.Add(new Album()
            //    {
            //        Id = i,
            //        CoverImagePath = "",
            //        Description = i.ToString(),
            //        Name = "Album" + i.ToString()
            //    });
            //}
            //return albums;
        }
    }
}

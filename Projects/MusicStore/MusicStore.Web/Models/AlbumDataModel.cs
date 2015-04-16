namespace MusicStore.Web.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using MusicStore.Models;
    using System.Linq.Expressions;

    public class AlbumDataModel
    {
        //public static Func<Album,AlbumDataModel> FromDataToModel
        //{
        //    get
        //    {
        //        return a => new AlbumDataModel()
        //        {
        //            Title = a.Title,
        //            Year = a.Year,
        //            Producer = a.Producer,
        //            Artists = a.Artists.Select(ar => ar.Name),                    
        //            Songs = a.Songs.Select(s => s.Title)
        //        };
        //    }
        //}
        public static Expression<Func<Album, AlbumDataModel>> FromAlbum
        {
            get
            {
                return a => new AlbumDataModel()
                {
                    AlbumId = a.AlbumId,
                    Title = a.Title,
                    Year = a.Year,
                    Producer = a.Producer
                };
            }
        }

        public static Album FromModelToData(AlbumDataModel entity)
        {
            return new Album
            {
                Title = entity.Title,
                Year = entity.Year,
                Producer = entity.Producer
            };
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }

        public int AlbumId { get; set; }

        //public virtual IEnumerable<string> Artists { get; set; }

        //public virtual IEnumerable<string> Songs { get; set; }
    }
}
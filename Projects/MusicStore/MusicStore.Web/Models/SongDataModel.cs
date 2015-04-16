namespace MusicStore.Web.Models
{
    using MusicStore.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class SongDataModel
    {
        public static Func<Song, SongDataModel> FromDataToModel
        {
            get
            {
                return s => new SongDataModel()
                {
                    Title = s.Title,
                    Year = s.Year,
                    Genre = s.Genre,
                    Artist = s.Artist.Name,
                    Album = s.Album.Title
                };
            }
        }

        public static Song FromModelToData(SongDataModel entity)
        {
            return new Song
            {
                Title = entity.Title,
                Year = entity.Year,
                Genre = entity.Genre  
            };
        }        

        public string Title { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }
    }
}
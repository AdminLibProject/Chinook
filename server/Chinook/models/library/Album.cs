using AdminLib;
using DjangoSharp;
using System.Collections.Generic;
using System;

namespace Chinook.models.library {

    [Meta ( table   : "Album"
          , apiName : "album" )]
    public class Album : Model<Album> {

        /******************** Attributes ********************/
        // id
        [IntegerField ( "AlbumId"
                      , primaryKey : true)]
        public int? id;

        // title
        [CharField ( "title" )]
        public string title;

        // artist
        [ForeignKey("ArtistId")]
        public Artist artist;

    }
}
using AdminLib;
using DjangoSharp;
using System.Collections.Generic;
using System;

namespace Chinook.models.library {

    [Meta ( table   : "Track"
          , apiName : "track" )]
    public class Track : Model<Track> {

        /******************** Attributes ********************/
        // id
        [IntegerField ( "TrackId"
                      , primaryKey : true)]
        public int? id;

        // name
        [CharField ( "name" )]
        public string name;

        // album
        [ForeignKey("AlbumId")]
        public Album album;

        // mediaType
        [ForeignKey("MediaTypeId")]
        public MediaType mediaType;

        // genre
        [ForeignKey("GenreId")]
        public Genre genre;

        // composer
        [CharField("Composer")]
        public string composer;

        // duration
        [IntegerField("Milliseconds")]
        public int? duration;

        // bytes
        [IntegerField("bytes")]
        public int? bytes;

        // unitPrice
        [NumberField("UnitPrice")]
        public float? unitPrice;

    }
}
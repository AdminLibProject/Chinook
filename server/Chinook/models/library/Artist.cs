using AdminLib;
using AdminLib.Model;
using System.Collections.Generic;
using System;

namespace Chinook.models.library {

    [Meta ( table   : "Artist"
          , apiName : "artist" )]
    public class Artist : Model<Artist> {

        /******************** Attributes ********************/
        // id
        [IntegerField ( "ArtistId"
                      , primaryKey : true)]
        public int? id;

        // name
        [CharField ( "Name" )]
        public string name;

        // albums
        [ListField]
        public Album[] albums;

    }
}
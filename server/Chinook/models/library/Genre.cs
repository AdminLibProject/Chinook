using AdminLib;
using AdminLib.Model;
using System.Collections.Generic;
using System;

namespace Chinook.models.library {

    [Meta ( table   : "Genre"
          , apiName : "genre" )]
    public class Genre : Model<Genre> {

        /******************** Attributes ********************/
        // id
        [IntegerField ( "GenreId"
                      , primaryKey : true)]
        public int? id;

        // name
        [CharField ( "name" )]
        public string name;

        // tracks
        [ListField]
        public Track[] tracks;

    }
}
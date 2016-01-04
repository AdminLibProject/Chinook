using AdminLib;
using DjangoSharp;
using System.Collections.Generic;
using System;

namespace Chinook.models.library {

    [Meta ( table   : "Playlist"
          , apiName : "playlist" )]
    public class Playlist : Model<Playlist> {

        /******************** Attributes ********************/
        // id
        [IntegerField ( "PlaylistId"
                      , primaryKey : true)]
        public int? id;

        // name
        [CharField ( "name" )]
        public string name;

        // tracks
        [ManyToManyField(midTable: "PlaylistTrack")]
        public Track[] tracks;

    }
}
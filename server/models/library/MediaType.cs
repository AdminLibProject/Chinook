using AdminLib;
using AdminLib.Model;
using System.Collections.Generic;
using System;

namespace Chinook.models.library {

    [Meta ( table   : "MediaType"
          , apiName : "mediaType" )]
    public class MediaType : Model<MediaType> {

        /******************** Attributes ********************/
        // id
        [IntegerField ( "MediaTypeId"
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
using AdminLib;
using AdminLib.Model;
using System.Collections.Generic;
using System;

namespace Chinook.models.store {

    [Meta ( table   : "InvoiceLine"
          , apiName : "invoice/line" )]
    public class InvoiceLine : Model<InvoiceLine> {

        /******************** Attributes ********************/
        // id
        [IntegerField ( "InvoiceLineId"
                      , primaryKey : true)]
        public int? id;

        // invoice
        [ForeignKey("InvoiceId")]
        public Invoice invoice;

        // track
        [ForeignKey("TrackId")]
        public library.Track track;

        // unitPrice
        [NumberField("UnitPrice")]
        public float? unitPrice;

        // quantity
        [IntegerField("Quantity")]
        public int? quantity;

    }
}
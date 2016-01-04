using AdminLib;
using DjangoSharp;
using System.Collections.Generic;
using System;

namespace Chinook.models.store {

    [Meta ( table   : "Invoice"
          , apiName : "invoice" )]
    public class Invoice : Model<Invoice> {

        /******************** Attributes ********************/
        // id
        [IntegerField ( "InvoiceId"
                      , primaryKey : true)]
        public int? id;

        // customer
        [ForeignKey("CustomerId")]
        public Customer customer;

        // invoiceDate
        [DateTimeField("InvoiceDate")]
        public DateTime invoiceDate;

        // billingAddress
        [CharField("BillingAddress")]
        public string billingAddress;

        // billingCity
        [CharField("BillingCity")]
        public string billingCity;

        // billingState
        [CharField("BillingState")]
        public string billingState;

        // billingCountry
        [CharField("BillingCountry")]
        public string billingCountry;

        // billingPostalCode
        [CharField("BillingPostalCode")]
        public string billingPostalCode;

        // total
        [NumberField("Total")]
        public float? total;
    }
}
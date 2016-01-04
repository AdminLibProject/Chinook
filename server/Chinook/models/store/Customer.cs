using AdminLib;
using DjangoSharp;
using System.Collections.Generic;
using System;

namespace Chinook.models.store {

    [Meta ( table   : "Customer"
          , apiName : "customer" )]
    public class Customer : Model<Customer> {

        /******************** Attributes ********************/
        // id
        [IntegerField ( "CustomerId"
                      , primaryKey : true)]
        public int? id;

        // firstName
        [CharField("FirstName")]
        public string firstName;

        // lastName
        [CharField("LastName")]
        public string lastName;

        // company
        [CharField("Company")]
        public string company;

        // address
        [CharField("Address")]
        public string address;

        // city
        [CharField("City")]
        public string city;

        // state
        [CharField("State")]
        public string state;

        // country
        [CharField("Country")]
        public string country;

        // postalCode
        [CharField("PostalCode")]
        public string postalCode;

        // phone
        [CharField("Phone")]
        public string phone;

        // fax
        [CharField("Fax")]
        public string fax;

        // email
        [CharField("email")]
        public string email;

        // supportRepId
        [ForeignKey("SupportRepId")]
        public Employee supportRep;

    }
}
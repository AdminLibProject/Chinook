using AdminLib;
using AdminLib.Model;
using System.Collections.Generic;
using System;

namespace Chinook.models.store {

    [Meta ( table   : "Employee"
          , apiName : "employee" )]
    public class Employee : Model<Employee> {

        /******************** Attributes ********************/
        // id
        [IntegerField ( "EmployeeId"
                      , primaryKey : true)]
        public int? id;

        // firstName
        [CharField("FirstName")]
        public string firstName;

        // lastName
        [CharField("LastName")]
        public string lastName;

        // title
        [CharField("Title")]
        public string title;

        // reportsTo
        [ForeignKey("ReportsTo")]
        public Employee reportsTo;

        // birthDate
        [DateTimeField("BirthDate")]
        public DateTimeField birthDate;

        // hireDate
        [DateTimeField("HireDate")]
        public DateTimeField hireDate;

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

    }
}
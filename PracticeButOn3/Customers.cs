using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PracticeButOn3 {
    class Customers : Persons {

        public string num { get; set; }

        public string GetRandomString() {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", ""); // Remove period.
            string num = path.Substring(0, 8);  // Return 8 character string
            return num;
        }

        public Customers() { }

        public Customers(string firstname, string lastname, string number) {
            FirstName = firstname;
            LastName = lastname;
            num = number;
        }

        public string GetCustomerNumber() {
            return ("Customer Number: " + GetRandomString() + " | "); ;
        }

        public void SetCustomerNumber(string number) {
            this.num = number;
        }

        public string DisplayCustomer() {
            return (GetFirstName() + GetLastName() + GetCustomerNumber());
        }


    }
}
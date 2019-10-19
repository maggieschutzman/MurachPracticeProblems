using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeButOn3 {
    class Persons {
        public string Employee { get; set; }
        public string Customer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ssn { get; set; }

        public Persons() { }

        public Persons(string FirstName, string LastName) {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }

        public string GetFirstName() {
            return ("Firstname: " + FirstName + " | ");
        }
        public void SetFirstName(string firstname) {
            this.FirstName = firstname;
        }

        public string GetLastName() {
            return ("Lastname: " + LastName + " | ");
        }

        public void SetLastName(string lastname) {
            this.LastName = lastname;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp {
    class Employees : Persons {

        public Employees() { }

        public Employees(string firstname, string lastname, string ssn) {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Ssn = ssn;
        }

        public string GetSsn() {
            return ("Social Security Number: ****-**-" + Ssn.Substring(Ssn.Length - 4));
        }

        public void SetSsn(string ssn) {
            this.Ssn = ssn;
        }

        public string DisplayEmployee() {
            return ("Current Employee \n\n") + GetFirstName() + GetLastName() + GetSsn();
        }

    }
}

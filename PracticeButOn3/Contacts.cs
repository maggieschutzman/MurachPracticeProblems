using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp {
    public class Contacts {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }



        public void SetFristName(string firstName) {
            try {
                this.firstName = firstName;
                bool isIntString = int.TryParse(firstName, out int result);
                if (isIntString == true) throw new Exception("Name can not include letters.");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        public string GetFirstName() {
            return ("Firstname: " + firstName + " | ");
        }

        public void SetLastName(string lastName) {
            try {
                this.lastName = lastName;
                bool isIntString = int.TryParse(lastName, out int result);
                if (isIntString == true) throw new Exception("Name can not include letters.");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        public string GetLastName() {
            return ("Lastname: " + lastName + " | ");
        }

        public void SetEmail(string email) {
            this.email = email;
        }

        public string GetEmail() {
            return ("Email: " + email + " | ");
        }

        public void SetPhone(string phone) {          
                this.phone = phone;                        
        }

        public string GetPhone() {
            return ("Phone: " + phone + " | ");
        }

        public string DisplayContact() {
            return ("Current Contact \n\n") + GetFirstName() + GetLastName() + GetEmail() + GetPhone();


        }
    }
}


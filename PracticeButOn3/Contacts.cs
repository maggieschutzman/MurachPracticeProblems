using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeButOn3 {
    public class Contacts {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }



        public void setFristName(string firstName) {
            this.firstName = firstName;
        }

        public string getFirstName() {
            return ("Firstname: "+firstName + " | ");
        }

        public void setLastName(string lastName) {
            this.lastName = lastName;
        }

        public string getLastName() {
            return ("Lastname: "+lastName + " | ");
        }

        public void setEmail(string email) {
            this.email = email;
        }

        public string getEmail() {
            return ("Email: "+email+" | ");
        }

        public void setPhone(string phone) {
            this.phone = phone;
        }

        public string getPhone() {
            return ("Phone: "+phone+" | ");
        }

        public string displayContact() {
            return ("Current Contact \n\n")+getFirstName() + getLastName() + getEmail() + getPhone();
            

        }
    }
}

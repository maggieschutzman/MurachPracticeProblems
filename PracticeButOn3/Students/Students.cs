using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp.Students {
    class Students {

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Score { get; set; }
        public int Number { get; set; }

        public Students(string firstname, string lastname) {
            LastName = lastname;
            FirstName = firstname;        
        }

        public Students() { }

        public void SetStudentNumber(int number) {
            Number = number;
        }

        public void SetFirstName(string firstname) {
            FirstName = firstname;
        }

        public void SetLastName(string lastname) {
            LastName = lastname;
        }

        public void SetScore(int score) {
            Score = score;
        }

        public string DisplayStudent(string firstname, string lastname, int score) {
            LastName = lastname;
            FirstName = firstname;
            Score = score;
            return ($"First Name: {firstname} Last name: {lastname} Score: {score}");

        }
    }
}

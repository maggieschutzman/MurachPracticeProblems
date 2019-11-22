﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp {
    public class Emails {

        public string Email { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }

        List<Emails> emails = new List<Emails>();

        public void LoadEmails() {
            var email1 = new Emails { First_name = "james", Last_name = "butler", Email = "jbutler@gmail.com" };
            var email2 = new Emails { First_name = "Josephine", Last_name = "Darakvy", Email = "Josephine_Darakjy@darakjy.org" };
            var email3 = new Emails { First_name = "ART", Last_name = "VENERE", Email = "ART@VENERE.ORG" };
            emails.Add(email1);
            emails.Add(email2);
            emails.Add(email3);
        
        }

        public void PrintEmails() {
            foreach (var e in emails) {
                Console.WriteLine($"The user's name is {e.First_name} {e.Last_name} and their email is {e.Email}\n\n");
                Console.WriteLine($"To:{e.Email}\n" +
                                  "From:  noreply@deals.com\n" +
                                  "Subject: Deals!\n\n" +
                                  $"Hi {e.First_name},\n\n" +
                                  "We've got some great deals for you. Check our website!");
            }
        }


    }
}

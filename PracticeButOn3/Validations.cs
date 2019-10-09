using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeButOn3 {
    class Validations {

        public string cont { get; set; }


        public Validations(string cont) {
            this.cont = cont;
            if (cont == "y") {
            return;
            }
            else Console.WriteLine("Okay, bye!");       
            Environment.Exit(33);
        }

    }
}

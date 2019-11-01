using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp {
    class Prime {

        public int Number { get; set; }
        public string Ans { get; set; }

        public void SetNumber(int number) {
            Number = number;
        }

        public int GetNumber() {
            return Number;       
        }

        public int PrimeCalc() { 
            if (Number % 1 == 0 && Number % Number == 0) {
                return 1;
            }
            else { return 0; }
        }

        public bool IsPrime() {
            if (PrimeCalc() == 1) 
                { return true; }
        else { return false; }
        }


    }
}

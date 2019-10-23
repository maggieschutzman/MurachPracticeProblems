using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeButOn3.Roshambo {
    public class Bart : Player {

        public override string GenerateRoshambo() {
            Roshambo Rosh = (Roshambo)1;
            return Rosh.ToString();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeButOn3.Roshambo {
    class Player1 : Player {


        public override string GenerateRoshambo() {
            Random rnd = new Random();
            Roshambo Rosh = (Roshambo)rnd.Next(1, 4);
            return Rosh.ToString();
        }
    }
}

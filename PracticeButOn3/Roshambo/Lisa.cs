using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PracticeButOn3.Roshambo {
    public class Lisa : Player {



        public override string GenerateRoshambo() {
            Random rnd = new Random();
            Roshambo Rosh = (Roshambo)rnd.Next(1, 4);
            return Rosh.ToString();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeButOn3.Roshambo {
    public abstract class Player {

        public string Name { get; set; }
        public Roshambo Rosh { get; set; }

        public abstract string GenerateRoshambo();

        public enum Roshambo {Rock = 1, Paper, Scissors}

        public void SetRosh(Roshambo rosh) {
            this.Rosh = rosh;
        }

        public Roshambo GetRosh() {
            return Rosh;
        }

    }
}

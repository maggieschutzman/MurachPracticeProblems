using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeButOn3.Roshambo {
    public abstract class Player {

        public string Name { get; set; }
        public Roshambo Rosh { get; set; }
        public abstract Roshambo GenerateRoshambo();
        public enum Roshambo {rock = 1, paper, scissors}
        public int Count { get; set; }


        public void SetRosh(Roshambo rosh) {
            this.Rosh = rosh;
        }

        public int DisplayCount() {
            return Count;
        }

        public Roshambo GetRosh() {
            return Rosh;
        }


        }
    }


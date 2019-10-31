using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp {
    class Circles : Shapes {

        public double Radius { get; set; }

        public Circles() { }

        public Circles(double radius) {
            this.Radius = radius;
        }

        public double GetRadius() {
            return this.Radius;
        }

        public void SetRadius(double radius) {
            this.Radius = radius;
        }

        public override double GetArea() {
            return Math.Pow(GetRadius(), 2) * Math.PI;
        }

    }
}

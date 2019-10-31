using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp {
    public class Squares : Shapes {

        public double Width { get; set; }
        public double Length { get; set; }

        public Squares() { }

        public Squares(double width) {
            this.Width = width;
        }

        public double GetWidth() {
            return Width;
        }

        public void SetWidth(double width) {
            this.Width = width;
        }

        public double getArea() {
            return Math.Pow(Width,2);
        }

        public override double GetArea() {
            throw new NotImplementedException();
        }
    }
}

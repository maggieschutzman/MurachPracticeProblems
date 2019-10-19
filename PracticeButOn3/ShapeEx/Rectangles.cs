using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeButOn3 {
    class Rectangles : Squares {

        public Rectangles() { }

        public Rectangles(double width, double length) {
            this.Width = width;
            this.Length = length;
        }

        public double GetLength() {
            return Length;
        }

        public void SetLength(double length) {
            this.Length = length;       
        }

        public override double GetArea() {
            return GetLength() * GetWidth();

        }

    }
}

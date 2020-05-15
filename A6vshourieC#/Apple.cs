using System;
using System.Collections.Generic;
using System.Text;

namespace A6vshourie
{
    // NOTE -- I CHOSE TO KEEP CLASS ON PACKAGE-LEVEL ACCESS ONLY SINCE PUBLIC DOESN'T APPEAR NECESSARY.
    class Apple
    {
        // Fields which describe the characteristics of an object of type Apple.
        private int peelThickness;
        private double percentLeft;
        private double radius;

        // Initializes the percentLeft field specially since all apples must have 100% of their entity remaining at the start.
        public Apple()
        {
            percentLeft = 100.0;
        }

        // Initializes the percentLeft field specially since all apples must have 100% of their entity remaining at the start.
        public Apple(double radius)
        {
            percentLeft = 100.0;
            SetRadius(radius);
        }

        public int GetPeelThickness()
        {
            return peelThickness;
        }

        public void SetPeelThickness(int value)
        {
            this.peelThickness = value;
        }

        public double GetPercentLeft()
        {
            return percentLeft;
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double value)
        {
            radius = value;
        }

        // Allows the user to consume the apple object, thereby reducing the amount left by the amount consumed.
        public void Eat(double eatenAmount)
        {
            percentLeft -= eatenAmount;
        }
    }
}

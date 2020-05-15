using System;
using System.Collections.Generic;
using System.Text;

namespace A6vshourie
{
    class Banana
    {
        // Various attributes of a banana of interest to the user.
        private double length;
        private int peelThickness;
        private double percentLeft;

        // The percentLeft is initialized to 100.0 because every banana must have 100% of itself if not eaten.
        public Banana()
        {
            percentLeft = 100.0;
        }

        // The percentLeft is initialized to 100.0 because every banana must have 100% of itself if not eaten.
        public Banana(double length)
        {
            percentLeft = 100.0;
            SetLength(length);
        }

        public double GetLength()
        {
            return length;
        }

        public void SetLength(double value)
        {
            length = value;
        }

        public int GetPeelThickness()
        {
            return peelThickness;
        }

        public void SetPeelThickness(int value)
        {
            peelThickness = value;
        }

        public double GetPercentLeft()
        {
            return percentLeft;
        }

        // Allows the user to consume a certain portion of the banana object, reducing the amount left.
        public void Eat(double eatenAmount)
        {
            percentLeft = percentLeft - eatenAmount;
        }
    }
}

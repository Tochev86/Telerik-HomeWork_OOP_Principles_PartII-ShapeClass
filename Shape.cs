namespace ShapeClass
{
    using System;
    public abstract class Shape
    {
        private double high;
        private double width;

        protected double High 
        { 
            get
            {
                return this.high;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The value can not be smaller or equal to 0");
                }
                this.high = value;
            }
        }
        protected double Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The value can not be smaller or equal to 0");
                }
                this.width = value;
            }
        }

        public virtual double CalculateSurface()
        {
            return this.Width * this.High;
        }
    }
}

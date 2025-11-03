namespace Lab03
{
    public class ComplexNumber : ICloneable, IEquatable<ComplexNumber>, IModular
    {
        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        private double re;
        private double im;

        public ComplexNumber(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re + c2.Re, c1.Im + c2.Im);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re - c2.Re, c1.Im - c2.Im);
        }

        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(
                c1.Re * c2.Re - c1.Im * c2.Im,
                c1.Re * c2.Im + c1.Im * c2.Re
            );
        }

        public static bool operator ==(ComplexNumber c1, ComplexNumber c2) => c1.Equals(c2);
        public static bool operator !=(ComplexNumber c1, ComplexNumber c2) => !c1.Equals(c2);

        public static ComplexNumber operator -(ComplexNumber c1) => new ComplexNumber(-c1.re, -c1.im);

        public double Modulus() => Math.Sqrt((re * re)+(im * im));

        public bool Equals(ComplexNumber? equalNumber)
        {
            if (equalNumber is null) return false;
            return this.Re == equalNumber.Re && this.Im == equalNumber.Im;
        }

        public override bool Equals(object? obj)
        {
            if (obj is ComplexNumber complexNumber)
                return Equals(complexNumber);
            return false;
        }

        public object Clone() => new ComplexNumber(this.re, this.im);
        public override int GetHashCode() => base.GetHashCode();
        public override string ToString() => $"{re} + {im}i";
    }
}

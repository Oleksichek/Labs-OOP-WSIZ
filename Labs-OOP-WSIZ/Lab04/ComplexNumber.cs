using Lab03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class ComplexNumber : ICloneable, IEquatable<ComplexNumber>, IComparable<ComplexNumber>, IModular
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

        public static bool operator >(ComplexNumber c1, ComplexNumber c2) => c1.CompareTo(c2) > 0;
        public static bool operator <(ComplexNumber c1, ComplexNumber c2) => c1.CompareTo(c2) < 0;
        public static bool operator >=(ComplexNumber c1, ComplexNumber c2) => c1.CompareTo(c2) >= 0;
        public static bool operator <=(ComplexNumber c1, ComplexNumber c2) => c1.CompareTo(c2) <= 0;

        public double Modulus() => Math.Sqrt((re * re) + (im * im));

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

        public int CompareTo(ComplexNumber? compareNumber)
        {
            if (compareNumber is null) return 1;
            return Modulus().CompareTo(compareNumber.Modulus());
        }

        public object Clone() => new ComplexNumber(this.re, this.im);
        public override int GetHashCode() => HashCode.Combine(re, im);
        public override string ToString()
        {
            string sign = im >= 0 ? "+" : "-";
            return $"{re} {sign} {Math.Abs(im)}i";
        }
    }
}

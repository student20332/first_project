using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.lesson_1
{
    class Fraction
    {
        int sign;
        int intpart;
        int numerator;
        int denominator;


        public Fraction()
        {
            this.sign = 1;
            this.intpart = 0;
            this.numerator = 0;
            this.denominator = 1;
        }

        public Fraction(int n, int d, int i = 0, int s = 1)
        {
            this.sign = s;
            this.intpart = i;
            this.numerator = n;
            this.denominator = d;
            this.GetMixedView();
        }

        void GetMixedView()
        {
            this.GetIntPart();
            this.CancelLation();
        }
        void CancelLation()
        {
            if (this.numerator != 0) {
                int m = this.denominator,
                    n = this.numerator,
                    ost = m%n;

                while (ost != 0) {
                    m = n;
                    n = ost;
                    ost = m % n;
                }

                int nod = n;

                if (nod != 1) {
                    this.numerator /= nod;
                    this.denominator /= nod;
                }
            }
        }
        void GetIntPart()
        {
            if (this.numerator >= denominator) {
                this.intpart += this.numerator / this.denominator;
                this.numerator %= this.denominator;
            }
        }

        public ~Fraction()
        {
            Console.WriteLine("Дробь" + this + "уничтожена!");
        }
    }
}

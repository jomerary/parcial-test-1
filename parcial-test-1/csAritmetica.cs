using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_test_1
{
    class csAritmetica
    {
        private double numero1;
        private double numero2;
        private double numero3;
        private double numero4;
        private double numero5;

        public csAritmetica(double num1, double num2, double num3, double num4, double num5)
        {
            this.numero1 = num1;
            this.numero2 = num2;
            this.numero3 = num3;
            this.numero4 = num4;
            this.numero5 = num5;
        }

        public void setNumero1(double num1)
        {
            this.numero1 = num1;
        }

        public void setNumero2(double num2)
        {
            this.numero2 = num2;
        }
        public void setNumero3(double num3)
        {
            this.numero3 = num3;
        }
        public void setNumero4(double num4)
        {
            this.numero4 = num4;
        }

        public void setNumero5(double num5)
        {
            this.numero5 = num5;
        }

        public double getNumero1()
        {
            return numero1;
        }
        public double getNumero2()
        {
            return numero2;
        }
        public double getNumero3()
        {
            return numero3;
        }
        public double getNumero4()
        {
            return numero4;
        }

        public double getNumero5()
        {
            return numero5;
        }
        public double calcularMediaAritmetica()
        {
            return (numero1 + numero2 + numero3 + numero4 + numero5) / 5;
        }
        public double calcularModa()
        {
            List<double> numeros = new List<double> { numero1, numero2, numero3, numero4, numero5 };
            return numeros.GroupBy(n => n).OrderByDescending(g => g.Count()).First().Key;
        }
    }
}
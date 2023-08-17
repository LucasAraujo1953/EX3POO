using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3POO
{
    internal class Quadrado
    {
        private double diagonal;

        public Quadrado(double diagonal)
        {
            this.diagonal = diagonal;
        }

        public double CalcularArea()
        {
            double lado = diagonal / Math.Sqrt(2);
            double area = lado * lado;
            return area;
        }

    }
}
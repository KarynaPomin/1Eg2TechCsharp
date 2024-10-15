
using System;

namespace fasada3
{
    internal class Program
    {
        interface Car 
        {
            void build();
        }

        class Chevrolet : Car 
        {
            public void build() { }
        }

        class BMW : Car 
        {
            public void build () { }
        }

        class Renault : Car
        {
            public void build () { }
        }

        class FasadeForCar
        {
            Car BMW;
            Car Renault;
            Car Chevrolet;
            FasadeForCar() { }

            public void buildBMW () { }
            public void buildChevrolet() { }
            public void buildRenault() { }
        }

        static void Main(string[] args)
        {
        }
    }
}

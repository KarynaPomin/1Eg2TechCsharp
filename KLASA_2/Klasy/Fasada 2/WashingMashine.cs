using System;

namespace washing
{
    internal class Program
    {
        class Washing
        {
            public void wash() { }
        }

        class Rining
        {
            public void rins() { }
        }

        class Spining
        {
            public void spin() { }
        }

        class WashingMashine
        {
            Washing w;
            Rining r;
            Spining s;

            public void StarWashing() { }
            public void InicjujPraniePralko(Washing wa, Rining ri, Spining sp) 
            {
                w = wa;
                r = ri;
                s = sp;
            }
        }

        class Klient
        {
            WashingMashine wm;
            public void SetWashingMashine(WashingMashine washingMashine)
            {
                wm = washingMashine;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}

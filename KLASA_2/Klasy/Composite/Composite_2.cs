using System;
using System.Collections.Generic;


namespace Kompozyt
{
    internal class Program
    {
        interface IWęzeł
        {
            string Nazwa { get; set; }
            void wyświetl();
        }
        class Plik : IWęzeł
        {
            public string Nazwa { get; set; }

            public void wyświetl() 
            {
                Console.WriteLine("--" + Nazwa);
            }
        }
        class Katalog : IWęzeł
        {
            List<IWęzeł> węzły = new List<IWęzeł>();
            public string Nazwa { get; set; }

            public void wyświetl()
            {
                Console.WriteLine(Nazwa);
                foreach (var item in węzły)
                {
                    Console.Write("--");
                    item.wyświetl();
                }
            }
            public void dodaj(IWęzeł w)
            {
                węzły.Add(w);
            }
        }
        static void Main(string[] args)
        {
            Plik z1 = new Plik();
            z1.Nazwa = "foto1";
            Plik z2 = new Plik();
            z2.Nazwa = "foto2";
            Katalog k1 = new Katalog();
            k1.Nazwa = "Zdjęcia";
            k1.dodaj(z1);
            k1.dodaj(z2);

            Plik p1 = new Plik();
            p1.Nazwa = "praca1";
            Katalog k2 = new Katalog();
            k2.Nazwa = "Prace";
            k2.dodaj(p1);

            Plik r1 = new Plik();
            r1.Nazwa = "różne1";
            Plik g2 = new Plik();
            g2.Nazwa = "grafika2";
            Katalog k3 = new Katalog();
            k3.Nazwa = "Różne";
            k3.dodaj(r1);
            k3.dodaj(g2);

            Katalog d1 = new Katalog();
            d1.Nazwa = "Dysk";
            d1.dodaj(k1);
            d1.dodaj(k2);
            d1.dodaj(k3);

            d1.wyświetl();

            Console.ReadKey();

        }
    }
}

// Dysk
// --Zdjęcia
// ----foto1
// ----foto2
// --Prace
// ----praca1
// --Różne
// ----różne1
// ----grafika2


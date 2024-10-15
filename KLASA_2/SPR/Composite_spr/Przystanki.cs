using System;
using System.Collections.Generic;

namespace compositeis_yaaah
{
    internal class Program
    {
        class Miasto
        {
          // NIE DOKOŃCZONY
            public string NazwaMiasta { get; set; }
            public string PunktCentralny { get; set; }            
            List<Autobus> ListaAutobusy = new List<Autobus>();

            public void WyswietkKomunikacje()
            {
                Console.WriteLine(NazwaMiasta);
                Console.WriteLine("Punkt centralny: " + PunktCentralny);
                foreach (var autobus in ListaAutobusy)
                {
                    Console.Write("-");
                    autobus.WyswietlTrase();
                }
            }
            
            public void DodajAutobus(Autobus autobus) // z wyjeżdżają z punktu 
            {
                ListaAutobusy.Add(autobus);
            } 

        }

        interface IPrzystanki
        {
            string Nazwa { get; set; }
            bool CzyPosiadaBiletomat { get; set; }
            bool CzyPosiadaZadaszenie { get; set; }

            List<Autobus> ListaAutobusy { get; set; }

            void WyswietlInformacje();
        }

        class Przystanek : IPrzystanki 
        {
            public enum Typ
            {
                przesiadkowy,
                naZadanie,
                zwykly
            }

            public string Nazwa { get; set; }
            public bool CzyPosiadaBiletomat { get; set; }
            public bool CzyPosiadaZadaszenie { get; set; }
            public string  PrzystanekKoncowy { get; set; }
            public Typ Typy { get; set; }
            public List<Przystanek> ListaPrzestanki { get; set; }
            public List<Autobus> ListaAutobusy { get; set; }

            public void WyswietlInformacje()
            {
                Console.WriteLine(Nazwa);
                Console.WriteLine($"--- Biletomat: {(CzyPosiadaBiletomat ? "Tak" : "Nie")}");
                Console.WriteLine($"--- zadaszenie: {(CzyPosiadaZadaszenie ? "Tak" : "Nie")}");
                Console.WriteLine($"--- Typ: {Typy}");
            }
        }

        class Autobus 
        {
            public string Numer { get; set; }
            public Przystanek Petla { get; set; }
            public List<Przystanek> ListaPrzestanki = new List<Przystanek>();

            public void WyswietlTrase() 
            {
                Console.WriteLine(Numer);
                foreach (var przestanek in ListaPrzestanki)
                {
                    Console.Write("--");
                    przestanek.WyswietlInformacje();
                }
            }

            public void DodajPrzestanek(Przystanek przystanek)
            {
                ListaPrzestanki.Add(przystanek);
            }

            public void DodajPrzestanekKoncowy(Przystanek przystanek)
            {
                ListaPrzestanki.Add(przystanek);
            }
        }


        static void Main(string[] args)
        {
            Miasto miasto = new Miasto();
            miasto.NazwaMiasta = "Nowy Binar";
            miasto.PunktCentralny = "Punkt Binar";

            // Przystanki
            Przystanek p1 = new Przystanek();
            p1.Nazwa = "Główny Binar";
            p1.CzyPosiadaZadaszenie = false;
            p1.CzyPosiadaBiletomat = true;
            p1.Typy = Przystanek.Typ.zwykly;
                        
            Przystanek p2 = new Przystanek();
            p2.Nazwa = "Binaria";
            p2.CzyPosiadaZadaszenie = true;
            p2.CzyPosiadaBiletomat = true;
            p2.Typy = Przystanek.Typ.naZadanie;

            Przystanek p3 = new Przystanek();
            p3.Nazwa = "KOP";
            p3.CzyPosiadaZadaszenie = false;
            p3.CzyPosiadaBiletomat = false;
            p3.Typy = Przystanek.Typ.przesiadkowy;
            

            Przystanek p4 = new Przystanek();
            p4.Nazwa = "Petla Ta";
            p4.CzyPosiadaZadaszenie = false;
            p4.CzyPosiadaBiletomat = true;
            p4.Typy = Przystanek.Typ.zwykly;

            Autobus a1 = new Autobus();
            a1.Numer = "a23";
            a1.DodajPrzestanek(p1);
            a1.DodajPrzestanek(p2);
            a1.DodajPrzestanek(p3);
            a1.DodajPrzestanekKoncowy(p4);



            Przystanek p5 = new Przystanek();
            p5.Nazwa = "Muzyczny";
            p5.CzyPosiadaZadaszenie = true;
            p5.CzyPosiadaBiletomat = true;
            p5.Typy = Przystanek.Typ.przesiadkowy;


            Przystanek p6 = new Przystanek();
            p6.Nazwa = "Petla Ta Druga";
            p6.CzyPosiadaZadaszenie = true;
            p6.CzyPosiadaBiletomat = true;
            p6.Typy = Przystanek.Typ.zwykly;

            Autobus a2 = new Autobus();
            a2.Numer = "a23";
            a2.DodajPrzestanek(p5);
            a2.DodajPrzestanekKoncowy(p6);

            miasto.DodajAutobus(a1);
            miasto.DodajAutobus(a2);

            miasto.WyswietkKomunikacje();

            Console.ReadKey();
        }

    }
}

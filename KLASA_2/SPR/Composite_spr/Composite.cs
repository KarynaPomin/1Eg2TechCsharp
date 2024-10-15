using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karyna_Pomin
{
    internal class Program
    {

        // Zad 1
        interface Roboty
        {
            string Robota { get; set; }
            void planuj();
            void dzialaj(string zadanie);
        }

        class Rekin : Roboty
        {
            public string Robota { get; set; }
            public void planuj() { }
            public void dzialaj(string zadanie) { }

            private string Imie { get; set; }
            private string Nazwisko { get; set; }

            protected void dobierzNarzedzia(string narzedzie) { }

        }

        class Leszcz : Roboty
        {
            public string Robota { get; set; }
            public void planuj() { }
            public void dzialaj(string zadanie) { }

            private string Imie { get; set; }
            private string Odmiana { get; set; }

            protected void wymyslajWymowki() { }
            private void czekaj() { }
            public void udawaj() { }
        }

        class Gracz : Roboty
        {
            public string Robota { get; set; }
            public void planuj() { }
            public void dzialaj(string zadanie) { }

            private string Imie { get; set; }
            private int Poziom { get; set; }

            protected void ideGrac() { }
            private void jem() { }
            private bool wydalam(bool czyPrawda) 
            {
                return czyPrawda;
            }

            protected char znowIdeGrac(char c) 
            {
                return c;
            }


            class Klasa
            {
                Roboty r;

                public string numerKlasy { get; set; }
                protected List<Roboty> ListaRobotnych = new List<Roboty>();

                public void DodajDoListy(Roboty robot)
                {
                    ListaRobotnych.Add(robot);
                }
            }

            class Technikum
            {
                private string nazwa { get; set; }               
                public string podajNazwe { get; set; }
            }

            class Szkola
            {
                private string kraj { get; set; }
                public List<Szkola> Szkoly = new List<Szkola>();
                private string szkola(string nazwa)
                {
                    return nazwa;
                }
                public void stworzSzkole(Szkola s) 
                {
                    Szkoly.Add(s);
                }
            }

        }


        // Zad 2
        interface PunktCentralny
        {
            string NazwaPrzystanku { get; set; }
            void WyswietlPrzystanek(PunktCentralny nazwa);
        }

        class Przystanek : PunktCentralny
        {
            public string NazwaPrzystanku { get; set; }
            List<PunktCentralny> przestanki = new List<PunktCentralny>();

            public void DodajPrzystanek(PunktCentralny nazwa)
            {
                przestanki.Add(nazwa);
            }

            public void WyswietlPrzystanek(PunktCentralny nazwa)
            {
                Console.WriteLine(NazwaPrzystanku);

                foreach (var p in nazwa.NazwaPrzystanku)
                {
                    Console.WriteLine("--" + przestanki);
                }
            }
        }

        class Przesiadkowy : Przystanek
        {
            string NazwaPrzystanku { get; set; }
            public void WyswietlPrzystanek(PunktCentralny nazwa)
            {
                Console.WriteLine(NazwaPrzystanku);
            }
        }

        class NaZadanie : Przystanek
        {
            string NazwaPrzystanku { get; set; }
            public void WyswietlPrzystanek(PunktCentralny nazwa)
            {
                Console.WriteLine(NazwaPrzystanku);
            }
        }

        class Zwykly : Przystanek
        {
            string NazwaPrzystanku { get; set; }
            public void WyswietlPrzystanek(PunktCentralny nazwa)
            {
                Console.WriteLine(NazwaPrzystanku);
            }
        }

        class Petla : Przystanek
        {
            string NazwaPrzystanku { get; set; }
            public void WyswietlPrzystanek(PunktCentralny nazwa)
            {
                Console.WriteLine(NazwaPrzystanku);
            }
        }

        class Autobusy
        {
            string NumerAutobusu { get; set; }
        }

        static void Main(string[] args)
        {
            Przystanek G = new Przystanek();
            G.NazwaPrzystanku = "Główny";

            Przystanek pr1 = new Przystanek();
            pr1.NazwaPrzystanku = "Punkt centralny";
            Zwykly z1 = new Zwykly();
            z1.NazwaPrzystanku = "zwykły";
            pr1.DodajPrzystanek(z1);
            Petla p1 = new Petla();
            p1.NazwaPrzystanku = "petla";
            pr1.DodajPrzystanek(p1);

            G.DodajPrzystanek(pr1);
            G.WyswietlPrzystanek(pr1);

            Console.ReadKey();
        }
    }
}

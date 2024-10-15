using System;
using System.Collections.Generic;

namespace compositeis_yaaah
{
    internal class Program
    {
        interface IPrzystanki
        {
            string NazwaPrzystanku { get; set; }
            void Wyswietl();
        }

        class Miasto
        {
            public string NazwaMiasta {  get; set; }
            List<Przystanek> ListaPrzystanki = new List<Przystanek>();

            public void WyświetlKomunikacje()
            {
                Console.WriteLine(NazwaMiasta);
                foreach (var przystanek in ListaPrzystanki)
                {
                    Console.Write("--");
                    przystanek.Wyswietl();
                }
            }

            public void DodajPrzystanek(Przystanek nazwaPrzystanka)
            {
                ListaPrzystanki.Add(nazwaPrzystanka);
            }
        }

        class Przystanek : IPrzystanki
        {
            public string NazwaPrzystanku { get; set; }
            List<Autous> ListaAutobusow = new List<Autous>();

            public void Wyswietl()
            {
                Console.WriteLine(NazwaPrzystanku);
                foreach (var autobus in ListaAutobusow)
                {
                    Console.Write("--");
                    autobus.Wyswietl();
                }
            }

            public void DodacPrzystanek(Autous nazwaAutobusu) 
            {
                ListaAutobusow.Add(nazwaAutobusu);
            }       
        }

        class Autous : IPrzystanki
        {
            public string NazwaPrzystanku { get; set; }

            public void Wyswietl()
            {
                Console.WriteLine("--" + NazwaPrzystanku);
            }
        }

        static void Main(string[] args)
        {
            Miasto miasto1 = new Miasto();
            miasto1.NazwaMiasta = "Binaria Land";

            Przystanek p1 = new Przystanek();
            p1.NazwaPrzystanku = "Binar Główny";
            Autous autous1 = new Autous();
            autous1.NazwaPrzystanku = "A18";
            Autous autous2 = new Autous();
            autous2.NazwaPrzystanku = "A10";
            Autous autous3 = new Autous();
            autous3.NazwaPrzystanku = "A9";
            p1.DodacPrzystanek(autous1);
            p1.DodacPrzystanek(autous2);
            p1.DodacPrzystanek(autous3);
            miasto1.DodajPrzystanek(p1);

            Przystanek p2 = new Przystanek();
            p2.NazwaPrzystanku = "Dębinar PKP";
            Autous autous4 = new Autous();
            autous4.NazwaPrzystanku = "B8";
            Autous autous5 = new Autous();
            autous5.NazwaPrzystanku = "A0";
            Autous autous6 = new Autous();
            autous6.NazwaPrzystanku = "B19";
            p2.DodacPrzystanek(autous4);
            p2.DodacPrzystanek(autous5);
            p2.DodacPrzystanek(autous6);
            miasto1.DodajPrzystanek(p2);

            Miasto miasto2 = new Miasto();
            miasto2.NazwaMiasta = "Niebinar";

            Przystanek p3 = new Przystanek();
            p3.NazwaPrzystanku = "Niebinar Główny";
            Autous autous7 = new Autous();
            autous7.NazwaPrzystanku = "B78";
            Autous autous8 = new Autous();
            autous8.NazwaPrzystanku = "B90";
            Autous autous9 = new Autous();
            autous9.NazwaPrzystanku = "C32";
            p3.DodacPrzystanek(autous7);
            p3.DodacPrzystanek(autous8);
            p3.DodacPrzystanek(autous9);
            miasto2.DodajPrzystanek(p3);

            miasto1.WyświetlKomunikacje();
            miasto2.WyświetlKomunikacje();

            Console.ReadKey();
        }

    }
}

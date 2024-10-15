using System;
using System.Collections.Generic;

namespace UML_spr
{
    interface IRobotny
    {
        string Robota { get; set; }
        void planuj();
        void dzialaj(Zadanie z);
    }

    class Rekin : IRobotny
    {
        public string Robota { get; set; }
        void IRobotny.planuj(){}
        public void dzialaj(Zadanie z){}

        string Imie;
        string Nazwisko;
        public Rekin(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        protected void DobierzNarzedzie(Narzedzie n) {
            Console.WriteLine($"Wybrano narzędzie: {n.PodajNarzedzie()}");
        }

    }

    class Leszcz : IRobotny
    {
        public string Robota { get; set; }
        public void planuj() { }
        public void dzialaj(Zadanie z) { }

        string Imie;
        string Odmiana;
        public Leszcz(string imie, string odmiana)
        {
            Imie = imie;
            Odmiana = odmiana;
        }

        protected void WymyslajWymowki() {
            Console.WriteLine("Wymyślam wymówkę...");
        }
        private void Czekaj()
        {
            Console.WriteLine("Czekaj...");
        }

        public void Udawaj()
        {
            Console.WriteLine("Udaję, że umarłem.");
        }     
    }

    class Gracz : IRobotny
    {
        public string Robota { get; set; }
        public void planuj() { }
        public void dzialaj(Zadanie z) { }

        public string Imie;
        public int Poziom;

        protected void IdeGrac() { }
        private void Jem() { }
        private bool Wydalam() 
        {
            Console.WriteLine("Gracz wydala...");
            return true;
        }
        protected char ZnowIdeGrac(char c) 
        {
            return c;   
        }
    }

    class Klasa {
        Teknikum t;

        public string NumerKlasy;
        protected List<IRobotny> ListaRobotnych = new List<IRobotny>();

        public void DodajDoListy(IRobotny r)
        {
            ListaRobotnych.Add(r);
        }
    }

    public class Teknikum
    {
        private string Nazwa;
        private string Kraj;

        public void PodajNazwe(string nazwa)
        {
            Nazwa = nazwa;
        }
    }

    public class Szkola
    {
        private string Kraj;

        private Szkola(string kraj) 
        {
            Kraj = kraj;
        }
        public void StworzSzkole() { }
    }


    class Narzedzie
    {
        string NazwaNarzedzia;

        public Narzedzie(string nazwaNarzedzia)
        {
            NazwaNarzedzia = nazwaNarzedzia;
        }

        public string PodajNarzedzie()
        {
            return NazwaNarzedzia;
        }
    }

    class Zadanie
    {
        string TrescZadania;

        public Zadanie (string trescZadania)
        {
            TrescZadania = trescZadania;
        }

        public string PodajZadanie()
        {
            return TrescZadania;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

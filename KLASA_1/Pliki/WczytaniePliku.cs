using System;
using System.IO;

namespace study
{
    class Program
    {
        static void Main()
        {
            string path = @"C:\Users\Karyna\Downloads\1Eg2TechCsharp-main\1Eg2TechCsharp-main\Zadania\Zad. 4\liczby_przyklad.txt";
            StreamWriter sw;

            if (!File.Exists(path)) // negacja !
            {
                sw = File.CreateText(path);
                Console.WriteLine("Plik został utworzony!");
            }
            else
            {
                sw = new StreamWriter(path, true); // true wypisywanie dannych nie tracąc ich
                Console.WriteLine("Plik został otworty!");
            }
            // WPISANIE TEKSTU DO PLIKU
            //Console.WriteLine("Podaj tekst: "); 
            //string tekst = Console.ReadLine();
            //sw.WriteLine(tekst);
            sw.Close();

            StreamReader sr = File.OpenText(path);
            string s = "";
            int i = 1;
            Console.WriteLine("\nZAWARTOŚĆ PLIKU: ");
            while((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(i++ + ". " + s);
            }
            sr.Close();

            Console.ReadKey();
        }
    }
}

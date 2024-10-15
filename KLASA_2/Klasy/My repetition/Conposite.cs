using System;
using System.Collections.Generic;

namespace uml_spr
{
    internal class Program
    {
        // Zespoły muzyczne
        interface IMusicalBands
        {
            string NameBand { get; set; }
            void Show();
        }

        // Nazwa grupy
        class BandName : IMusicalBands
        {
            List<IMusicalBands> Songs = new List<IMusicalBands>();
            public string NameBand { get; set; }
            public void Show()
            {
                Console.WriteLine(NameBand);
                foreach (var song in Songs)
                {
                    Console.Write("--");
                    song.Show();
                }
            }
            public void AddSong(IMusicalBands s)
            {
                Songs.Add(s);
            }
        }

        // Ulubione piosenki
        class Song : IMusicalBands
        {
            public string NameBand { get; set; }
            public string NameSong { get; set; }
            public void Show()
            {
                Console.WriteLine("--" + NameSong);
            }
        }

        static void Main(string[] args)
        {
            BandName myOwnListOfBand = new BandName();
            myOwnListOfBand.NameBand = "MY OWN LIST OF BANDS";

            BandName b1 = new BandName();
            b1.NameBand = "Finger Eleven"; 
            Song s1 = new Song();
            s1.NameSong = "Paralyzer";
            b1.AddSong(s1);

            BandName b2 = new BandName();
            b2.NameBand = "Sable";
            Song s2 = new Song();
            s2.NameSong = "Just Dance";
            b2.AddSong(s2);
            Song s3 = new Song();
            s3.NameSong = "Chrome";
            b2.AddSong(s3);
            Song s4 = new Song();
            s4.NameSong = "The Grim Reaper";
            b2.AddSong(s4);

            BandName b3 = new BandName();
            b3.NameBand = "Motionless In White";
            Song s5 = new Song();
            s5.NameSong = "Another Live";
            b3.AddSong(s5);
            Song s6 = new Song();
            s6.NameSong = "</c0de>";
            b3.AddSong(s6);

            myOwnListOfBand.AddSong(b1);
            myOwnListOfBand.AddSong(b2);
            myOwnListOfBand.AddSong(b3);

            myOwnListOfBand.Show();

            Console.ReadKey();
        }
    }
}

using System;

namespace fasada_4
{
    internal class Program
    {
        abstract class GameAI
        {
            protected void attack() 
            {
                buildStructures();
                buildUnits();
                sendScourts();
                sendWarriors();
            }
            public abstract void buildStructures();
            public abstract void buildUnits();
            public abstract void sendScourts();
            public abstract void sendWarriors();
            public virtual void takeTurn() { }
            public virtual void collectResurses() { }
        }

        class OrcsAI : GameAI 
        {
            public override void buildStructures() { }
            public override void buildUnits() { }
            public override void sendScourts() { }
            public override void sendWarriors() { }
        }

        class MonstersAI : GameAI
        {

            public override void buildStructures() { }
            public override void buildUnits() { }
            public override void sendScourts() { }
            public override void sendWarriors() { }
        }


        static void Main(string[] args)
        {
        }
    }
}

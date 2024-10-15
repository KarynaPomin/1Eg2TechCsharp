using System;
using System.Collections.Generic;

namespace Composite1
{
    internal class Program
    {
        // + --> publiczna
        // - --> prywatna

        // <<>> --> kompozycje
        // <> --> agregacje (geter, seter)
        // >> --> dziedziczenie
        // > --> asocjacje

        public abstract class Component 
        {
            // abstract --> pochyloną czcionką
            public abstract void operation();
        }

        public class Leaf : Component
        {
            public override void operation(){}
        }


        public class Composite : Component 
        {
            public List<Component> components = new List<Component>();

            public override void operation() { }

            public void add() { }
            public void remove() { }
            public void getChild() { }
        }

        static void Main(string[] args)
        {
        }
    }
}

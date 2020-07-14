using Lab06_Zoo.cs;
using System;

namespace Lab06_Zoo.cs
{
    public class Program
    {

        static void Main(string[] args)
        {
            AnimalsExample();
        }




        static void AnimalsExample()
        {
            Tiger myTiger = new Tiger();
            Lion myLion = new Lion();
            Rhino myRhino = new Rhino();
            Panda myPanda = new Panda();
            Gorrilla myGorrila = new Gorrilla();
            Lemur myLemur = new Lemur();

            Console.WriteLine(myTiger.Sleep());
            Console.WriteLine(myLion.Sleep());
            Console.WriteLine(myRhino.Sleep());
            Console.WriteLine(myPanda.Sleep());
            Console.WriteLine(myGorrila.Sleep());
            Console.WriteLine(myLemur.Sleep());




        }



    }
}

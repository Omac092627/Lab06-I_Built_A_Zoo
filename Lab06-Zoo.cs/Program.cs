using Lab06_Zoo.cs;
using System;

namespace Lab06_Zoo.cs
{
    public class Program
    {

        static void Main(string[] args)
        {
            TigerExample();
            TigerGames();
            RhinoExample();
            RhinoHunt();
            PandaExample();
            LionExample();
            LemurExample();
            GorillaExample();

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
            Console.WriteLine(myTiger.SoundOfAnimals());


            Console.WriteLine(myLion.Sleep());
            Console.WriteLine(myLion.WhereDoILive());


            Console.WriteLine(myRhino.Sleep());
            Console.WriteLine(myPanda.Sleep());
            Console.WriteLine(myGorrila.Sleep());
            Console.WriteLine(myLemur.Sleep());



        }

        public static string TigerExample()
        {
            Tiger myTiger = new Tiger();
            Console.WriteLine(myTiger.WhereDoILive());
            return "";
        }

        public static string TigerGames()
        {
            Tiger myTiger = new Tiger();
            Console.WriteLine(myTiger.FavoriteGames());
            return "";
        }


        public static string RhinoExample()
        {
            Rhino myRhino = new Rhino();
            Console.WriteLine(myRhino.RhinoNoise());
            return "";
        }

        public static string RhinoHunt()
        {
            Rhino myRhino = new Rhino();
            Console.WriteLine(myRhino.LikeToHunt());
            return myRhino.LikeToHunt();
        }

        public static string PandaExample()
        {
            Panda myPanda = new Panda();
            Console.WriteLine(myPanda.PandasEat());
            return "";
        }

        public static string LionExample()
        {
            Lion myLion = new Lion();
            Console.WriteLine(myLion.LionsYawn());
            return "";
        }

        public static string LemurExample()
        {
            Lemur myLemur = new Lemur();
            Console.WriteLine(myLemur.Zaboomafu());
            return "";
        }

        public static string GorillaExample()
        {
            Gorrilla myGorilla = new Gorrilla();
            Console.WriteLine(myGorilla.ScaryGorilla());
            return "";
        }
    }
}

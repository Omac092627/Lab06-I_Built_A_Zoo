using System;
using System.Collections.Generic;
using System.Text;




namespace Lab06_Zoo.cs
{
    public abstract class Animals
    {



        public string Name { get; set; }
        public string Type { get; set; }
        public string Eat { get; set; }
        public string Sound { get; set; }
        public abstract string Land { get; set; }

        public abstract string Games { get; set; }

        public virtual string Size { get; set; }

        public virtual string Furry { get; set; }




        // methods



        public virtual string SoundOfAnimals()
        {
            //  Console.WriteLine($"{Name} makes this {Sound}");

            return $"{Name} makes this {Sound}";
        }

        public virtual string WhereDoILive()
        {
            //  Console.WriteLine($"{Name} lives in {Land}");
            return $"{Name} lives in {Land}";
        }

        public abstract string FavoriteGames();

        public abstract string LikeToHunt();



    }


}

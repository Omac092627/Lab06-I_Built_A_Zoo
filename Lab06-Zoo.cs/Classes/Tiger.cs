using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Tiger : Feline
    {
        public override string Land { get; set; }
        public override string Games { get; set; }

        public override string Size { get => base.Size; set => base.Size = value; }
        public override string Furry { get => base.Furry; set => base.Furry = value; }

        public Tiger()
        {
            Name =  "Tiger" ;
            Eat =  "Bloody Meat" ;
            Sound = "Rawr!";
            Land = "Jungle";
            Games = "strings and ropes";
            Size = "freaking huge";
            Furry = "kind of fur";

        }

        public string TigerDance()
        {
            return $"{Name}'s dance when they can.";
        }

        public string TigerBathe()
        {
            return $"{Name}'s bathe in rivers";
        }


        public override string SoundOfAnimals()
        {
            return $"{Name} actually makes the sound {Sound}";
        }

        public override string WhereDoILive()
        {
            return $"{Name} lives in the {Land} and these Tigers are {Size}";
        }


        public override string FavoriteGames()
        {
            return $"{Name}'s like to play with {Games}";

        }

        public override string LikeToHunt()
        {
            return $"{Name}'s like to hunt at night and they're also {Furry}";
        }

       
    }
}

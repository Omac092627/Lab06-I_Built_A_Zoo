using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Gorrilla : Primate
    {
        public override string Land { get; set; }
        public override string Games { get; set; }
        public override string Size { get => base.Size; set => base.Size = value; }
        public override string Furry { get => base.Furry; set => base.Furry = value; }


        public Gorrilla()
        {
            Name =   "Gorilla" ;
            Sound =  "OOOh ahh ah" ;
            Eat =   "Bananas" ;
            Land = "Jungle";
            Games = "pounding on chest";
            Size = "ubquitous";
            Furry = "very furry";
        }

        public string ScaryGorilla()
        {
            return $"{Name}'s are super strong and scary and their size is {Size}!";
        }

        public string GorillaLanguages()
        {
            return $"{Name}'s can communicate in sign language";
        }

        public override string SoundOfAnimals()
        {
            return $"{Name} actually makes the sound {Sound} and they're also {Furry}!";
        }

        public override string WhereDoILive()
        {
            return $"{Name} lives in the {Land}";
        }

        public override string FavoriteGames()
        {
            return $"{Name}'s like to play with {Games}";

        }

        public override string LikeToHunt()
        {
            return $"{Name}'s like to hunt for fruit";
        }
    }
}

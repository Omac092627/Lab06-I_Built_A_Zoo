using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Lemur : Primate
    {
        public override string Land { get; set; }
        public override string Games { get; set; }
        public override string Size { get => base.Size; set => base.Size = value; }
        public override string Furry { get => base.Furry; set => base.Furry = value; }


        public Lemur()
        {
            Name =  "Lemur" ;
            Sound =   "OOOh ahh ah" ;
            Eat =  "Bananas" ;
            Land = "Jungle";
            Games = "swinging in trees";
            Size = "very small";
            Furry = "their whole body is furry";
        }

        public string Zaboomafu()
        {
            return $"{Name}'s were on the show Zaboomafu and they're {Size}";
        }

        public override string SoundOfAnimals()
        {
            return $"{Name} actually makes the sound {Sound}!";
        }

        public override string WhereDoILive()
        {
            return $"{Name} lives in the {Land} and {Furry}";
        }

        public override string FavoriteGames()
        {
            return $"{Name}'s like to play with {Games}";

        }

        public override string LikeToHunt()
        {
            return $"{Name}'s like to hunt in trees";
        }
    }
}

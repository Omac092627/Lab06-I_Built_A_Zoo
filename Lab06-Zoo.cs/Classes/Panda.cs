using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Panda : Bears
    {
        public override string Land { get; set; }
        public override string Games { get; set; }

        public override string Size { get => base.Size; set => base.Size = value; }
        public override string Furry { get => base.Furry; set => base.Furry = value; }


        public Panda()
        {
            Name =  "Panda" ;
            Sound = "Rawr!" ;
            Eat = "Bamboo" ;
            Land = "Jungle";
            Games = "Sleeping";
            Size = "large";
            Furry = "lots of fur";
        }

        public string PandasEat()
        {
            return $"{Name}'s sit on their butts and eat bamboo all day!";
        }

        public override string SoundOfAnimals()
        {
            return $"{Name} actually makes the sound {Sound}!";
        }

        public override string WhereDoILive()
        {
            return $"{Name} lives in the {Land} and have {Furry}";
        }

        public override string FavoriteGames()
        {
            return $"{Name}'s like to play with {Games}";

        }

        public override string LikeToHunt()
        {
            return $"{Name}'s like to hunt never but look how {Size} they are!";
        }
    }
}

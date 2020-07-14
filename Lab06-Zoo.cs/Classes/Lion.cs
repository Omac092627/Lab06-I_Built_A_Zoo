using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Lion : Feline
    {
        public override string Land { get; set; }
        public override string Games { get; set; }
        public override string Size { get => base.Size; set => base.Size = value; }
        public override string Furry { get => base.Furry; set => base.Furry = value; }


        public Lion()
        {
            Name =  "Lion" ;
            Sound =  "Rawr" ;
            Eat = "Bloody Meat" ;
            Land = "Saharra";
            Games = "strings and ropes";
            Size = "pretty big";
            Furry = "lots of fur";
        }

        public string LionsYawn()
        {
            return $"{Name}'s hunt and then just yawn all day and they're also {Size}";
        }

        public override string SoundOfAnimals()
        {
            return $"{Name} actually makes the sound {Sound}!";
        }

        public override string WhereDoILive()
        {
            return $"{Name} lives in the {Land} and they're also have {Furry}";
        }

        public override string FavoriteGames()
        {
            return $"{Name}'s like to play with {Games}";

        }

        public override string LikeToHunt()
        {
            return $"{Name}'s like to hunt all day err day";
        }
    }
}


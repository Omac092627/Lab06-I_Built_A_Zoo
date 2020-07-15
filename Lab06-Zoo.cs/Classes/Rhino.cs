using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Rhino : Mammals
    {

        public override string Land { get; set; }
        public override string Games { get; set; }
        public override string Size { get => base.Size; set => base.Size = value; }
        public override string Furry { get => base.Furry; set => base.Furry = value; }

        public Rhino()
        {
            Name =  "Rhino" ;
            Sound =  "Brrrsh!" ;
            Eat =  "Grass" ;
            Land = "Grasslands";
            Games = "Ball";
            Size = "enormous";
            Furry = "no fur at all";
        }

        public string RhinoNoise()
        {
            return $"{Name}'s blast off with their horns!";
        }

        public string RhinoHornClean()
        {
            return $"{Name}'s clean their horns once a month.";
        }

        public override string SoundOfAnimals()
        {
            return $"{Name} actually makes the sound {Sound}!";
        }

        public override string WhereDoILive()
        {
            return $"{Name} lives in the {Land}";
        }
        public string FavoirteGames()
        {
            return $"{Name}'s like to play with {Games}";
        }

        public override string FavoriteGames()
        {
            return $"{Name}'s like to play with {Games}";

        }

        public override string LikeToHunt()
        {
            return $"{Name}'s like to hunt during the day and they're not only {Size} they have {Furry}";
        }
    }
}

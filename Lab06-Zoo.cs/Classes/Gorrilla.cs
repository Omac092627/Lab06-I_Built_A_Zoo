using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Gorrilla : Primate
    {
        public override string Land { get; set; }

        public Gorrilla()
        {
            Name =   "Gorilla" ;
            Sound =  "OOOh ahh ah" ;
            Eat =   "Bananas" ;
            Land = "Jungle";
        }

        public string ScaryGorilla()
        {
            return $"{Name}'s are super strong and scary!";
        }

        public override string SoundOfAnimals()
        {
            return $"{Name} actually makes the sound {Sound}!";
        }

        public override string WhereDoILive()
        {
            return $"{Name} lives in the {Land}";
        }
    }
}

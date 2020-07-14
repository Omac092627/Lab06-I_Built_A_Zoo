using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Lemur : Primate
    {
        public override string Land { get; set; }

        public Lemur()
        {
            Name =  "Lemur" ;
            Sound =   "OOOh ahh ah" ;
            Eat =  "Bananas" ;
            Land = "Jungle";
        }

        public string Zaboomafu()
        {
            return $"{Name}'s were on the show Zaboomafu";
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

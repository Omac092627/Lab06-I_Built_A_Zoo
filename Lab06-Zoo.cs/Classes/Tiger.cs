using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Tiger : Feline
    {
        public override string Land { get; set; }


        public Tiger()
        {
            Name =  "Tiger" ;
            Eat =  "Bloody Meat" ;
            Sound = "Rawr!";
            Land = "Jungle";

        }

        public string TigerDance()
        {
            return $"{Name}'s dance when they can.";
        }

        public override string SoundOfAnimals()
        {
            return $"{Name} actually makes the sound {Sound}";
        }

        public override string WhereDoILive()
        {
            return $"{Name} lives in the {Land}";
        }



    }
}

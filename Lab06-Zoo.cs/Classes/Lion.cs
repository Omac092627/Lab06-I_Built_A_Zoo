using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Lion : Feline
    {
        public override string Land { get; set; }

        public Lion()
        {
            Name =  "Lion" ;
            Sound =  "Rawr" ;
            Eat = "Bloody Meat" ;
            Land = "Saharra";
        }

        public string LionsYawn()
        {
            return $"{Name}'s hunt and then just yawn all day";
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


using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Panda : Bears
    {
        public override string Land { get; set; }

        public Panda()
        {
            Name =  "Panda" ;
            Sound = "Rawr!" ;
            Eat = "Bamboo" ;
            Land = "Jungle";
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
            return $"{Name} lives in the {Land}";
        }
    }
}

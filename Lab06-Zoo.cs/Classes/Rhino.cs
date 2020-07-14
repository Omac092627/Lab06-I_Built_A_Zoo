using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public class Rhino : Mammals
    {

        public override string Land { get; set; }

        public Rhino()
        {
            Name =  "Rhino" ;
            Sound =  "Brrrsh!" ;
            Eat =  "Grass" ;
            Land = "Grasslands";
        }

        public string RhinoNoise()
        {
            return $"{Name}'s blast off with their horns!";
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

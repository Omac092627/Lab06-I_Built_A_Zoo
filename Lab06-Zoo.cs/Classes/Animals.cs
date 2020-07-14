using System;
using System.Collections.Generic;
using System.Text;



/*Have at least 3 different abstract classes
Have at least 3 layers of inheritance
Have at least 5 concrete animals
Have at least 2 abstract methods(make sure you override them)
Have at least 2 abstract Properties(make sure you override them)
Have at least 2 virtual methods(make sure you override at least one of them)
Have at least 2 virtual properties(make sure you override at least one of them)
Your(digital) drawing of your zoo diagram should be clearly labeled*/


namespace Lab06_Zoo.cs
{
    public abstract class Animals
    {



        public string Name { get; set; }
        public string Type { get; set; }
        public string Eat { get; set; }
        public string Sound { get; set; }
        public abstract string Land {get; set;}


        // methods




            public string Sleep()
            {
              //  Console.WriteLine($"{Name} goes to sleep");

            return $"{Name} goes to sleep";
                
            }


            
        public virtual string SoundOfAnimals()
        {
          //  Console.WriteLine($"{Name} makes this {Sound}");

            return $"{Name} makes this {Sound}";
        }

        public virtual string WhereDoILive()
        {
          //  Console.WriteLine($"{Name} lives in {Land}");
           return $"{Name} lives in {Land}";
        }



        }


    }

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.cs
{
    public abstract class Animals
    {



            public string Name { get; set; }
            public string Type { get; set; }
            public string Eat { get; set; }
            public string Sound { get; set; }


        // methods


        public string Breathe(string name)
        {
            return null;
        }




        // OrderPizza
        public Animals CallAnimal(string animalName)
            {
                Animals animal = null;


            if((animalName == "Tiger") || (animalName == "Lion") || (animalName =="Rhino") || (animalName == "Panda") || (animalName == "Gorrilla") || (animalName == "Lemur"))
            {

                animal = new Tiger();
                animal = new Lion();
                animal = new Rhino();
                animal = new Panda();
                animal = new Gorrilla();
                animal = new Lemur();
            }

                return animal;
            }



            // OpenProcedures

        /*
            public void ManageHours(bool storeOpen)
            {

                if (storeOpen)
                {
                    IsOpen = true;
                    OpenProcedure();
                    string message = "store is open";
                    Console.WriteLine(message);

                }

                IsOpen = false;
                ClosingProcedure();
            }

            public void OpenProcedure()
            {

                Console.WriteLine("These are all the things that we need to do to open");
            }

        */

            public string Sleep()
            {
                Console.WriteLine($"{Name} goes to sleep");

            return $"{Name} goes to sleep";
                
            }

        



        }


    }

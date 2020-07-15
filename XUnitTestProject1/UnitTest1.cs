using System;
using Lab06_Zoo.cs;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        /// <summary>
        /// Test's for Tiger
        /// </summary>




        [Fact]
        public bool TigerBath()
        {
            Tiger testTiger = new Tiger();
            string result = testTiger.TigerBathe();
            string expected = "Tiger's bathe in rivers";
            Assert.Equal(expected, result);

            return true;
        }

   
        [Fact]
        public bool DanceTiger()
        {
            Tiger testTiger = new Tiger();
            string result = testTiger.TigerDance();
            string expected = "Tiger's dance when they can.";
            Assert.Equal(expected, result);

            return true;
        }



        /// <summary>
        /// Test's for rhinos
        /// </summary>

        [Fact]
        public void RhinoHornCleaning()
        {
            Rhino testRhino = new Rhino();
            string result = testRhino.RhinoHornClean();
            string expected = "Rhino's clean their horns once a month.";
            Assert.Equal(expected, result);
        }

        [Fact]
        public bool RhinoBlast()
        {
            Rhino testRhino = new Rhino();
            string result = testRhino.RhinoNoise();
            string expected = "Rhino's blast off with their horns!";
            Assert.Equal(expected, result);

            return true;
        }


        /// <summary>
        /// Panda Tests
        /// </summary>
        /// <returns></returns>

        [Fact]

        public bool PandaPanda()
        {
            Panda testPanda = new Panda();
            string result = testPanda.PandasEat();
            string expected = "Panda's sit on their butts and eat bamboo all day!";
            Assert.Equal(expected, result);

            return true;
        }

        [Fact]
        public void WhatUpPanda()
        {
            Panda testPanda = new Panda();
            string result = testPanda.PandasUpTo();
            string expected = "Panda's up to eating bamboo.";
            Assert.Equal(expected, result);

        }

        /// <summary>
        /// Lion test
        /// </summary>
        /// <returns></returns>



        [Fact]
        public bool LionYas()
        {
            Lion testLion = new Lion();
            string result = testLion.LionsYawn();
            string expected = "Lion's hunt and then just yawn all day and they're also pretty big";
            Assert.Equal(expected, result);

            return true;
        }


        [Fact]
        public void LionsMane()
        {
            Lion testLion = new Lion();
            string result = testLion.LionMane();
            string expected = "Lion's have a really big mane!";
            Assert.Equal(expected, result);

        }



        /// <summary>
        /// Lemur's test
        /// </summary>
        /// <returns></returns>

        [Fact]
        public bool Lemurs()
        {
            Lemur testLemur = new Lemur();
            string result = testLemur.Zaboomafu();
            string expected = "Lemur's were on the show Zaboomafu and they're very small";
            Assert.Equal(expected, result);

            return true;
        }


        [Fact]
        public void FamousLemurs()
        {
            Lemur testLemur = new Lemur();
            string result = testLemur.LemurOnAvatar();
            string expected = "Lemur's were also on the show Avatar the Last Airbender";
            Assert.Equal(expected, result);

        }

        /// <summary>
        /// Gorilla test
        /// </summary>
        /// <returns></returns>

        [Fact]
        public bool GorillaWatch()
        {
            Gorrilla testGorilla = new Gorrilla();
            string result = testGorilla.ScaryGorilla();
            string expected = "Gorilla's are super strong and scary and their size is ubquitous!";
            Assert.Equal(expected, result);

            return true;

        }

        [Fact]
        public void GorillaSpeak()
        {
            Gorrilla testGorilla = new Gorrilla();
            string result = testGorilla.GorillaLanguages();
            string expected = "Gorilla's can communicate in sign language";
            Assert.Equal(expected, result);

        }






    }
}

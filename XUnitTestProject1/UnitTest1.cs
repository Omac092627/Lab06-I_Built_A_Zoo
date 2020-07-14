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
        public void TigerSleep()
        {
            Tiger testTiger = new Tiger();
            string result = testTiger.Sleep();
            string expected = "Tiger goes to sleep";
            Assert.Equal(expected, result);
        }

        [Fact]
        public bool TigerSound()
        {
            Tiger testTiger = new Tiger();
            string result = testTiger.SoundOfAnimals();
            string expected = "Tiger actually makes the sound Rawr!";
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
        public void RhinoSleep()
        {
            Rhino testRhino = new Rhino();
            string result = testRhino.Sleep();
            string expected = "Rhino goes to sleep";
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
        public void PandaSleep()
        {
            Panda testPanda = new Panda();
            string result = testPanda.Sleep();
            string expected = "Panda goes to sleep";
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
            string expected = "Lion's hunt and then just yawn all day";
            Assert.Equal(expected, result);

            return true;
        }


        [Fact]
        public void LionSleep()
        {
            Lion testLion = new Lion();
            string result = testLion.Sleep();
            string expected = "Lion goes to sleep";
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
            string expected = "Lemur's were on the show Zaboomafu";
            Assert.Equal(expected, result);

            return true;
        }


        [Fact]
        public void LemurSleep()
        {
            Lemur testLemur = new Lemur();
            string result = testLemur.Sleep();
            string expected = "Lemur goes to sleep";
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
            string expected = "Gorilla's are super strong and scary!";
            Assert.Equal(expected, result);

            return true;

        }

        [Fact]
        public void GorillaSleep()
        {
            Gorrilla testGorilla = new Gorrilla();
            string result = testGorilla.Sleep();
            string expected = "Gorilla goes to sleep";
            Assert.Equal(expected, result);

        }






    }
}

using System;
using Lab06_Zoo.cs;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
      


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
        public void RhinoSleep()
        {
            Rhino testRhino = new Rhino();
            string result = testRhino.Sleep();
            string expected = "Rhino goes to sleep";
            Assert.Equal(expected, result);

        }

        [Fact]
        public void PandaSleep()
        {
            Panda testPanda = new Panda();
            string result = testPanda.Sleep();
            string expected = "Panda goes to sleep";
            Assert.Equal(expected, result);

        }


        [Fact]
        public void LionSleep()
        {
            Lion testLion = new Lion();
            string result = testLion.Sleep();
            string expected = "Lion goes to sleep";
            Assert.Equal(expected, result);

        }


        [Fact]
        public void LemurSleep()
        {
            Lemur testLemur = new Lemur();
            string result = testLemur.Sleep();
            string expected = "Lemur goes to sleep";
            Assert.Equal(expected, result);

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

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




    }
}

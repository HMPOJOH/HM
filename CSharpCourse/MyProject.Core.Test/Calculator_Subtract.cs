using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Core.Test
{
    [TestClass]
    public class Calculator_Subtract
    {
        [TestMethod]
        public void should_return__minus_8_when_substracting_8()
        {
            // Arrange
            var c = new Calculator();

            // Act
            c.Subtract("8");

            // Assert
            int result = c.GetValue();
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void should_return__minus_3_when_substracting_3()
        {
            // Arrange
            var c = new Calculator();

            // Act
            c.Subtract("3");

            // Assert
            int result = c.GetValue();
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void should_still_return__minus_25_even_if_some_data_are_strange()
        {
            // Arrange
            var c = new Calculator();
            
            // Act
            c.Subtract("5");
            c.Subtract("17");
            c.Subtract("aaaaa");
            c.Subtract("bbbb");
            c.Subtract("3");
            c.Subtract("cccc");

            // Assert
            int result = c.GetValue();
            Assert.AreEqual(-25, result);
        }

        [TestMethod]
        public void should_return_4_after_some_stuff()
        {
            // Arrange
            var c = new Calculator();

            // Act
            c.Add("7");
            c.Add("aaaaaaaaaaaaaaa");
            c.Subtract("3");
            c.Subtract("aaaaaaaaaaaaaaa");

            // Assert
            int result = c.GetValue();
            Assert.AreEqual(4, result);
        }
    }
}

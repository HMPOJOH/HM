using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Core.Test
{
    [TestClass]
    public class Calculator_Add
    {
        [TestMethod]
        public void should_return_5_when_adding_5()
        {
            // Arrange
            var c = new Calculator();

            // Act
            c.Add("5");

            // Assert
            int result = c.GetValue();
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void should_return_25_when_adding_5_17_3()
        {
            // Arrange
            var c = new Calculator();

            // Act
            c.Add("5");
            c.Add("17");
            c.Add("3");

            // Assert
            int result = c.GetValue();
            Assert.AreEqual(25, result);
        }


        [TestMethod]
        public void should_still_return_25_even_if_some_data_are_strange()
        {
            // Arrange
            var c = new Calculator();

            // Act
            c.Add("5");
            c.Add("17");
            c.Add("aaaaa");
            c.Add("bbbb");
            c.Add("3");
            c.Add("cccc");

            // Assert
            int result = c.GetValue();
            Assert.AreEqual(25, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;

namespace PingPong.Tests
{
    [TestClass]
    public class NumberTests 
    {
      [TestMethod]
      public void NumberConstructor_CreatesInstanceOfNumber_Number()
      {
          // Arrange
          int userInput = 15;
      
          // Act
          Number newNumber = new Number(userInput);
      
          // Assert
          Assert.AreEqual(typeof(Number), newNumber.GetType());
      }
    }
}

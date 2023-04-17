using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;
using System.Collections.Generic;

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
      [TestMethod]
    public void CreatePingPongList_ReturnsPingPongList_List()
    {
        // Arrange
        int userInput = 15;
        Number number = new Number(userInput);
        List<string> expectedList = new List<string>
        {
            "1",
            "2",
            "ping",
            "4",
            "pong",
            "ping",
            "7",
            "8",
            "ping",
            "pong",
            "11",
            "ping",
            "13",
            "14",
            "ping-pong"
        };
    
        // Act
        List<string> actualList = number.CreatePingPongList();
    
        // Assert
        CollectionAssert.AreEqual(expectedList, actualList);
    }
    }
}

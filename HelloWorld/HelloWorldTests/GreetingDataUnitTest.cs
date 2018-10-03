using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using HelloWorldController.Modules;
using HelloWorldController.Models;
using Moq;


namespace HelloWorldTests
{
    [TestClass]
    public class GreetingDataUnitTest
    {

        /// <summary>
        ///     Mock of the FileLogger
        /// </summary>
        private Mock<IFileLog> fileLoggerMock;

        IGreetingData greetingData;

        GreetingModel expectedResult;

        [TestInitialize]
        public void InitTestSuite()
        {
            this.fileLoggerMock = new Mock<IFileLog>();
            expectedResult = new GreetingModel();
            this.greetingData = new GreetingData(this.fileLoggerMock.Object);
        }


        [TestMethod]
        public void TestGreetingMessagePositiveScenario()
        {
            //Arrange your data

            //Arrange 
            const string filePath = "abc/samplepath";
            const string fileContent = "Hello World";            

            //Create dependencies
            this.fileLoggerMock.Setup(m => m.ReadFile(filePath)).Returns(fileContent);            

            expectedResult.greetingMessage = "Hello World";
            
            //Act
           GreetingModel gm = greetingData.GetGreetingMsg();

            //Assert
            Assert.AreEqual(expectedResult.greetingMessage, gm.greetingMessage);
        }



    }

        
    
}

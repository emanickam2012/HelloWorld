using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldController.Models;

namespace HelloWorldController.Modules
{
    public class GreetingData: IGreetingData
    {

        GreetingModel greeting = new GreetingModel();

        /// <summary>
        /// Inject File Log which contains the message to be written
        /// </summary>
        private readonly IFileLog fileLog;

        public GreetingData(IFileLog fileLog)
        {
            this.fileLog = fileLog;
        }

        public GreetingData()
        {

        }

        public GreetingModel GetGreetingMsg()
        {
            greeting.greetingMessage = "Hello World";
            return greeting;
        }



    }
}

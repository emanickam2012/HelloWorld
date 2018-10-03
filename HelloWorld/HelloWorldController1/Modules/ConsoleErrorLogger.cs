using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldController.Models;

namespace HelloWorldController.Modules
{
    public class ErrorLogger: IErrorLogger
    {
       /// <summary>
       /// Display error message in console
       /// </summary>
       /// <param name="errorMessage"></param>
        public void DisplayErrorMessage(string errorMessage)
        {
            Console.WriteLine("DisplayErrorMessage:" + errorMessage);
        }

        /// <summary>
        /// Display error status description
        /// </summary>
        /// <param name="errorDescription"></param>
        public void DisplayErrorStatusDescription (string errorDescription)
        {
            Console.WriteLine("DisplayErrorDescription: " + errorDescription);
        }



    }
}

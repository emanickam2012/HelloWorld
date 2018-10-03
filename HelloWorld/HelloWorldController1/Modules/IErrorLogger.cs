using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldController.Modules
{
    /// <summary>
    ///   Interface for logging errors to the application
    /// </summary>
    public interface IErrorLogger
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorMessage"></param>
        void DisplayErrorMessage(string errorMessage);

        /// <summary>
        /// Display error description
        /// </summary>
        /// <param name="errorDescription"></param>
        void DisplayErrorStatusDescription(string errorDescription); 



    }
}

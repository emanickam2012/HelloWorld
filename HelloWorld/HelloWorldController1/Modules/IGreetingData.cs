using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldController.Models;

namespace HelloWorldController.Modules
{
    public interface IGreetingData
    {
                  
        GreetingModel GetGreetingMsg();
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Configuration;
using RestSharp;
using HelloWorldController.Models;
using HelloWorldController.Modules;
using LightInject;
using Newtonsoft.Json;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retrieve url path of HelloWorldAPI
            string urlPath = ConfigurationManager.AppSettings["HelloWorldAPIURL"];

            //Resolve instance of Interface
            var container = new LightInject.ServiceContainer();
            container.Register<IErrorLogger, ErrorLogger>();
            var logger = container.GetInstance<IErrorLogger>();

            IFileLog fileLog = new FileLogger();

            var client = new RestClient(urlPath);

            try
            {
                //Execute the API Call
                IRestResponse response = client.Execute<List<HelloWorldController.Models.GreetingModel>>(new RestRequest());

                if (response != null)
                {
                    if (response.Content != null)
                    {
                        GreetingModel dataReceived = new GreetingModel();
                        dataReceived = JsonConvert.DeserializeObject<GreetingModel>(response.Content);
                        Console.WriteLine(dataReceived.greetingMessage);

                        Console.Read();

                    }
                    else
                    {
                        var errorMsg = "Error occured in restSharp. Error Message: " + response.ErrorMessage +
                                           "Error Status Description: " + response.StatusDescription;
                        
                        //Log the error. 
                        fileLog.WriteToFile(errorMsg);
                    }


                }

            }
            catch (Exception ex)
            {
                // Log the exception
                logger.DisplayErrorMessage(ex.InnerException.ToString());


            }
        }
    }
}

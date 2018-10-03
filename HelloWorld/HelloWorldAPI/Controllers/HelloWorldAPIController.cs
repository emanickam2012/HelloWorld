using HelloWorldAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorldController.Modules;


namespace HelloWorldAPI.Controllers
{
    public class HelloWorldAPIController : ApiController
    {
        public readonly GreetingData myGreeting;
        public HelloWorldAPIController()
        {
            this.myGreeting = new GreetingData();
        }
       
        // GET: api/HelloWorldAPI
        public HelloWorldController.Models.GreetingModel Get()
        {
            return myGreeting.GetGreetingMsg();
        }


        // GET: api/HelloWorldAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HelloWorldAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/HelloWorldAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HelloWorldAPI/5
        public void Delete(int id)
        {
        }
    }
}

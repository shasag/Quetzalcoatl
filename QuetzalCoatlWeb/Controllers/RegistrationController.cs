using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuetzalCoatlWeb.DAL;

namespace QuetzalCoatlWeb.Controllers
{
    public class RegistrationController : ApiController
    {
        public string Get()
        {
            //var queryItems = Request.RequestUri.ParseQueryString();
            //// get the customer info from get() call
            //string name = queryItems["name"].ToString();
            //string surname = queryItems["surname"].ToString();
            //string email = queryItems["email"].ToString();
            //string username = queryItems["username"].ToString();
            //string password = queryItems["password"].ToString();

            ////call the DB to insert into Customer table 
            //UserDAL.InsertUserInfo(name, surname, email, username, password);
            // return "Success"; 

            return "Success";

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]dynamic value)
        {
            // get the customer info from post() call
            string name = value.name.Value;
            string surname = value.surname.Value;
            string email = value.email.Value;
            string username = value.username.Value;
            string password = value.password.Value;

            //call the DB to insert into Customer table 
            UserDAL.InsertUserInfo(name, surname, email, username, password);

            return "Success";
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

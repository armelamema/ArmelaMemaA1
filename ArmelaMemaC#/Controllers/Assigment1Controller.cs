using System;
using System.Web.Http;

namespace ArmelaMemaA1.Controllers
{
    public class Assignment1Controller : ApiController
    {
        // Returns 10 more than the input.
        [HttpGet]
        [Route("api/AddTen/{id}")]
        public IHttpActionResult AddTen(int id)
        {
            int result = id + 10;
            return Ok(result);
        }

        // Returns the square of the input.
        [HttpGet]
        [Route("api/Square/{id}")]
        public IHttpActionResult Square(int id)
        {
            int result = id * id;
            return Ok(result);
        }

        // Returns "Hello World!".
        [HttpPost]
        [Route("api/Greeting")]
        public IHttpActionResult Greeting()
        {
            return Ok("Hello World!");
        }

        // specified number of people.
        [HttpGet]
        [Route("api/Greeting/{id}")]
        public IHttpActionResult Greeting(int id)
        {
            string result = $"Greetings to {id} people!";
            return Ok(result);
        }

        // mathematical operations to the input number.
        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public IHttpActionResult NumberMachine(int id)
        {
            int add = id + 10;
            int subtract = id - 5;
            int multiply = id * 2;
            double divide = id / 2.0; 

            string result = $"Add 10: {add}, Subtract 5: {subtract}, Multiply by 2: {multiply}, Divide by 2: {divide}";
            return Ok(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace contacts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public Person[] Get()
        {
            Person p1 = new Person(1, "Matt", 40);
            Person p2 = new Person(2, "Sally", 32);
            Person p3 = new Person(3, "Zagthrop", 834);
            // Console.WriteLine(p1.name);
            return new Person[] { p1, p2, p3 };
        }
    }
}

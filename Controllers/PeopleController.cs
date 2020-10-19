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
        // public Person[] Get()
        public Person[] Get()
        {
            using (var db = new PeopleContext())
            {
                // Console.WriteLine("Hello World!");
                // db.Add(new Person { Name = "Matt", Age = 40 });
                // db.SaveChanges();

                // var person = db.People
                var people = db.People
                    .OrderBy(person => person.PersonId)
                    // .Last();
                    .ToArray();
                // Console.WriteLine(person.Age);
                // Console.WriteLine(db.People.OrderBy(person => person.PersonId).ToArray());

                // return person;
                return people;
            }
            // Person p1 = new Person(1, "Matt", 40);
            // Person p2 = new Person(2, "Sally", 32);
            // Person p3 = new Person(3, "Zagthrop", 834);
            // // Console.WriteLine(p1.name);
            // return new Person[] { p1, p2, p3 };
        }

        [HttpDelete]
        [Route("{term}")]
        public Person[] Delete(int term)
        {
            using (var db = new PeopleContext())
            {
                var deletedPerson = new Person { PersonId = term };
                db.People.Remove(deletedPerson);
                db.SaveChanges();

                var people = db.People
                    .OrderBy(person => person.PersonId)
                    .ToArray();
                return people;

            }
        }
    }
}

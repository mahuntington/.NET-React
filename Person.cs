using System;

namespace contacts
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public Person(int idParam, string nameParam, int ageParam)
        {

            this.id = idParam;
            this.name = nameParam;
            this.age = ageParam;
        }
    }
}

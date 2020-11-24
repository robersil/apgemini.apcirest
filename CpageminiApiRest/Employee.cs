using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CpageminiApiRest
{
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String Position { get; set; }

        public Employee(int id, string name, string lastName, string position)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.Position = position;
        }

    }
}

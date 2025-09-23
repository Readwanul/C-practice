using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_S
{
    class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        private string occupation { get; set; }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
            occupation = "Unemployed";
        }

        public string checkAdult()
        {
            BirthDate = BirthDate.AddYears(18);
            if (BirthDate <= DateTime.Now)
                return "Adult";
            else
                return "Not Adult";
        }
        public string setoccupation(string job)
        {
            occupation = job;
            return occupation;
        }
    }
}

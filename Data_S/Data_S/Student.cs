using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_S
{
    class Student : Person
    {
        public int StudentID { get; set; }
        public string Major { get; set; }
        public Student(string name, DateTime birthDate, int studentID, string major)
            : base(name, birthDate)
        {
            StudentID = studentID;
            Major = major;
            setoccupation("Student");
        }

        public string getoccupation
        {
            get { return setoccupation("Student"); }
        }


    }
}

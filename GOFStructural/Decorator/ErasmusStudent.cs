using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class ErasmusStudent : INeptunUser
    {
        Student student;
        public ErasmusStudent(Student student, string anotherUniversity, DateTime returnDate)
        {
            this.student = student;
            this.AnotherUniversity = anotherUniversity;
            this.ReturnDate = returnDate;
        }
        public double Mark { get => student.Mark; set => student.Mark = value; }
        public string Name { get => student.Name; set => student.Name = value; }
        public string NeptunCode { get => student.NeptunCode; set => student.NeptunCode = value; }

        public string AnotherUniversity { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}

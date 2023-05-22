using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Person
    {
        public Person()
        {
            this.Name = "n/a";
            this.BirthDate = new DateTime(1, 1, 1);
            this.Siblings = new List<Person>();
            this.Parents = new List<Person>();
            this.WorkPlace = "n/a";
            this.CertificateNumber = 0;
        }
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public List<Person> Siblings { get; set; }

        public List<Person> Parents { get; set; }

        public string WorkPlace { get; set; }

        public int CertificateNumber { get; set; }
    }
}

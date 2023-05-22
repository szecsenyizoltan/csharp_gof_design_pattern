using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class PersonBuilder
    {
        public Person Person { get; set; }

        public PersonBuilder()
        {
            Person = new Person();
        }

        public PersonBuilder SetupNameAndBirthDate(string name, DateTime birthDate)
        {
            this.Person.Name = name;
            this.Person.BirthDate = birthDate;
            return this;
        }

        public PersonBuilder SetupWorkPlace(string workPlace)
        {
            this.Person.WorkPlace = workPlace;
            return this;
        }

        public PersonBuilder SetupCertificateNumber(int certificateNumber)
        {
            this.Person.CertificateNumber = certificateNumber;
            return this;
        }

        public PersonBuilder AddSibling(Person sibling)
        {
            this.Person.Siblings.Add(sibling);
            return this;
        }

        public PersonBuilder AddParent(Person parent)
        {
            this.Person.Parents.Add(parent);
            return this;
        }

    }
}

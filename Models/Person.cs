using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Person.Models
{
    public class Person
    {
        public string Fname;
        public string Lname;
        public int Age;
        public string Mail;

        public Person(string Fname, string Lname, int Age, string Mail)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.Age = Age;
            this.Mail = Mail;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Models.Entity
{
    public class Student:IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public DateTime birthdate { get; set; }
        public double gpa { get; set; }

    }
}
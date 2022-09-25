using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application.Models
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public string Profession { get; set; }
        public bool SoftDelete { get; set; }
    }
}

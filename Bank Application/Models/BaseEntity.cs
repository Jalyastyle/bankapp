using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application.Models
{
    public class BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool SoftDelete { get; set; }
    }
}

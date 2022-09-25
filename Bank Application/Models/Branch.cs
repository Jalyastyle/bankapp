using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application.Models
{
    public class Branch : BaseEntity
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Budget { get; set; }
        public List<Employee> employees { get; set; }
        public bool SoftDelete { get; set; }
    }
}

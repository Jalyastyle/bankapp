using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application.Models
{
    public class Manager : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

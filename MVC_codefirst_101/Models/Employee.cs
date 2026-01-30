using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_codefirst_101.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
    }
}
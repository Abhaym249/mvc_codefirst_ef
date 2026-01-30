using MVC_codefirst_101.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_codefirst_101.Data
{
    public class ApplicationdbContext:DbContext
    {
        public ApplicationdbContext():base("Constr")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
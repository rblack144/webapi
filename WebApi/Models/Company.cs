using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public List<Department> Departments { get; set; }
    }
}

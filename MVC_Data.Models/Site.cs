using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Data.Models
{
    public class Site
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public string SiteName { get; set; }

        public List<Employee> Employees { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Data.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string Dpt_Name { get; set; }

        public List<Employee> Employees { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Data.Models.ViewModels
{
   public class EmployeeVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage =" Enter Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter a department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage ="Enter Address")]
        public string Address { get; set; }

        public string DepartmentName { get; set; }

        public string SiteName { get; set; }
    }
}

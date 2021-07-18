using MVCCourse210710.Resources;
using MVCCourse210710.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCourse210710.ViewModels
{
    public class BatchEditViewModel
    {
        [Required]
        public int DepartmentID { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = "Department_Name_Required")]
        public string Name { get; set; }

        [Required]
        [BudgetRange(0, 99)]
        public decimal Budget { get; set; }
        
        [Required]
        public System.DateTime StartDate { get; set; }
    }
}
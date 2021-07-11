using MVCCourse210710.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCourse210710.ViewModels
{
    public class DepartmentCreate
    {
        [Required(ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = "Department_Name_Required")]
        public string Name { get; set; }
        [Range(0, 99999, ErrorMessage = "請輸入合理的預算範圍 ({1} ~ {2})")]
        public decimal Budget { get; set; }

        [UIHint("InstructorID")]
        public Nullable<int> InstructorID { get; set; }
    }
}
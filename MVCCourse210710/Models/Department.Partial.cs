namespace MVCCourse210710.Models
{
    using MVCCourse210710.Resources;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department
    {
    }

    public partial class DepartmentCreateMetaData
    {
        [Required(ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = "Department_Name_Required")]
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = "請輸入合理的預算範圍 ({1} ~ {2})")]
        public decimal Budget { get; set; }
        [UIHint("InstructorID")]
        public Nullable<int> InstructorID { get; set; }
    }

    public partial class DepartmentEditMetaData : DepartmentCreateMetaData
    {
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime StartDate { get; set; }
    }
    public partial class DepartmentMetaData : DepartmentEditMetaData
    {
        public int DepartmentID { get; set; }
    }

}

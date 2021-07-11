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
    
    public partial class DepartmentMetaData
    {
        [Required]
        public int DepartmentID { get; set; }

        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required(ErrorMessageResourceType = typeof(Resource1), 
            ErrorMessageResourceName = "Department_Name_Required")]
        public string Name { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "請輸入合理的預算 ({1} ~ {2})")]
        public decimal Budget { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime StartDate { get; set; }
        [UIHint("InstructorID")] 
        public Nullable<int> InstructorID { get; set; }
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

    public partial class DepartmentEditMetaData
    {
        [Required(ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = "Department_Name_Required")]
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = "請輸入合理的預算範圍 ({1} ~ {2})")]
        public decimal Budget { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime StartDate { get; set; }

        [UIHint("InstructorID")]
        public Nullable<int> InstructorID { get; set; }
    }
}

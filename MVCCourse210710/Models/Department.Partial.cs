namespace MVCCourse210710.Models
{
    using MVCCourse210710.Resources;
    using MVCCourse210710.ValidationAttributes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (HasDirtyWord(Name))
            {
                yield return new ValidationResult("名稱不能包含髒話", new string[] { "Name" });
            }
        }

        private bool HasDirtyWord(string name)
        {
            if (name.Contains("Fxxx"))
            {
                return true;
            }

            return false;
        }
    }

    public partial class DepartmentCreateMetaData
    {
        [Required(ErrorMessageResourceType = typeof(Resource1), ErrorMessageResourceName = "Department_Name_Required")]
        //[是否為身份證字號]
        public string Name { get; set; }
        //[Range(0, 100, ErrorMessage = "請輸入合理的預算範圍 ({1} ~ {2})")]
        //[BudgetRange(minValue: 10, maxValue: 1000)]
        [BudgetRange]
        public decimal Budget { get; set; }
        [UIHint("InstructorID")]
        public Nullable<int> InstructorID { get; set; }
    }

    public partial class DepartmentEditMetaData : DepartmentCreateMetaData
    {
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public System.DateTime StartDate { get; set; }
    }
    public partial class DepartmentMetaData : DepartmentEditMetaData
    {
        public int DepartmentID { get; set; }
    }

}

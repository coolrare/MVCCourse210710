namespace MVCCourse210710.Models
{
    using MVCCourse210710.ValidationAttributes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CourseMetaData))]
    public partial class Course
    {
    }
    
    public partial class CourseMetaData
    {
        [Required]
        public int CourseID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [DisplayName("課程名稱")]
        public string Title { get; set; }
        [Required]
        [DisplayName("課程評價")]
        [UIHint("Stars")]
        public Credits Credits { get; set; }
        [Required]
        public int DepartmentID { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}

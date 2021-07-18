namespace MVCCourse210710.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(PersonMetaData))]
    public partial class Person
    {
        [ReadOnly(true)]
        public string DisplayName
        {
            get { return this.FirstName + " " + this.LastName; }
        }
    }

    public partial class PersonMetaData
    {
        [Required]
        public int ID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string LastName { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string FirstName { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
        
        [StringLength(128, ErrorMessage="欄位長度不得大於 128 個字元")]
        [Required]
        public string Discriminator { get; set; }
    
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
        public virtual ICollection<Course> Course { get; set; }
    }
}

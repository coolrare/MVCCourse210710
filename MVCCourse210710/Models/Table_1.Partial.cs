namespace MVCCourse210710.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Table_1MetaData))]
    public partial class Table_1
    {
    }
    
    public partial class Table_1MetaData
    {
        [Required]
        public int ID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string Name { get; set; }
    }
}

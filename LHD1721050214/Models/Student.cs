namespace LHD1721050214.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        [StringLength(20)]
        [Display(Name = "Mã học sinh")]
        public string PersonID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên học sinh")]
        public string PersonName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Trường")]
        public string University { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
    }
}

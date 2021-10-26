namespace LHD1721050214.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("person")]
    public partial class person
    {
        [StringLength(20)]
        [Display(Name = "ID")]
        public string PersonID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Họ tên")]
        public string PersonName { get; set; }
    }
}

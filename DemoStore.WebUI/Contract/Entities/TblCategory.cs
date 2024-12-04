using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoStore.WebUI
{
    public partial class TblCategory
    {
        [Required]
        [Key]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string? CategoryName { get; set; }

        public bool? CategoryStatus { get; set; }

        public virtual ICollection<TblProduct> Categories { get; set; } = new HashSet<TblProduct>();
    }
}

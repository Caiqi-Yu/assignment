namespace assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Articles
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Ratings { get; set; }

        [Column(TypeName = "date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }

        public int UploadId { get; set; }
    }
}

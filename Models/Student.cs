namespace assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public object UserId { get; internal set; }
    }
}

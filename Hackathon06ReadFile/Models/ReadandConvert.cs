namespace Hackathon06ReadFile.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReadandConvert")]
    public partial class ReadandConvert
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TickNumber { get; set; }

        public DateTime Flyingfay { get; set; }

        public DateTime Birthday { get; set; }
    }
}

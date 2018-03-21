namespace Hackathon02FuelsRecord.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FuelRecord")]
    public partial class FuelRecord
    {
        public int Id { get; set; }

        public double Liter { get; set; }

        public double Kilometer { get; set; }

        public DateTime RefuelingDate { get; set; }
    }
}

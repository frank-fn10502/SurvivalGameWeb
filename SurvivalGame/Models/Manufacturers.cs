namespace SurvivalGame.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Manufacturers
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Depiction { get; set; }

        [StringLength(50)]
        public string Img { get; set; }
    }
}

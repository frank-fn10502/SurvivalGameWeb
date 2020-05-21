namespace SurvivalGame.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ClassID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(50)]
        public string Img { get; set; }

        public string Depiction { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string ManufacturerID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
    }
}

namespace SurvivalGame.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Members
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Account { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Password { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string Mail { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smalldatetime")]
        public DateTime Birthday { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string Phone { get; set; }
    }
}

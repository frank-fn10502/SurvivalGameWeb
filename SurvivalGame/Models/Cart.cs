namespace SurvivalGame.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MemberID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string ProductID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Quantity { get; set; }

        [StringLength(50)]
        public string Depiction { get; set; }
    }
}

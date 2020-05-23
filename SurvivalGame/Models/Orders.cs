namespace SurvivalGame.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentMethod { get; set; }

        [StringLength(50)]
        public string Depiction { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ShipAddress { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smalldatetime")]
        public DateTime RequiredDate { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime ShippedDate { get; set; }
    }
}

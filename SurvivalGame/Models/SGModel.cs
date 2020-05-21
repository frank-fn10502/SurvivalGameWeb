namespace SurvivalGame.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SGModel :DbContext
    {
        public SGModel()
            : base("name=SGModel")
        {
        }

        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Catagory> Catagory { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderSource> OrderSource { get; set; }
        public virtual DbSet<Procurement> Procurement { get; set; }
        public virtual DbSet<Product_Attributes> Product_Attributes { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<RelatedProducts> RelatedProducts { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Cart>()
                .Property(e => e.MemberID)
                .IsFixedLength();

            modelBuilder.Entity<Cart>()
                .Property(e => e.ProductID)
                .IsFixedLength();

            modelBuilder.Entity<Catagory>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Class>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Class>()
                .Property(e => e.CatagoryID)
                .IsFixedLength();

            modelBuilder.Entity<Manufacturers>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Members>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Members>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Members>()
                .Property(e => e.Mail)
                .IsFixedLength();

            modelBuilder.Entity<Members>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Order_Details>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Order_Details>()
                .Property(e => e.OrderID)
                .IsFixedLength();

            modelBuilder.Entity<Order_Details>()
                .Property(e => e.ProductID)
                .IsFixedLength();

            modelBuilder.Entity<Order_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19 ,4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Orders>()
                .Property(e => e.MemberID)
                .IsFixedLength();

            modelBuilder.Entity<OrderSource>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<OrderSource>()
                .Property(e => e.OrderID)
                .IsFixedLength();

            modelBuilder.Entity<OrderSource>()
                .Property(e => e.ProcurementId)
                .IsFixedLength();

            modelBuilder.Entity<Procurement>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Procurement>()
                .Property(e => e.ProductID)
                .IsFixedLength();

            modelBuilder.Entity<Procurement>()
                .Property(e => e.UintPrice)
                .HasPrecision(19 ,4);

            modelBuilder.Entity<Product_Attributes>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Product_Attributes>()
                .Property(e => e.PID)
                .IsFixedLength();

            modelBuilder.Entity<Products>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Products>()
                .Property(e => e.ClassID)
                .IsFixedLength();

            modelBuilder.Entity<Products>()
                .Property(e => e.ManufacturerID)
                .IsFixedLength();

            modelBuilder.Entity<Products>()
                .Property(e => e.Price)
                .HasPrecision(19 ,4);

            modelBuilder.Entity<RelatedProducts>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<RelatedProducts>()
                .Property(e => e.ProductID)
                .IsFixedLength();

            modelBuilder.Entity<RelatedProducts>()
                .Property(e => e.RelationPID)
                .IsFixedLength();
        }
    }
}

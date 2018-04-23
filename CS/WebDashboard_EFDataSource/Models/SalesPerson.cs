namespace WebDashboard_EFDataSource.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesPerson")]
    public partial class SalesPerson
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [StringLength(15)]
        public string Country { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string LastName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string ProductName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(15)]
        public string CategoryName { get; set; }

        public DateTime? OrderDate { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal UnitPrice { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Quantity { get; set; }

        [Key]
        [Column(Order = 7)]
        public float Discount { get; set; }

        [Column("Extended Price", TypeName = "money")]
        public decimal? Extended_Price { get; set; }

        [Key]
        [Column("Sales Person", Order = 8)]
        [StringLength(31)]
        public string Sales_Person { get; set; }
    }
}

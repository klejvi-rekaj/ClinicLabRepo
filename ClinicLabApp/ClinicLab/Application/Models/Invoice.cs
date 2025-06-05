using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicLab.Application.Models
{
    [Table("Invoices")]
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? SupplierName { get; set; } = "";  

        [Required]
        public DateTime InvoiceDate { get; set; } = DateTime.Now;

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal AmountPaid { get; set; }

        [NotMapped]
        public decimal AmountDue => TotalAmount - AmountPaid;

        public string? Notes { get; set; } = null;
    }
}

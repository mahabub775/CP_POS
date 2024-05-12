using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP_POS.Models;

public partial class Product
{
    public Guid Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? CategoryId { get; set; }
    [Required]
    public string? UnitId { get; set; }

    public string? Description { get; set; }

    public string? DbuserId { get; set; }

    public DateTime? Dbservertime { get; set; }

    public virtual ProductCategory? Category { get; set; }

    public virtual ICollection<PurchaseInvoiceDetail> PurchaseDetails { get; set; } = new List<PurchaseInvoiceDetail>();

    public virtual ICollection<SaleInvoiceDetail> SaleDetails { get; set; } = new List<SaleInvoiceDetail>();

    public virtual MeasurementUnit? Unit { get; set; }

    #region Derived
    [NotMapped]
    public string? CategoryName { get; set; }
	#endregion
}

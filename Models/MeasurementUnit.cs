using System;
using System.Collections.Generic;

namespace CP_POS.Models;

public partial class MeasurementUnit
{
    public string Id { get; set; } = null!;

    public short WeightType { get; set; }

    public string Name { get; set; } = null!;

    public string? DbuserId { get; set; }

    public DateTime? Dbservertime { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<PurchaseInvoiceDetail> PurchaseDetails { get; set; } = new List<PurchaseInvoiceDetail>();

    public virtual ICollection<SaleInvoiceDetail> SaleDetails { get; set; } = new List<SaleInvoiceDetail>();
}

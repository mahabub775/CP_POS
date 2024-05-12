using System;
using System.Collections.Generic;

namespace CP_POS.Models;

public partial class SaleInvoiceDetail
{
    public string Id { get; set; } = null!;

    public string SalesId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public string UnitId { get; set; } = null!;

    public decimal Rate { get; set; }

    public decimal Quantity { get; set; }

    public decimal Amount { get; set; }

    public string? DbuserId { get; set; }

    public DateTime? Dbservertime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? Deletedtime { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual SaleInvoice Sales { get; set; } = null!;

    public virtual MeasurementUnit Unit { get; set; } = null!;
}

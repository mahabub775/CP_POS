using System;
using System.Collections.Generic;

namespace CP_POS.Models;

public partial class SaleInvoice
{
    public string Id { get; set; } = null!;

    public DateOnly SalesDate { get; set; }

    public string CustomerId { get; set; } = null!;

    public string? DbuserId { get; set; }

    public DateTime? Dbservertime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? Deletedtime { get; set; }

    public virtual Contractor Customer { get; set; } = null!;

    public virtual ICollection<SaleInvoiceDetail> SaleDetails { get; set; } = new List<SaleInvoiceDetail>();
}

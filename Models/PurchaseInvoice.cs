using System;
using System.Collections.Generic;

namespace CP_POS.Models;

public partial class PurchaseInvoice
{
    public string Id { get; set; } = null!;

    public DateOnly PurchaseDate { get; set; }

    public string SupplierId { get; set; } = null!;

    public string? Description { get; set; }

    public string? DbuserId { get; set; }

    public DateTime? Dbservertime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? Deletedtime { get; set; }

    public virtual ICollection<PurchaseInvoiceDetail> PurchaseDetails { get; set; } = new List<PurchaseInvoiceDetail>();

    public virtual Contractor Supplier { get; set; } = null!;
}

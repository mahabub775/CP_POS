using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CP_POS.Models;

public partial class Contractor
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }
    [Required]
    public string Mobile { get; set; }  

    public string? Address { get; set; }
    [Required]
    public short ContractorType { get; set; }

    public bool? Activity { get; set; }

    public string DbuserId { get; set; }  

    public DateTime Dbservertime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? Deletedtime { get; set; }

    public virtual ICollection<PurchaseInvoice> Purchases { get; set; } = new List<PurchaseInvoice>();

    public virtual ICollection<SaleInvoice> Sales { get; set; } = new List<SaleInvoice>();
}

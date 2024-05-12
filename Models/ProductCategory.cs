using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CP_POS.Models;

public partial class ProductCategory
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } 

    public string? DbuserId { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

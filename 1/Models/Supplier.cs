using System;
using System.Collections.Generic;

namespace DemoExPrepare.Models;

public partial class Supplier
{
    public long SupplierId { get; set; }

    public string Name { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

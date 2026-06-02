using System;
using System.Collections.Generic;

namespace DemoExPrepare.Models;

public partial class Product
{
    public long ProductId { get; set; }

    public string Name { get; set; } = null!;

    public long CategoryId { get; set; }

    public long ManufacturerId { get; set; }

    public long SuppliterId { get; set; }

    public decimal Price { get; set; }

    public int? Discount { get; set; }

    public int? Stock { get; set; }

    public string Description { get; set; } = null!;

    public string? PhotoPath { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual Supplier Suppliter { get; set; } = null!;
}

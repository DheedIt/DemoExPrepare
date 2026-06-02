using System;
using System.Collections.Generic;

namespace DemoExPrepare.Models;

public partial class Manufacturer
{
    public long ManufacturerId { get; set; }

    public string Name { get; set; } = null!;

    public string Country { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

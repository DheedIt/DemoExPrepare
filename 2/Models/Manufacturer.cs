using System;
using System.Collections.Generic;

namespace DemoExamShoeShop.Models;

/// <summary>
/// Производитель
/// </summary>
public partial class Manufacturer
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public int ManufacturerId { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Страна
    /// </summary>
    public string Country { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

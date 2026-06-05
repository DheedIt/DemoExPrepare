using System;
using System.Collections.Generic;

namespace DemoExamShoeShop.Models;

/// <summary>
/// Категория обуви
/// </summary>
public partial class Category
{
    /// <summary>
    /// Уникальный идентификтор
    /// </summary>
    public int CategoryId { get; set; }

    /// <summary>
    /// Название категории
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

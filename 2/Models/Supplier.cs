using System;
using System.Collections.Generic;

namespace DemoExamShoeShop.Models;

/// <summary>
/// Поставщик
/// </summary>
public partial class Supplier
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public int SupplierId { get; set; }

    public string Name { get; set; } = null!;

    /// <summary>
    /// Номер телефона
    /// </summary>
    public string Phone { get; set; } = null!;

    /// <summary>
    /// Почта
    /// </summary>
    public string Email { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

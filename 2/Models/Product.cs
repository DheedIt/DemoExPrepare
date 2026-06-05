using System;
using System.Collections.Generic;

namespace DemoExamShoeShop.Models;

/// <summary>
/// Каталог товаров
/// </summary>
public partial class Product
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Цена
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Скидка
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Остаток
    /// </summary>
    public int Stock { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Ссылка на картинку товара
    /// </summary>
    public string? PhotoPath { get; set; }

    /// <summary>
    /// Ссылка на категорию товара
    /// </summary>
    public int CategoryId { get; set; }

    /// <summary>
    /// Ссылка на поставщика
    /// </summary>
    public int SupplierId { get; set; }

    /// <summary>
    /// Ссылка на производителя
    /// </summary>
    public int ManufacturerId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}

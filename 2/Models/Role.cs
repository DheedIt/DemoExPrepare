using System;
using System.Collections.Generic;

namespace DemoExamShoeShop.Models;

/// <summary>
/// Таблица с ролями пользователя
/// </summary>
public partial class Role
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public int RoleId { get; set; }

    /// <summary>
    /// Название роли
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

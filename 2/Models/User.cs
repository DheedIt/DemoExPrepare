using System;
using System.Collections.Generic;

namespace DemoExamShoeShop.Models;

/// <summary>
/// Таблица с информацией о пользователе
/// </summary>
public partial class User
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string Login { get; set; } = null!;

    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// Ссылка на роль
    /// </summary>
    public int RoleId { get; set; }

    public virtual Role Role { get; set; } = null!;
}

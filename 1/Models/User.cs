using System;
using System.Collections.Generic;

namespace DemoExPrepare.Models;

public partial class User
{
    public long UserId { get; set; }

    public string Login { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public long? RoleId { get; set; }

    public virtual Role? Role { get; set; }
}

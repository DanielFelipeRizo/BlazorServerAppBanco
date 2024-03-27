using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class SecUsersKeyHistory
{
    public long Id { get; set; }

    public DateTime Date { get; set; }

    public string UsuLogin { get; set; } = null!;

    public string? UsuHashOld { get; set; }

    public virtual SecUser UsuLoginNavigation { get; set; } = null!;
}

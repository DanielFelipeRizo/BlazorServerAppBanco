using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class SecUser
{
    public string Login { get; set; } = null!;

    public string Pswd { get; set; } = null!;

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? UsrActive { get; set; }

    public string? ActivationCode { get; set; }

    public string? PrivAdmin { get; set; }

    public DateTime? UsrDateExpKey { get; set; }

    public DateTime? UsrDateCreationKey { get; set; }

    public int? UsrAttempts { get; set; }

    public string? RegisteredUser { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? UserUltHigh { get; set; }

    public DateTime? DateTimeUltActive { get; set; }

    public int? AuthenticationCode { get; set; }

    public DateTime? ValidityCode { get; set; }

    public int? AuthAttempts { get; set; }

    public int? TagUser { get; set; }

    public virtual ICollection<SecUsersKeyHistory> SecUsersKeyHistories { get; set; } = new List<SecUsersKeyHistory>();

    public virtual UserTag? TagUserNavigation { get; set; }

    public virtual ICollection<SecGroup> Groups { get; set; } = new List<SecGroup>();
}

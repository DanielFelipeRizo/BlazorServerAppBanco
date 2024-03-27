using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class UserTag
{
    public int UserTagId { get; set; }

    public string? UserTagsName { get; set; }

    public string? UserTagsDescription { get; set; }

    public long UserTagsStatus { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<SecUser> SecUsers { get; set; } = new List<SecUser>();
}

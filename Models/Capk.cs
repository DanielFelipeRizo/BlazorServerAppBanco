using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Capk
{
    public string TemplateId { get; set; } = null!;

    public string KeyId { get; set; } = null!;

    public string KeyRid { get; set; } = null!;

    public string KeyExponent { get; set; } = null!;

    public string? KeySize { get; set; }

    public string KeyModule { get; set; } = null!;

    public DateOnly KeyExpirationDate { get; set; }

    public string KeySha1 { get; set; } = null!;

    public virtual CapksExponent KeyExponentNavigation { get; set; } = null!;

    public virtual CapksRid KeyR { get; set; } = null!;

    public virtual CapksSize? KeySizeNavigation { get; set; }

    public virtual TemplateCapk Template { get; set; } = null!;
}

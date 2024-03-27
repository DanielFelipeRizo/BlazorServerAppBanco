using System;
using System.Collections;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Customer
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string DownloadIp { get; set; } = null!;

    public string DownloadPort { get; set; } = null!;

    public long StatusTypeId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public BitArray? SelfLearning { get; set; }

    public virtual StatusType StatusType { get; set; } = null!;
}

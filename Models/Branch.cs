using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Branch
{
    public long BranchId { get; set; }

    public string? Name { get; set; }

    public long? RepresentativeId { get; set; }

    public string? TransactionHoursDaysId { get; set; }

    public long? CommerceId { get; set; }

    public string? BaseUrl { get; set; }

    public string? BaseUrlToken { get; set; }

    public string? BaseUrlTransactional { get; set; }

    public string? CardAccpMerch { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ClosingDays { get; set; }

    public string? Address { get; set; }

    public string? Status { get; set; }

    public int? EnableSignature { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? IsMainBranch { get; set; }

    public string? Country { get; set; }

    public string? Department { get; set; }

    public string? City { get; set; }

    public string? Phone { get; set; }

    public string? AuxiliaryLine { get; set; }

    public DateOnly? StartDate { get; set; }

    public int? ProfileId { get; set; }

    public string? VirtualCardNumber { get; set; }

    public virtual Commerce? Commerce { get; set; }

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();

    public virtual Representative? Representative { get; set; }

    public virtual TemplateBranchesHour? TransactionHoursDays { get; set; }
}

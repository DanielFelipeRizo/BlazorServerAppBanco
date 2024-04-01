using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Device
{
    public long DeviceId { get; set; }

    public string? DeviceDescription { get; set; }

    public string SerialNumber { get; set; } = null!;

    public int? DeviceModelId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? AgentId { get; set; }

    public int? DeviceBrandId { get; set; }

    public string? Imei { get; set; }

    public string? Ip { get; set; }

    public string? Ram { get; set; }

    public string? BatteryLevel { get; set; }

    public DateOnly? LastUpdatedDate { get; set; }

    public int? UpdateStatusDeviceId { get; set; }

    public string? CellPhoneNetwork { get; set; }

    public string? Apn { get; set; }

    public string? SignalLevel { get; set; }

    public string? AccountNumber { get; set; }

    public string? Sim { get; set; }

    public int? DeviceTypeId { get; set; }

    public int? DeviceInterfaceId { get; set; }

    public string? Mac { get; set; }

    public int? DeviceTagId { get; set; }

    public string? ApplicationKey { get; set; }

    public int? KeyExpiryDays { get; set; }

    public string? Description { get; set; }

    public int? ValidateSim { get; set; }

    public int? ValidateImei { get; set; }

    public string? InstalledApplications { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public int? ProfileId { get; set; }

    public bool? StatusTypeId { get; set; }

    public long CommerceId { get; set; }

    public long? BranchId { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Commerce Commerce { get; set; } = null!;

    public virtual DeviceBrand? DeviceBrand { get; set; }

    public virtual DeviceInterface? DeviceInterface { get; set; }

    public virtual DeviceModel? DeviceModel { get; set; }

    public virtual DeviceTag? DeviceTag { get; set; }

    public virtual DeviceType? DeviceType { get; set; }

    public virtual UpdateStatusDevice? UpdateStatusDevice { get; set; }
}

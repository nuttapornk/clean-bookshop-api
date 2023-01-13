using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmagentBackup20210927
{
    public string SAgentId { get; set; } = null!;

    public string SUserName { get; set; } = null!;

    public byte[]? IUserImage { get; set; }

    public string? SLineId { get; set; }

    public int? NTitleId { get; set; }

    public string? SFirstName { get; set; }

    public string? SLastName { get; set; }

    public DateTime? DDateOfBirth { get; set; }

    public string? SCitizenId { get; set; }

    public string? SMobilePhoneNo1 { get; set; }

    public string? SMobilePhoneNo2 { get; set; }

    public string? STelephoneNo { get; set; }

    public string? SAgentReferId { get; set; }

    public string SAgentTypeId { get; set; } = null!;

    public string SAgentClassId { get; set; } = null!;

    public string SAgentStatusId { get; set; } = null!;

    public string SAgentRoleId { get; set; } = null!;

    public bool? BAgreementApproveStatus { get; set; }

    public DateTime? DOnboardingDate { get; set; }

    public bool? BRevenue { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? NAgentInActiveStatusId { get; set; }
}

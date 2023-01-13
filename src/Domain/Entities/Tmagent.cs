using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Tmagent
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

    public virtual TmagentClass SAgentClass { get; set; } = null!;

    public virtual TmagentRefer? SAgentRefer { get; set; }

    public virtual TmagentRole SAgentRole { get; set; } = null!;

    public virtual TmagentStatus SAgentStatus { get; set; } = null!;

    public virtual TmagentType SAgentType { get; set; } = null!;

    public virtual ICollection<TmagentAddress> TmagentAddresses { get; } = new List<TmagentAddress>();

    public virtual ICollection<TmagentBankAccount> TmagentBankAccounts { get; } = new List<TmagentBankAccount>();

    public virtual ICollection<TmagentCodeMapping> TmagentCodeMappings { get; } = new List<TmagentCodeMapping>();

    public virtual ICollection<TmagentDocument> TmagentDocuments { get; } = new List<TmagentDocument>();

    public virtual ICollection<TmagentEmail> TmagentEmails { get; } = new List<TmagentEmail>();

    public virtual ICollection<TmagentLicense> TmagentLicenses { get; } = new List<TmagentLicense>();

    public virtual ICollection<TmagentReasonDisable> TmagentReasonDisables { get; } = new List<TmagentReasonDisable>();

    public virtual ICollection<TmverifyRejectDetail> TmverifyRejectDetails { get; } = new List<TmverifyRejectDetail>();

    public virtual ICollection<TthverifyRegister> TthverifyRegisters { get; } = new List<TthverifyRegister>();

    public virtual ICollection<TtverifyProfileAgent> TtverifyProfileAgents { get; } = new List<TtverifyProfileAgent>();
}

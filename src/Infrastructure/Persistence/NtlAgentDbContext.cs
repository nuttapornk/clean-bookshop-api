using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public partial class NtlAgentDbContext : DbContext
{
    public NtlAgentDbContext()
    {
    }

    public NtlAgentDbContext(DbContextOptions<NtlAgentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TempTmagentRole> TempTmagentRoles { get; set; }

    public virtual DbSet<TempTmagentRoleAuthorize> TempTmagentRoleAuthorizes { get; set; }

    public virtual DbSet<TempTmmenu> TempTmmenus { get; set; }

    public virtual DbSet<Tmagent> Tmagents { get; set; }

    public virtual DbSet<TmagentAddress> TmagentAddresses { get; set; }

    public virtual DbSet<TmagentBackup20210927> TmagentBackup20210927s { get; set; }

    public virtual DbSet<TmagentBankAccount> TmagentBankAccounts { get; set; }

    public virtual DbSet<TmagentClass> TmagentClasses { get; set; }

    public virtual DbSet<TmagentCodeMapping> TmagentCodeMappings { get; set; }

    public virtual DbSet<TmagentDocument> TmagentDocuments { get; set; }

    public virtual DbSet<TmagentEmail> TmagentEmails { get; set; }

    public virtual DbSet<TmagentInActiveStatus> TmagentInActiveStatuses { get; set; }

    public virtual DbSet<TmagentLicense> TmagentLicenses { get; set; }

    public virtual DbSet<TmagentProfileType> TmagentProfileTypes { get; set; }

    public virtual DbSet<TmagentReasonDisable> TmagentReasonDisables { get; set; }

    public virtual DbSet<TmagentRefer> TmagentRefers { get; set; }

    public virtual DbSet<TmagentRole> TmagentRoles { get; set; }

    public virtual DbSet<TmagentRoleAuthorize> TmagentRoleAuthorizes { get; set; }

    public virtual DbSet<TmagentRoleAuthorizeBackup20210927> TmagentRoleAuthorizeBackup20210927s { get; set; }

    public virtual DbSet<TmagentRoleAuthorizeBackupSp16> TmagentRoleAuthorizeBackupSp16s { get; set; }

    public virtual DbSet<TmagentRoleAuthorizeStatus> TmagentRoleAuthorizeStatuses { get; set; }

    public virtual DbSet<TmagentRoleBackup20210927> TmagentRoleBackup20210927s { get; set; }

    public virtual DbSet<TmagentRoleGroup> TmagentRoleGroups { get; set; }

    public virtual DbSet<TmagentStatus> TmagentStatuses { get; set; }

    public virtual DbSet<TmagentType> TmagentTypes { get; set; }

    public virtual DbSet<Tmbank> Tmbanks { get; set; }

    public virtual DbSet<TmbankBackupSp17> TmbankBackupSp17s { get; set; }

    public virtual DbSet<TmconfigRunningNo> TmconfigRunningNos { get; set; }

    public virtual DbSet<Tmdistrict> Tmdistricts { get; set; }

    public virtual DbSet<Tmdocument> Tmdocuments { get; set; }

    public virtual DbSet<Tmmenu> Tmmenus { get; set; }

    public virtual DbSet<TmmenuBackup20210927> TmmenuBackup20210927s { get; set; }

    public virtual DbSet<TmmenuBackupSp16> TmmenuBackupSp16s { get; set; }

    public virtual DbSet<TmmenuGroup> TmmenuGroups { get; set; }

    public virtual DbSet<Tmprovince> Tmprovinces { get; set; }

    public virtual DbSet<TmreasonApprove> TmreasonApproves { get; set; }

    public virtual DbSet<TmreasonReject> TmreasonRejects { get; set; }

    public virtual DbSet<TmsubDistrict> TmsubDistricts { get; set; }

    public virtual DbSet<TmtitleName> TmtitleNames { get; set; }

    public virtual DbSet<TmverifyRejectDetail> TmverifyRejectDetails { get; set; }

    public virtual DbSet<TmverifyStatus> TmverifyStatuses { get; set; }

    public virtual DbSet<TmzipCode> TmzipCodes { get; set; }

    public virtual DbSet<TtdverifyRegisterDetail> TtdverifyRegisterDetails { get; set; }

    public virtual DbSet<TtgenerateRunningNo> TtgenerateRunningNos { get; set; }

    public virtual DbSet<TthverifyRegister> TthverifyRegisters { get; set; }

    public virtual DbSet<TtverifyProfileAgent> TtverifyProfileAgents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TempTmagentRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_TMAgentRole");

            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentRoleGroupId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleGroupID");
            entity.Property(e => e.SAgentRoleId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleID");
            entity.Property(e => e.SAgentRoleName)
                .HasMaxLength(50)
                .HasColumnName("sAgentRoleName");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TempTmagentRoleAuthorize>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_TMAgentRoleAuthorize");

            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NMenuId).HasColumnName("nMenuID");
            entity.Property(e => e.NRoleAuthorizeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("nRoleAuthorizeID");
            entity.Property(e => e.SAgentRoleId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TempTmmenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_TMMenu");

            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NMenuId)
                .ValueGeneratedOnAdd()
                .HasColumnName("nMenuID");
            entity.Property(e => e.NMenuOrder).HasColumnName("nMenuOrder");
            entity.Property(e => e.NMenuParentId).HasColumnName("nMenuParentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SMenuCode)
                .HasMaxLength(10)
                .HasColumnName("sMenuCode");
            entity.Property(e => e.SMenuDescEn)
                .HasMaxLength(250)
                .HasColumnName("sMenuDescEN");
            entity.Property(e => e.SMenuDescTh)
                .HasMaxLength(250)
                .HasColumnName("sMenuDescTH");
            entity.Property(e => e.SMenuGroupId)
                .HasMaxLength(1)
                .HasColumnName("sMenuGroupID");
            entity.Property(e => e.SMenuUrl)
                .HasMaxLength(250)
                .HasColumnName("sMenuURL");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<Tmagent>(entity =>
        {
            entity.HasKey(e => e.SAgentId);

            entity.ToTable("TMAgent");

            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.BAgreementApproveStatus).HasColumnName("bAgreementApproveStatus");
            entity.Property(e => e.BRevenue).HasColumnName("bRevenue");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DDateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("dDateOfBirth");
            entity.Property(e => e.DOnboardingDate)
                .HasColumnType("datetime")
                .HasColumnName("dOnboardingDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.IUserImage)
                .HasColumnType("image")
                .HasColumnName("iUserImage");
            entity.Property(e => e.NAgentInActiveStatusId).HasColumnName("nAgentInActiveStatusID");
            entity.Property(e => e.NTitleId).HasColumnName("nTitleID");
            entity.Property(e => e.SAgentClassId)
                .HasMaxLength(2)
                .HasColumnName("sAgentClassID");
            entity.Property(e => e.SAgentReferId)
                .HasMaxLength(50)
                .HasColumnName("sAgentReferID");
            entity.Property(e => e.SAgentRoleId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleID");
            entity.Property(e => e.SAgentStatusId)
                .HasMaxLength(2)
                .HasColumnName("sAgentStatusID");
            entity.Property(e => e.SAgentTypeId)
                .HasMaxLength(2)
                .HasColumnName("sAgentTypeID");
            entity.Property(e => e.SCitizenId)
                .HasMaxLength(13)
                .HasColumnName("sCitizenID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SFirstName)
                .HasMaxLength(50)
                .HasColumnName("sFirstName");
            entity.Property(e => e.SLastName)
                .HasMaxLength(50)
                .HasColumnName("sLastName");
            entity.Property(e => e.SLineId)
                .HasMaxLength(50)
                .HasColumnName("sLineID");
            entity.Property(e => e.SMobilePhoneNo1)
                .HasMaxLength(10)
                .HasColumnName("sMobilePhoneNo_1");
            entity.Property(e => e.SMobilePhoneNo2)
                .HasMaxLength(10)
                .HasColumnName("sMobilePhoneNo_2");
            entity.Property(e => e.STelephoneNo)
                .HasMaxLength(10)
                .HasColumnName("sTelephoneNo");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
            entity.Property(e => e.SUserName)
                .HasMaxLength(50)
                .HasColumnName("sUserName");

            entity.HasOne(d => d.SAgentClass).WithMany(p => p.Tmagents)
                .HasForeignKey(d => d.SAgentClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgent_TMAgentClass");

            entity.HasOne(d => d.SAgentRefer).WithMany(p => p.Tmagents)
                .HasForeignKey(d => d.SAgentReferId)
                .HasConstraintName("FK_TMAgent_TMAgentRefer");

            entity.HasOne(d => d.SAgentRole).WithMany(p => p.Tmagents)
                .HasForeignKey(d => d.SAgentRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgent_TMAgentRole");

            entity.HasOne(d => d.SAgentStatus).WithMany(p => p.Tmagents)
                .HasForeignKey(d => d.SAgentStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgent_TMAgentStatus");

            entity.HasOne(d => d.SAgentType).WithMany(p => p.Tmagents)
                .HasForeignKey(d => d.SAgentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgent_TMAgentType");
        });

        modelBuilder.Entity<TmagentAddress>(entity =>
        {
            entity.HasKey(e => e.NAgentAddressId);

            entity.ToTable("TMAgentAddress");

            entity.HasIndex(e => new { e.SAgentId, e.BActive, e.BEnable }, "IX_TMAgentAddress_sAgentID_bActive_bEnable");

            entity.Property(e => e.NAgentAddressId).HasColumnName("nAgentAddressID");
            entity.Property(e => e.BActive).HasColumnName("bActive");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NDistrictId).HasColumnName("nDistrictID");
            entity.Property(e => e.NProvinceId).HasColumnName("nProvinceID");
            entity.Property(e => e.NSubDistrictId).HasColumnName("nSubDistrictID");
            entity.Property(e => e.SAddressNo)
                .HasMaxLength(50)
                .HasColumnName("sAddressNo");
            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.SAlley)
                .HasMaxLength(200)
                .HasColumnName("sAlley");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SStreet)
                .HasMaxLength(200)
                .HasColumnName("sStreet");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
            entity.Property(e => e.SVillage)
                .HasMaxLength(200)
                .HasColumnName("sVillage");
            entity.Property(e => e.SZipcodeId)
                .HasMaxLength(5)
                .HasColumnName("sZipcodeID");

            entity.HasOne(d => d.SAgent).WithMany(p => p.TmagentAddresses)
                .HasForeignKey(d => d.SAgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentAddress_TMAgent");
        });

        modelBuilder.Entity<TmagentBackup20210927>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMAgent_Backup_20210927");

            entity.Property(e => e.BAgreementApproveStatus).HasColumnName("bAgreementApproveStatus");
            entity.Property(e => e.BRevenue).HasColumnName("bRevenue");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DDateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("dDateOfBirth");
            entity.Property(e => e.DOnboardingDate)
                .HasColumnType("datetime")
                .HasColumnName("dOnboardingDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.IUserImage)
                .HasColumnType("image")
                .HasColumnName("iUserImage");
            entity.Property(e => e.NAgentInActiveStatusId).HasColumnName("nAgentInActiveStatusID");
            entity.Property(e => e.NTitleId).HasColumnName("nTitleID");
            entity.Property(e => e.SAgentClassId)
                .HasMaxLength(2)
                .HasColumnName("sAgentClassID");
            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.SAgentReferId)
                .HasMaxLength(50)
                .HasColumnName("sAgentReferID");
            entity.Property(e => e.SAgentRoleId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleID");
            entity.Property(e => e.SAgentStatusId)
                .HasMaxLength(2)
                .HasColumnName("sAgentStatusID");
            entity.Property(e => e.SAgentTypeId)
                .HasMaxLength(2)
                .HasColumnName("sAgentTypeID");
            entity.Property(e => e.SCitizenId)
                .HasMaxLength(13)
                .HasColumnName("sCitizenID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SFirstName)
                .HasMaxLength(50)
                .HasColumnName("sFirstName");
            entity.Property(e => e.SLastName)
                .HasMaxLength(50)
                .HasColumnName("sLastName");
            entity.Property(e => e.SLineId)
                .HasMaxLength(50)
                .HasColumnName("sLineID");
            entity.Property(e => e.SMobilePhoneNo1)
                .HasMaxLength(10)
                .HasColumnName("sMobilePhoneNo_1");
            entity.Property(e => e.SMobilePhoneNo2)
                .HasMaxLength(10)
                .HasColumnName("sMobilePhoneNo_2");
            entity.Property(e => e.STelephoneNo)
                .HasMaxLength(10)
                .HasColumnName("sTelephoneNo");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
            entity.Property(e => e.SUserName)
                .HasMaxLength(50)
                .HasColumnName("sUserName");
        });

        modelBuilder.Entity<TmagentBankAccount>(entity =>
        {
            entity.HasKey(e => e.NAgentBankAccountId);

            entity.ToTable("TMAgentBankAccount");

            entity.HasIndex(e => new { e.NBankId, e.BIsActive, e.BEnable }, "IX_TMAgentBankAccount_nBankID_bIsActive_bEnable");

            entity.Property(e => e.NAgentBankAccountId).HasColumnName("nAgentBankAccountID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.BIsActive).HasColumnName("bIsActive");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NBankId).HasColumnName("nBankID");
            entity.Property(e => e.SAccountName)
                .HasMaxLength(255)
                .HasColumnName("sAccountName");
            entity.Property(e => e.SAccountNumber)
                .HasMaxLength(20)
                .HasColumnName("sAccountNumber");
            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");

            entity.HasOne(d => d.NBank).WithMany(p => p.TmagentBankAccounts)
                .HasForeignKey(d => d.NBankId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentBankAccount_TMBank");

            entity.HasOne(d => d.SAgent).WithMany(p => p.TmagentBankAccounts)
                .HasForeignKey(d => d.SAgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentBankAccount_TMAgent");
        });

        modelBuilder.Entity<TmagentClass>(entity =>
        {
            entity.HasKey(e => e.SAgentClassId);

            entity.ToTable("TMAgentClass");

            entity.Property(e => e.SAgentClassId)
                .HasMaxLength(2)
                .HasColumnName("sAgentClassID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentClassName)
                .HasMaxLength(50)
                .HasColumnName("sAgentClassName");
            entity.Property(e => e.SCreateUy)
                .HasMaxLength(50)
                .HasColumnName("sCreateUy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmagentCodeMapping>(entity =>
        {
            entity.HasKey(e => e.SAgentCode);

            entity.ToTable("TMAgentCodeMapping");

            entity.HasIndex(e => e.SAgentId, "IX_TMAgentCodeMapping_sAgentID");

            entity.Property(e => e.SAgentCode)
                .HasMaxLength(10)
                .HasColumnName("sAgentCode");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NRunningNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("nRunningNo");
            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");

            entity.HasOne(d => d.SAgent).WithMany(p => p.TmagentCodeMappings)
                .HasForeignKey(d => d.SAgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentCodeMapping_TMAgent");
        });

        modelBuilder.Entity<TmagentDocument>(entity =>
        {
            entity.HasKey(e => e.NAgentDocumentId);

            entity.ToTable("TMAgentDocument");

            entity.Property(e => e.NAgentDocumentId).HasColumnName("nAgentDocumentID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.BIsActive).HasColumnName("bIsActive");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.IAgentDocunmentContent)
                .HasColumnType("image")
                .HasColumnName("iAgentDocunmentContent");
            entity.Property(e => e.NFileSize).HasColumnName("nFileSize");
            entity.Property(e => e.SAgentDocumentDescription)
                .HasMaxLength(255)
                .HasColumnName("sAgentDocumentDescription");
            entity.Property(e => e.SAgentDocumentName)
                .HasMaxLength(255)
                .HasColumnName("sAgentDocumentName");
            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SDocumentId)
                .HasMaxLength(2)
                .HasColumnName("sDocumentID");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");

            entity.HasOne(d => d.SAgent).WithMany(p => p.TmagentDocuments)
                .HasForeignKey(d => d.SAgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentDocument_TMAgent");

            entity.HasOne(d => d.SDocument).WithMany(p => p.TmagentDocuments)
                .HasForeignKey(d => d.SDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentDocument_TMDocument");
        });

        modelBuilder.Entity<TmagentEmail>(entity =>
        {
            entity.HasKey(e => e.NAgentEmailId);

            entity.ToTable("TMAgentEmail");

            entity.Property(e => e.NAgentEmailId).HasColumnName("nAgentEmailID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.BIsActive).HasColumnName("bIsActive");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SEmail)
                .HasMaxLength(150)
                .HasColumnName("sEmail");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");

            entity.HasOne(d => d.SAgent).WithMany(p => p.TmagentEmails)
                .HasForeignKey(d => d.SAgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentEmail_TMAgent");
        });

        modelBuilder.Entity<TmagentInActiveStatus>(entity =>
        {
            entity.HasKey(e => e.NId);

            entity.ToTable("TMAgentInActiveStatus");

            entity.Property(e => e.NId)
                .ValueGeneratedNever()
                .HasColumnName("nID");
            entity.Property(e => e.BActive).HasColumnName("bActive");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SDisableUser).HasColumnName("sDisableUser");
            entity.Property(e => e.SName)
                .HasMaxLength(500)
                .HasColumnName("sName");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmagentLicense>(entity =>
        {
            entity.HasKey(e => e.NLicenseId);

            entity.ToTable("TMAgentLicense");

            entity.Property(e => e.NLicenseId).HasColumnName("nLicenseID");
            entity.Property(e => e.BActive).HasColumnName("bActive");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DLicenseExpiredDate)
                .HasColumnType("date")
                .HasColumnName("dLicenseExpiredDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SLicenseNo)
                .HasMaxLength(50)
                .HasColumnName("sLicenseNo");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");

            entity.HasOne(d => d.SAgent).WithMany(p => p.TmagentLicenses)
                .HasForeignKey(d => d.SAgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentLicense_TMAgent");
        });

        modelBuilder.Entity<TmagentProfileType>(entity =>
        {
            entity.HasKey(e => e.SAgentProfileTypeId);

            entity.ToTable("TMAgentProfileType");

            entity.Property(e => e.SAgentProfileTypeId)
                .HasMaxLength(2)
                .HasColumnName("sAgentProfileTypeID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentProfileTypeName)
                .HasMaxLength(255)
                .HasColumnName("sAgentProfileTypeName");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmagentReasonDisable>(entity =>
        {
            entity.HasKey(e => e.SAgentReasonDisable).HasName("PK_TMAgentReasonTerminate");

            entity.ToTable("TMAgentReasonDisable");

            entity.Property(e => e.SAgentReasonDisable)
                .HasMaxLength(50)
                .HasColumnName("sAgentReasonDisable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SRemark)
                .HasMaxLength(255)
                .HasColumnName("sRemark");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");

            entity.HasOne(d => d.SAgent).WithMany(p => p.TmagentReasonDisables)
                .HasForeignKey(d => d.SAgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentReasonTerminate_TMAgent");
        });

        modelBuilder.Entity<TmagentRefer>(entity =>
        {
            entity.HasKey(e => e.SAgentReferId);

            entity.ToTable("TMAgentRefer");

            entity.Property(e => e.SAgentReferId)
                .HasMaxLength(50)
                .HasColumnName("sAgentReferID");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentChildId)
                .HasMaxLength(50)
                .HasColumnName("sAgentChildID");
            entity.Property(e => e.SAgentParentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentParentID");
            entity.Property(e => e.SAgentReferGroup)
                .HasMaxLength(50)
                .HasColumnName("sAgentReferGroup");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmagentRole>(entity =>
        {
            entity.HasKey(e => e.SAgentRoleId);

            entity.ToTable("TMAgentRole");

            entity.Property(e => e.SAgentRoleId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentRoleGroupId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleGroupID");
            entity.Property(e => e.SAgentRoleName)
                .HasMaxLength(50)
                .HasColumnName("sAgentRoleName");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");

            entity.HasOne(d => d.SAgentRoleGroup).WithMany(p => p.TmagentRoles)
                .HasForeignKey(d => d.SAgentRoleGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentRole_TMAgentRoleGroup");
        });

        modelBuilder.Entity<TmagentRoleAuthorize>(entity =>
        {
            entity.HasKey(e => e.NRoleAuthorizeId);

            entity.ToTable("TMAgentRoleAuthorize");

            entity.Property(e => e.NRoleAuthorizeId)
                .ValueGeneratedNever()
                .HasColumnName("nRoleAuthorizeID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NMenuId).HasColumnName("nMenuID");
            entity.Property(e => e.SAgentRoleId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");

            entity.HasOne(d => d.NMenu).WithMany(p => p.TmagentRoleAuthorizes)
                .HasForeignKey(d => d.NMenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentRoleAuthorize_TMMenu");

            entity.HasOne(d => d.SAgentRole).WithMany(p => p.TmagentRoleAuthorizes)
                .HasForeignKey(d => d.SAgentRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentRoleAuthorize_TMAgentRole");
        });

        modelBuilder.Entity<TmagentRoleAuthorizeBackup20210927>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMAgentRoleAuthorize_Backup_20210927");

            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NMenuId).HasColumnName("nMenuID");
            entity.Property(e => e.NRoleAuthorizeId).HasColumnName("nRoleAuthorizeID");
            entity.Property(e => e.SAgentRoleId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmagentRoleAuthorizeBackupSp16>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMAgentRoleAuthorize_Backup_SP16");

            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NMenuId).HasColumnName("nMenuID");
            entity.Property(e => e.NRoleAuthorizeId).HasColumnName("nRoleAuthorizeID");
            entity.Property(e => e.SAgentRoleId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmagentRoleAuthorizeStatus>(entity =>
        {
            entity.HasKey(e => new { e.NRoleAuthorizeStatusId, e.NRequestStatusId }).HasName("PK_TMAgentRoleAuthorizeStatus_1");

            entity.ToTable("TMAgentRoleAuthorizeStatus");

            entity.Property(e => e.NRoleAuthorizeStatusId).HasColumnName("nRoleAuthorizeStatusID");
            entity.Property(e => e.NRequestStatusId).HasColumnName("nRequestStatusID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NMenuId).HasColumnName("nMenuID");
            entity.Property(e => e.SAgentRoleId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");

            entity.HasOne(d => d.NMenu).WithMany(p => p.TmagentRoleAuthorizeStatuses)
                .HasForeignKey(d => d.NMenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentRoleAuthorizeStatus_TMMenu");

            entity.HasOne(d => d.SAgentRole).WithMany(p => p.TmagentRoleAuthorizeStatuses)
                .HasForeignKey(d => d.SAgentRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMAgentRoleAuthorizeStatus_TMAgentRole");
        });

        modelBuilder.Entity<TmagentRoleBackup20210927>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMAgentRole_Backup_20210927");

            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentRoleGroupId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleGroupID");
            entity.Property(e => e.SAgentRoleId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleID");
            entity.Property(e => e.SAgentRoleName)
                .HasMaxLength(50)
                .HasColumnName("sAgentRoleName");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmagentRoleGroup>(entity =>
        {
            entity.HasKey(e => e.SAgentRoleGroupId);

            entity.ToTable("TMAgentRoleGroup");

            entity.Property(e => e.SAgentRoleGroupId)
                .HasMaxLength(2)
                .HasColumnName("sAgentRoleGroupID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentRoleGroupName)
                .HasMaxLength(50)
                .HasColumnName("sAgentRoleGroupName");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmagentStatus>(entity =>
        {
            entity.HasKey(e => e.SAgentStatusId);

            entity.ToTable("TMAgentStatus");

            entity.Property(e => e.SAgentStatusId)
                .HasMaxLength(2)
                .HasColumnName("sAgentStatusID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentStatusName)
                .HasMaxLength(50)
                .HasColumnName("sAgentStatusName");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmagentType>(entity =>
        {
            entity.HasKey(e => e.SAgentTypeId);

            entity.ToTable("TMAgentType");

            entity.Property(e => e.SAgentTypeId)
                .HasMaxLength(2)
                .HasColumnName("sAgentTypeID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentTypeName)
                .HasMaxLength(150)
                .HasColumnName("sAgentTypeName");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<Tmbank>(entity =>
        {
            entity.HasKey(e => e.NBankId);

            entity.ToTable("TMBank");

            entity.Property(e => e.NBankId).HasColumnName("nBankID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.IBankImage)
                .HasColumnType("image")
                .HasColumnName("iBankImage");
            entity.Property(e => e.SBankCode)
                .HasMaxLength(3)
                .HasColumnName("sBankCode");
            entity.Property(e => e.SBankName)
                .HasMaxLength(100)
                .HasColumnName("sBankName");
            entity.Property(e => e.SBankShortName)
                .HasMaxLength(100)
                .HasColumnName("sBankShortName");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmbankBackupSp17>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMBank_Backup_Sp17");

            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.IBankImage)
                .HasColumnType("image")
                .HasColumnName("iBankImage");
            entity.Property(e => e.NBankId).HasColumnName("nBankID");
            entity.Property(e => e.SBankCode)
                .HasMaxLength(3)
                .HasColumnName("sBankCode");
            entity.Property(e => e.SBankName)
                .HasMaxLength(100)
                .HasColumnName("sBankName");
            entity.Property(e => e.SBankShortName)
                .HasMaxLength(100)
                .HasColumnName("sBankShortName");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmconfigRunningNo>(entity =>
        {
            entity.HasKey(e => e.SRunningType);

            entity.ToTable("TMConfigRunningNo");

            entity.Property(e => e.SRunningType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sRunningType");
            entity.Property(e => e.NDigitAutoRunning)
                .HasComment("จำนวนหลักทั้งหมด")
                .HasColumnName("nDigitAutoRunning");
            entity.Property(e => e.SPreFix)
                .HasMaxLength(5)
                .HasColumnName("sPreFix");
            entity.Property(e => e.SRunningTypeDescription)
                .HasMaxLength(100)
                .HasColumnName("sRunningTypeDescription");
        });

        modelBuilder.Entity<Tmdistrict>(entity =>
        {
            entity.HasKey(e => e.NDistrictKey);

            entity.ToTable("TMDistrict");

            entity.Property(e => e.NDistrictKey)
                .ValueGeneratedNever()
                .HasColumnName("nDistrictKey");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("dModifyDate");
            entity.Property(e => e.NProvinceKey).HasColumnName("nProvinceKey");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SDistrictNameEn)
                .HasMaxLength(255)
                .HasColumnName("sDistrictNameEN");
            entity.Property(e => e.SDistrictNameTh)
                .HasMaxLength(255)
                .HasColumnName("sDistrictNameTH");
            entity.Property(e => e.SModifyBy)
                .HasMaxLength(50)
                .HasColumnName("sModifyBy");
        });

        modelBuilder.Entity<Tmdocument>(entity =>
        {
            entity.HasKey(e => e.SDocumentId);

            entity.ToTable("TMDocument");

            entity.Property(e => e.SDocumentId)
                .HasMaxLength(2)
                .HasColumnName("sDocumentID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NMaxSize).HasColumnName("nMaxSize");
            entity.Property(e => e.NOrder).HasColumnName("nOrder");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SDocumentName)
                .HasMaxLength(255)
                .HasColumnName("sDocumentName");
            entity.Property(e => e.SExtension)
                .HasMaxLength(50)
                .HasColumnName("sExtension");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<Tmmenu>(entity =>
        {
            entity.HasKey(e => e.NMenuId);

            entity.ToTable("TMMenu");

            entity.Property(e => e.NMenuId)
                .ValueGeneratedNever()
                .HasColumnName("nMenuID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NMenuOrder).HasColumnName("nMenuOrder");
            entity.Property(e => e.NMenuParentId).HasColumnName("nMenuParentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SMenuCode)
                .HasMaxLength(10)
                .HasColumnName("sMenuCode");
            entity.Property(e => e.SMenuDescEn)
                .HasMaxLength(250)
                .HasColumnName("sMenuDescEN");
            entity.Property(e => e.SMenuDescTh)
                .HasMaxLength(250)
                .HasColumnName("sMenuDescTH");
            entity.Property(e => e.SMenuGroupId)
                .HasMaxLength(1)
                .HasColumnName("sMenuGroupID");
            entity.Property(e => e.SMenuUrl)
                .HasMaxLength(250)
                .HasColumnName("sMenuURL");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmmenuBackup20210927>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMMenu_Backup_20210927");

            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NMenuId).HasColumnName("nMenuID");
            entity.Property(e => e.NMenuOrder).HasColumnName("nMenuOrder");
            entity.Property(e => e.NMenuParentId).HasColumnName("nMenuParentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SMenuCode)
                .HasMaxLength(10)
                .HasColumnName("sMenuCode");
            entity.Property(e => e.SMenuDescEn)
                .HasMaxLength(250)
                .HasColumnName("sMenuDescEN");
            entity.Property(e => e.SMenuDescTh)
                .HasMaxLength(250)
                .HasColumnName("sMenuDescTH");
            entity.Property(e => e.SMenuGroupId)
                .HasMaxLength(1)
                .HasColumnName("sMenuGroupID");
            entity.Property(e => e.SMenuUrl)
                .HasMaxLength(250)
                .HasColumnName("sMenuURL");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmmenuBackupSp16>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMMenu_Backup_SP16");

            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NMenuId).HasColumnName("nMenuID");
            entity.Property(e => e.NMenuOrder).HasColumnName("nMenuOrder");
            entity.Property(e => e.NMenuParentId).HasColumnName("nMenuParentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SMenuCode)
                .HasMaxLength(10)
                .HasColumnName("sMenuCode");
            entity.Property(e => e.SMenuDescEn)
                .HasMaxLength(250)
                .HasColumnName("sMenuDescEN");
            entity.Property(e => e.SMenuDescTh)
                .HasMaxLength(250)
                .HasColumnName("sMenuDescTH");
            entity.Property(e => e.SMenuGroupId)
                .HasMaxLength(1)
                .HasColumnName("sMenuGroupID");
            entity.Property(e => e.SMenuUrl)
                .HasMaxLength(250)
                .HasColumnName("sMenuURL");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmmenuGroup>(entity =>
        {
            entity.HasKey(e => e.SMenuGroupId);

            entity.ToTable("TMMenuGroup");

            entity.Property(e => e.SMenuGroupId)
                .HasMaxLength(1)
                .HasColumnName("sMenuGroupID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SMenuGroupName)
                .HasMaxLength(50)
                .HasColumnName("sMenuGroupName");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<Tmprovince>(entity =>
        {
            entity.HasKey(e => e.NProvinceKey);

            entity.ToTable("TMProvince");

            entity.Property(e => e.NProvinceKey)
                .ValueGeneratedNever()
                .HasColumnName("nProvinceKey");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("dModifyDate");
            entity.Property(e => e.NGeoId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nGeoID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SModifyBy)
                .HasMaxLength(50)
                .HasColumnName("sModifyBy");
            entity.Property(e => e.SProvinceNameEn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("sProvinceNameEN");
            entity.Property(e => e.SProvinceNameTh)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("sProvinceNameTH");
            entity.Property(e => e.SProvinceShort)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sProvinceShort");
        });

        modelBuilder.Entity<TmreasonApprove>(entity =>
        {
            entity.HasKey(e => e.NReasonApproveId);

            entity.ToTable("TMReasonApprove");

            entity.Property(e => e.NReasonApproveId).HasColumnName("nReasonApproveID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NOrder).HasColumnName("nOrder");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SReasonApproveNameEn)
                .HasMaxLength(250)
                .HasColumnName("sReasonApproveNameEN");
            entity.Property(e => e.SReasonApproveNameTh)
                .HasMaxLength(250)
                .HasColumnName("sReasonApproveNameTH");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmreasonReject>(entity =>
        {
            entity.HasKey(e => e.NReasonRejectId);

            entity.ToTable("TMReasonReject");

            entity.Property(e => e.NReasonRejectId).HasColumnName("nReasonRejectID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NOrder).HasColumnName("nOrder");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SReasonRejectNameEn)
                .HasMaxLength(250)
                .HasColumnName("sReasonRejectNameEN");
            entity.Property(e => e.SReasonRejectNameTh)
                .HasMaxLength(250)
                .HasColumnName("sReasonRejectNameTH");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(250)
                .HasColumnName("sUpdateBy");
        });

        modelBuilder.Entity<TmsubDistrict>(entity =>
        {
            entity.HasKey(e => e.NSubDistrictKey);

            entity.ToTable("TMSubDistrict");

            entity.Property(e => e.NSubDistrictKey)
                .ValueGeneratedNever()
                .HasColumnName("nSubDistrictKey");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("dModifyDate");
            entity.Property(e => e.NDistrictKey).HasColumnName("nDistrictKey");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SModifyBy)
                .HasMaxLength(50)
                .HasColumnName("sModifyBy");
            entity.Property(e => e.SSubDistrictCode)
                .HasMaxLength(255)
                .HasColumnName("sSubDistrictCode");
            entity.Property(e => e.SSubDistrictNameEn)
                .HasMaxLength(255)
                .HasColumnName("sSubDistrictNameEN");
            entity.Property(e => e.SSubDistrictNameTh)
                .HasMaxLength(255)
                .HasColumnName("sSubDistrictNameTH");
        });

        modelBuilder.Entity<TmtitleName>(entity =>
        {
            entity.HasKey(e => e.NTitleKey);

            entity.ToTable("TMTitleName");

            entity.Property(e => e.NTitleKey)
                .ValueGeneratedNever()
                .HasColumnName("nTitleKey");
            entity.Property(e => e.BIsActive).HasColumnName("bIsActive");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.NTitleOrder).HasColumnName("nTitleOrder");
            entity.Property(e => e.SAfsMappingCode)
                .HasMaxLength(50)
                .HasColumnName("sAfsMappingCode");
            entity.Property(e => e.SCustomerType)
                .HasMaxLength(50)
                .HasColumnName("sCustomerType");
            entity.Property(e => e.SEnglishTitle)
                .HasMaxLength(50)
                .HasColumnName("sEnglishTitle");
            entity.Property(e => e.SFullTitleDescription)
                .HasMaxLength(250)
                .IsFixedLength()
                .HasColumnName("sFullTitleDescription");
            entity.Property(e => e.SGender)
                .HasMaxLength(50)
                .HasColumnName("sGender");
            entity.Property(e => e.SGenderThai)
                .HasMaxLength(50)
                .HasColumnName("sGenderThai");
            entity.Property(e => e.STitleDescription)
                .HasMaxLength(50)
                .HasColumnName("sTitleDescription");
        });

        modelBuilder.Entity<TmverifyRejectDetail>(entity =>
        {
            entity.HasKey(e => e.NVerifyRejectDetailId);

            entity.ToTable("TMVerifyRejectDetail");

            entity.Property(e => e.NVerifyRejectDetailId).HasColumnName("nVerifyRejectDetailID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.BInvalidAddress).HasColumnName("bInvalidAddress");
            entity.Property(e => e.BInvalidBankAccount).HasColumnName("bInvalidBankAccount");
            entity.Property(e => e.BInvalidCitizen).HasColumnName("bInvalidCitizen");
            entity.Property(e => e.BInvalidLicenseNo).HasColumnName("bInvalidLicenseNo");
            entity.Property(e => e.BInvalidSelfie).HasColumnName("bInvalidSelfie");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");

            entity.HasOne(d => d.SAgent).WithMany(p => p.TmverifyRejectDetails)
                .HasForeignKey(d => d.SAgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMVerifyRejectDetail_TMAgent");
        });

        modelBuilder.Entity<TmverifyStatus>(entity =>
        {
            entity.HasKey(e => e.SVerifyStatusId);

            entity.ToTable("TMVerifyStatus");

            entity.Property(e => e.SVerifyStatusId)
                .HasMaxLength(2)
                .HasColumnName("sVerifyStatusID");
            entity.Property(e => e.BEnable).HasColumnName("bEnable");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
            entity.Property(e => e.SVerifyStatusNameEn)
                .HasMaxLength(50)
                .HasColumnName("sVerifyStatusNameEN");
            entity.Property(e => e.SVerifyStatusNameTh)
                .HasMaxLength(50)
                .HasColumnName("sVerifyStatusNameTH");
        });

        modelBuilder.Entity<TmzipCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMZipCode");

            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("dModifyDate");
            entity.Property(e => e.NDistrictKey).HasColumnName("nDistrictKey");
            entity.Property(e => e.NZipCodeKey).HasColumnName("nZipCodeKey");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SModifyBy)
                .HasMaxLength(50)
                .HasColumnName("sModifyBy");
            entity.Property(e => e.SPostOffice)
                .HasMaxLength(100)
                .HasColumnName("sPostOffice");
            entity.Property(e => e.SRemark)
                .HasMaxLength(255)
                .HasColumnName("sRemark");
            entity.Property(e => e.SZipCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sZipCode");
        });

        modelBuilder.Entity<TtdverifyRegisterDetail>(entity =>
        {
            entity.HasKey(e => e.SVerifyRegisterDetailId);

            entity.ToTable("TTDVerifyRegisterDetail");

            entity.Property(e => e.SVerifyRegisterDetailId)
                .HasMaxLength(50)
                .HasColumnName("sVerifyRegisterDetailID");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.NReasonApproveId).HasColumnName("nReasonApproveID");
            entity.Property(e => e.NReasonRejectId).HasColumnName("nReasonRejectID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
            entity.Property(e => e.SUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("sUpdateDate");
            entity.Property(e => e.SVerifyRegisterId)
                .HasMaxLength(50)
                .HasColumnName("sVerifyRegisterID");

            entity.HasOne(d => d.NReasonApprove).WithMany(p => p.TtdverifyRegisterDetails)
                .HasForeignKey(d => d.NReasonApproveId)
                .HasConstraintName("FK_TTDVerifyRegisterDetail_TMReasonApprove");

            entity.HasOne(d => d.NReasonReject).WithMany(p => p.TtdverifyRegisterDetails)
                .HasForeignKey(d => d.NReasonRejectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TTDVerifyRegisterDetail_TMReasonReject");

            entity.HasOne(d => d.SVerifyRegister).WithMany(p => p.TtdverifyRegisterDetails)
                .HasForeignKey(d => d.SVerifyRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TTDVerifyRegisterDetail_TTHVerifyRegister");
        });

        modelBuilder.Entity<TtgenerateRunningNo>(entity =>
        {
            entity.HasKey(e => e.SRunningType).HasName("PK_TTGenerateRunningNo_1");

            entity.ToTable("TTGenerateRunningNo");

            entity.Property(e => e.SRunningType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sRunningType");
            entity.Property(e => e.NCurrentRunningNo).HasColumnName("nCurrentRunningNo");
        });

        modelBuilder.Entity<TthverifyRegister>(entity =>
        {
            entity.HasKey(e => e.SVerifyRegisterId);

            entity.ToTable("TTHVerifyRegister");

            entity.Property(e => e.SVerifyRegisterId)
                .HasMaxLength(50)
                .HasColumnName("sVerifyRegisterID");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.DVerifyDate)
                .HasColumnType("datetime")
                .HasColumnName("dVerifyDate");
            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.SCreateBy)
                .HasMaxLength(50)
                .HasColumnName("sCreateBy");
            entity.Property(e => e.SRemark)
                .HasMaxLength(255)
                .HasColumnName("sRemark");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
            entity.Property(e => e.SVerifyStatusId)
                .HasMaxLength(2)
                .HasColumnName("sVerifyStatusID");

            entity.HasOne(d => d.SAgent).WithMany(p => p.TthverifyRegisters)
                .HasForeignKey(d => d.SAgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TTHVerifyRegister_TMAgent");

            entity.HasOne(d => d.SVerifyStatus).WithMany(p => p.TthverifyRegisters)
                .HasForeignKey(d => d.SVerifyStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TTHVerifyRegister_TMVerifyStatus");
        });

        modelBuilder.Entity<TtverifyProfileAgent>(entity =>
        {
            entity.HasKey(e => e.SVerifyProfileAgentId);

            entity.ToTable("TTVerifyProfileAgent");

            entity.Property(e => e.SVerifyProfileAgentId)
                .HasMaxLength(50)
                .HasColumnName("sVerifyProfileAgentID");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dUpdateDate");
            entity.Property(e => e.DVerifyDate)
                .HasColumnType("datetime")
                .HasColumnName("dVerifyDate");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SAgentId)
                .HasMaxLength(50)
                .HasColumnName("sAgentID");
            entity.Property(e => e.SAgentProfileTypeId)
                .HasMaxLength(2)
                .HasColumnName("sAgentProfileTypeID");
            entity.Property(e => e.SCredateBy)
                .HasMaxLength(50)
                .HasColumnName("sCredateBy");
            entity.Property(e => e.SRefDocumentId).HasColumnName("sRefDocumentID");
            entity.Property(e => e.SRefId).HasColumnName("sRefID");
            entity.Property(e => e.SUpdateBy)
                .HasMaxLength(50)
                .HasColumnName("sUpdateBy");
            entity.Property(e => e.SVerifyBy)
                .HasMaxLength(50)
                .HasColumnName("sVerifyBy");
            entity.Property(e => e.SVerifyStatusId)
                .HasMaxLength(2)
                .HasColumnName("sVerifyStatusID");

            entity.HasOne(d => d.SAgent).WithMany(p => p.TtverifyProfileAgents)
                .HasForeignKey(d => d.SAgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TTVerifyProfileAgent_TMAgent");

            entity.HasOne(d => d.SAgentProfileType).WithMany(p => p.TtverifyProfileAgents)
                .HasForeignKey(d => d.SAgentProfileTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TTVerifyProfileAgent_TMAgentProfileType");

            entity.HasOne(d => d.SVerifyStatus).WithMany(p => p.TtverifyProfileAgents)
                .HasForeignKey(d => d.SVerifyStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TTVerifyProfileAgent_TMVerifyStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

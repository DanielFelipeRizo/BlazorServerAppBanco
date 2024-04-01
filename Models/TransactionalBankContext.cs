using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerAppBanco.Models;

public partial class TransactionalBankContext : DbContext
{
    public TransactionalBankContext()
    {
    }

    public TransactionalBankContext(DbContextOptions<TransactionalBankContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuditInitialization> AuditInitializations { get; set; }

    public virtual DbSet<AuditTransaction> AuditTransactions { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<BranchesTransactionsHour> BranchesTransactionsHours { get; set; }

    public virtual DbSet<Capk> Capks { get; set; }

    public virtual DbSet<CapksExponent> CapksExponents { get; set; }

    public virtual DbSet<CapksRid> CapksRids { get; set; }

    public virtual DbSet<CapksSize> CapksSizes { get; set; }

    public virtual DbSet<CardType> CardTypes { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Commerce> Commerces { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CreditPayment> CreditPayments { get; set; }

    public virtual DbSet<CtlFile> CtlFiles { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<DayTransaction> DayTransactions { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Deposit> Deposits { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<DeviceBrand> DeviceBrands { get; set; }

    public virtual DbSet<DeviceInterface> DeviceInterfaces { get; set; }

    public virtual DbSet<DeviceModel> DeviceModels { get; set; }

    public virtual DbSet<DeviceTag> DeviceTags { get; set; }

    public virtual DbSet<DeviceType> DeviceTypes { get; set; }

    public virtual DbSet<EmvappsAid> EmvappsAids { get; set; }

    public virtual DbSet<EmvappsDetail> EmvappsDetails { get; set; }

    public virtual DbSet<EmvappsMaster> EmvappsMasters { get; set; }

    public virtual DbSet<EmvappsTag> EmvappsTags { get; set; }

    public virtual DbSet<Encryptor> Encryptors { get; set; }

    public virtual DbSet<HistoricalCreditPayment> HistoricalCreditPayments { get; set; }

    public virtual DbSet<HistoricalDeposit> HistoricalDeposits { get; set; }

    public virtual DbSet<HistoricalPaymentService> HistoricalPaymentServices { get; set; }

    public virtual DbSet<HistoricalWithdrawal> HistoricalWithdrawals { get; set; }

    public virtual DbSet<LicenseForCustomer> LicenseForCustomers { get; set; }

    public virtual DbSet<LicenseType> LicenseTypes { get; set; }

    public virtual DbSet<LogTransaction> LogTransactions { get; set; }

    public virtual DbSet<LogsFunction> LogsFunctions { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<ModulesSubmodulesApp> ModulesSubmodulesApps { get; set; }

    public virtual DbSet<ObfuscationField> ObfuscationFields { get; set; }

    public virtual DbSet<ObfuscationRule> ObfuscationRules { get; set; }

    public virtual DbSet<ObfuscationRuleType> ObfuscationRuleTypes { get; set; }

    public virtual DbSet<PaymentService> PaymentServices { get; set; }

    public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<Range> Ranges { get; set; }

    public virtual DbSet<Representative> Representatives { get; set; }

    public virtual DbSet<RepresentativeIdentificationType> RepresentativeIdentificationTypes { get; set; }

    public virtual DbSet<ScLog> ScLogs { get; set; }

    public virtual DbSet<SecApp> SecApps { get; set; }

    public virtual DbSet<SecEmail> SecEmails { get; set; }

    public virtual DbSet<SecGroup> SecGroups { get; set; }

    public virtual DbSet<SecGroupsApp> SecGroupsApps { get; set; }

    public virtual DbSet<SecUser> SecUsers { get; set; }

    public virtual DbSet<SecUsersKeyHistory> SecUsersKeyHistories { get; set; }

    public virtual DbSet<StatusType> StatusTypes { get; set; }

    public virtual DbSet<Submodule> Submodules { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<TemplateBranchesHour> TemplateBranchesHours { get; set; }

    public virtual DbSet<TemplateCapk> TemplateCapks { get; set; }

    public virtual DbSet<TemplateEmvapp> TemplateEmvapps { get; set; }

    public virtual DbSet<TemplateRange> TemplateRanges { get; set; }

    public virtual DbSet<TemplateTransaction> TemplateTransactions { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TypesCommerce> TypesCommerces { get; set; }

    public virtual DbSet<UpdateStatusDevice> UpdateStatusDevices { get; set; }

    public virtual DbSet<UserTag> UserTags { get; set; }

    public virtual DbSet<Withdrawal> Withdrawals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=transactional_bank;Username=postgres;Password=12345");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuditInitialization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audit_initialization_pkey");

            entity.ToTable("audit_initialization", "bank");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(100)
                .HasColumnName("device_id");
            entity.Property(e => e.EndDate)
                .HasMaxLength(100)
                .HasColumnName("end_date");
            entity.Property(e => e.HostIp)
                .HasMaxLength(100)
                .HasColumnName("host_ip");
            entity.Property(e => e.HostMessage).HasColumnName("host_message");
            entity.Property(e => e.HostPort)
                .HasMaxLength(100)
                .HasColumnName("host_port");
            entity.Property(e => e.Node)
                .HasMaxLength(100)
                .HasColumnName("node");
            entity.Property(e => e.PosIp)
                .HasMaxLength(100)
                .HasColumnName("pos_ip");
            entity.Property(e => e.PosMessage).HasColumnName("pos_message");
            entity.Property(e => e.PosPort)
                .HasMaxLength(100)
                .HasColumnName("pos_port");
            entity.Property(e => e.Process)
                .HasMaxLength(100)
                .HasColumnName("process");
            entity.Property(e => e.ProcessCode)
                .HasMaxLength(100)
                .HasColumnName("process_code");
            entity.Property(e => e.ResponseCode)
                .HasMaxLength(100)
                .HasColumnName("response_code");
            entity.Property(e => e.ResponseMessage).HasColumnName("response_message");
            entity.Property(e => e.ResponseTime)
                .HasMaxLength(100)
                .HasColumnName("response_time");
            entity.Property(e => e.StartDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_date");
        });

        modelBuilder.Entity<AuditTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audit_transactions_pkey");

            entity.ToTable("audit_transactions", "bank");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApiAccountId)
                .HasMaxLength(200)
                .HasColumnName("api_account_id");
            entity.Property(e => e.ApiCityId)
                .HasMaxLength(200)
                .HasColumnName("api_city_id");
            entity.Property(e => e.ApiCompanyId)
                .HasMaxLength(200)
                .HasColumnName("api_company_id");
            entity.Property(e => e.ApiCorrespondentId)
                .HasMaxLength(200)
                .HasColumnName("api_correspondent_id");
            entity.Property(e => e.ApiCustomerCode)
                .HasMaxLength(200)
                .HasColumnName("api_customer_code");
            entity.Property(e => e.ApiDocument)
                .HasMaxLength(200)
                .HasColumnName("api_document");
            entity.Property(e => e.ApiEndDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("api_end_date");
            entity.Property(e => e.ApiErrorCode)
                .HasMaxLength(200)
                .HasColumnName("api_error_code");
            entity.Property(e => e.ApiErrorDescription)
                .HasMaxLength(200)
                .HasColumnName("api_error_description");
            entity.Property(e => e.ApiFinancialAccountNumber)
                .HasMaxLength(200)
                .HasColumnName("api_financial_account_number");
            entity.Property(e => e.ApiIdCard)
                .HasMaxLength(200)
                .HasColumnName("api_id_card");
            entity.Property(e => e.ApiInvoiceName)
                .HasMaxLength(200)
                .HasColumnName("api_invoice_name");
            entity.Property(e => e.ApiJsonRequest).HasColumnName("api_json_request");
            entity.Property(e => e.ApiJsonResponse).HasColumnName("api_json_response");
            entity.Property(e => e.ApiReceiptId)
                .HasMaxLength(200)
                .HasColumnName("api_receipt_id");
            entity.Property(e => e.ApiSearchTypeId)
                .HasMaxLength(200)
                .HasColumnName("api_search_type_id");
            entity.Property(e => e.ApiServiceAccount)
                .HasMaxLength(200)
                .HasColumnName("api_service_account");
            entity.Property(e => e.ApiServiceTypeId)
                .HasMaxLength(200)
                .HasColumnName("api_service_type_id");
            entity.Property(e => e.ApiStartDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("api_start_date");
            entity.Property(e => e.ApiToken)
                .HasMaxLength(200)
                .HasColumnName("api_token");
            entity.Property(e => e.ApiTotalTime)
                .HasMaxLength(300)
                .HasColumnName("api_total_time");
            entity.Property(e => e.ApiTraceNumber)
                .HasMaxLength(200)
                .HasColumnName("api_trace_number");
            entity.Property(e => e.ApiTransactionId)
                .HasMaxLength(200)
                .HasColumnName("api_transaction_id");
            entity.Property(e => e.ApiTransactionType)
                .HasMaxLength(200)
                .HasColumnName("api_transaction_type");
            entity.Property(e => e.ApiUser)
                .HasMaxLength(200)
                .HasColumnName("api_user");
            entity.Property(e => e.ApiWpossTransactionId)
                .HasMaxLength(200)
                .HasColumnName("api_wposs_transaction_id");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(100)
                .HasColumnName("device_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_date");
            entity.Property(e => e.HostIp)
                .HasMaxLength(200)
                .HasColumnName("host_ip");
            entity.Property(e => e.HostMessage).HasColumnName("host_message");
            entity.Property(e => e.HostPort)
                .HasMaxLength(200)
                .HasColumnName("host_port");
            entity.Property(e => e.Node)
                .HasMaxLength(200)
                .HasColumnName("node");
            entity.Property(e => e.PosIp)
                .HasMaxLength(200)
                .HasColumnName("pos_ip");
            entity.Property(e => e.PosMessage).HasColumnName("pos_message");
            entity.Property(e => e.PosPort)
                .HasMaxLength(200)
                .HasColumnName("pos_port");
            entity.Property(e => e.Process)
                .HasMaxLength(100)
                .HasColumnName("process");
            entity.Property(e => e.ProcessCode)
                .HasMaxLength(100)
                .HasColumnName("process_code");
            entity.Property(e => e.ResponseCode)
                .HasMaxLength(100)
                .HasColumnName("response_code");
            entity.Property(e => e.ResponseMessage).HasColumnName("response_message");
            entity.Property(e => e.ResponseTime)
                .HasMaxLength(300)
                .HasColumnName("response_time");
            entity.Property(e => e.StartDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_date");
            entity.Property(e => e.Uuid)
                .HasMaxLength(200)
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("branches_pkey");

            entity.ToTable("branches", "bank");

            entity.Property(e => e.BranchId)
                .HasDefaultValueSql("nextval('branches_branch_id_seq'::regclass)")
                .HasColumnName("branch_id");
            entity.Property(e => e.Address)
                .HasMaxLength(600)
                .HasColumnName("address");
            entity.Property(e => e.AuxiliaryLine)
                .HasMaxLength(100)
                .HasColumnName("auxiliary_line");
            entity.Property(e => e.BaseUrl)
                .HasMaxLength(250)
                .HasColumnName("base_url");
            entity.Property(e => e.BaseUrlToken)
                .HasMaxLength(250)
                .HasColumnName("base_url_token");
            entity.Property(e => e.BaseUrlTransactional)
                .HasMaxLength(250)
                .HasColumnName("base_url_transactional");
            entity.Property(e => e.CardAccpMerch)
                .HasMaxLength(100)
                .HasColumnName("card_accp_merch");
            entity.Property(e => e.City)
                .HasMaxLength(150)
                .HasColumnName("city");
            entity.Property(e => e.ClosingDays).HasColumnName("closing_days");
            entity.Property(e => e.CommerceId).HasColumnName("commerce_id");
            entity.Property(e => e.Country)
                .HasMaxLength(150)
                .HasColumnName("country");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.Department)
                .HasMaxLength(150)
                .HasColumnName("department");
            entity.Property(e => e.EnableSignature).HasColumnName("enable_signature");
            entity.Property(e => e.IsMainBranch).HasColumnName("is_main_branch");
            entity.Property(e => e.Name)
                .HasMaxLength(600)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasColumnName("phone");
            entity.Property(e => e.ProfileId).HasColumnName("profile_id");
            entity.Property(e => e.RepresentativeId).HasColumnName("representative_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasColumnName("status");
            entity.Property(e => e.TransactionHoursDaysId)
                .HasMaxLength(200)
                .HasColumnName("transaction_hours_days_id");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_date");
            entity.Property(e => e.VirtualCardNumber)
                .HasMaxLength(100)
                .HasColumnName("virtual_card_number");

            entity.HasOne(d => d.Commerce).WithMany(p => p.Branches)
                .HasForeignKey(d => d.CommerceId)
                .HasConstraintName("fk_branches_commerce");

            entity.HasOne(d => d.Representative).WithMany(p => p.Branches)
                .HasForeignKey(d => d.RepresentativeId)
                .HasConstraintName("fk_branches_representative");

            entity.HasOne(d => d.TransactionHoursDays).WithMany(p => p.Branches)
                .HasForeignKey(d => d.TransactionHoursDaysId)
                .HasConstraintName("fk_branches_transaction_hours_days");
        });

        modelBuilder.Entity<BranchesTransactionsHour>(entity =>
        {
            entity.HasKey(e => e.BranchTransactionHoursId).HasName("branches_transactions_hours_pkey");

            entity.ToTable("branches_transactions_hours", "bank");

            entity.Property(e => e.BranchTransactionHoursId)
                .HasDefaultValueSql("nextval('branches_transactions_hours_branch_transaction_hours_id_seq'::regclass)")
                .HasColumnName("branch_transaction_hours_id");
            entity.Property(e => e.BusinessDays)
                .HasMaxLength(50)
                .HasColumnName("business_days");
            entity.Property(e => e.DaysMondaySunday)
                .HasMaxLength(50)
                .HasColumnName("days_monday_sunday");
            entity.Property(e => e.EndTimeTransaction).HasColumnName("end_time_transaction");
            entity.Property(e => e.StartTimeTransaction).HasColumnName("start_time_transaction");
            entity.Property(e => e.TemplateId)
                .HasMaxLength(500)
                .HasColumnName("template_id");

            entity.HasOne(d => d.BusinessDaysNavigation).WithMany(p => p.BranchesTransactionsHours)
                .HasForeignKey(d => d.BusinessDays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_business_days");

            entity.HasOne(d => d.Template).WithMany(p => p.BranchesTransactionsHours)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_template_branch_hours");
        });

        modelBuilder.Entity<Capk>(entity =>
        {
            entity.HasKey(e => new { e.TemplateId, e.KeyId, e.KeyRid }).HasName("capks_pkey");

            entity.ToTable("capks", "bank");

            entity.Property(e => e.TemplateId)
                .HasMaxLength(500)
                .HasColumnName("template_id");
            entity.Property(e => e.KeyId)
                .HasMaxLength(100)
                .HasColumnName("key_id");
            entity.Property(e => e.KeyRid)
                .HasMaxLength(100)
                .HasColumnName("key_rid");
            entity.Property(e => e.KeyExpirationDate).HasColumnName("key_expiration_date");
            entity.Property(e => e.KeyExponent)
                .HasMaxLength(100)
                .HasColumnName("key_exponent");
            entity.Property(e => e.KeyModule)
                .HasMaxLength(4000)
                .HasColumnName("key_module");
            entity.Property(e => e.KeySha1)
                .HasMaxLength(200)
                .HasColumnName("key_sha1");
            entity.Property(e => e.KeySize)
                .HasMaxLength(200)
                .HasColumnName("key_size");

            entity.HasOne(d => d.KeyExponentNavigation).WithMany(p => p.Capks)
                .HasForeignKey(d => d.KeyExponent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("capks_key_exponent_fkey");

            entity.HasOne(d => d.KeyR).WithMany(p => p.Capks)
                .HasForeignKey(d => d.KeyRid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("capks_key_rid_fkey");

            entity.HasOne(d => d.KeySizeNavigation).WithMany(p => p.Capks)
                .HasForeignKey(d => d.KeySize)
                .HasConstraintName("capks_key_size_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.Capks)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("capks_template_id_fkey");
        });

        modelBuilder.Entity<CapksExponent>(entity =>
        {
            entity.HasKey(e => e.KeyExponent).HasName("capks_exponents_pkey");

            entity.ToTable("capks_exponents", "bank");

            entity.Property(e => e.KeyExponent)
                .HasMaxLength(100)
                .HasColumnName("key_exponent");
        });

        modelBuilder.Entity<CapksRid>(entity =>
        {
            entity.HasKey(e => e.KeyRid).HasName("capks_rids_pkey");

            entity.ToTable("capks_rids", "bank");

            entity.HasIndex(e => e.Provider, "unique_provider").IsUnique();

            entity.Property(e => e.KeyRid)
                .HasMaxLength(100)
                .HasColumnName("key_rid");
            entity.Property(e => e.Provider)
                .HasMaxLength(200)
                .HasColumnName("provider");
        });

        modelBuilder.Entity<CapksSize>(entity =>
        {
            entity.HasKey(e => e.KeySize).HasName("capks_sizes_pkey");

            entity.ToTable("capks_sizes", "bank");

            entity.Property(e => e.KeySize)
                .HasMaxLength(200)
                .HasColumnName("key_size");
        });

        modelBuilder.Entity<CardType>(entity =>
        {
            entity.HasKey(e => e.CardTypeId).HasName("pk_card_type_id");

            entity.ToTable("card_type", "bank");

            entity.Property(e => e.CardTypeId)
                .HasDefaultValueSql("nextval('card_type_card_type_id_seq'::regclass)")
                .HasColumnName("card_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("cities_pkey");

            entity.ToTable("cities", "bank");

            entity.HasIndex(e => e.Code, "cities_code_key").IsUnique();

            entity.Property(e => e.CityId)
                .HasDefaultValueSql("nextval('cities_city_id_seq'::regclass)")
                .HasColumnName("city_id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Country)
                .HasMaxLength(200)
                .HasColumnName("country");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");

            entity.HasOne(d => d.Department).WithMany(p => p.Cities)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("cities_department_id_fkey");
        });

        modelBuilder.Entity<Commerce>(entity =>
        {
            entity.HasKey(e => e.CommerceId).HasName("pk_commerce");

            entity.ToTable("commerces", "bank");

            entity.Property(e => e.CommerceId)
                .HasDefaultValueSql("nextval('commerces_commerce_id_seq'::regclass)")
                .HasColumnName("commerce_id");
            entity.Property(e => e.AsfiCommerce)
                .HasMaxLength(600)
                .HasColumnName("asfi_commerce");
            entity.Property(e => e.CommerceStartDate).HasColumnName("commerce_start_date");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.Name)
                .HasMaxLength(600)
                .HasColumnName("name");
            entity.Property(e => e.ProfileId).HasColumnName("profile_id");
            entity.Property(e => e.RepresentativeId).HasColumnName("representative_id");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.TypeCommerce).HasColumnName("type_commerce");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_date");

            entity.HasOne(d => d.Profile).WithMany(p => p.Commerces)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("fk_commerce_profile");

            entity.HasOne(d => d.Representative).WithMany(p => p.Commerces)
                .HasForeignKey(d => d.RepresentativeId)
                .HasConstraintName("fk_commerce_representative");

            entity.HasOne(d => d.TypeCommerceNavigation).WithMany(p => p.Commerces)
                .HasForeignKey(d => d.TypeCommerce)
                .HasConstraintName("fk_type_commerce");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("countries_pkey");

            entity.ToTable("countries", "bank");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Area)
                .HasDefaultValueSql("0.00")
                .HasColumnName("area");
            entity.Property(e => e.Continent)
                .HasMaxLength(200)
                .HasDefaultValueSql("'South America'::character varying")
                .HasColumnName("continent");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Region)
                .HasMaxLength(200)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("region");
        });

        modelBuilder.Entity<CreditPayment>(entity =>
        {
            entity.HasKey(e => e.CreditPaymentId).HasName("credit_payment_pkey");

            entity.ToTable("credit_payment", "bank");

            entity.Property(e => e.CreditPaymentId)
                .HasDefaultValueSql("nextval('credit_payment_credit_payment_id_seq'::regclass)")
                .HasColumnName("credit_payment_id");
            entity.Property(e => e.Amount)
                .HasMaxLength(200)
                .HasColumnName("amount");
            entity.Property(e => e.AmountCurrency)
                .HasMaxLength(200)
                .HasColumnName("amount_currency");
            entity.Property(e => e.AnnualPercentageRateCost)
                .HasMaxLength(200)
                .HasColumnName("annual_percentage_rate_cost");
            entity.Property(e => e.AsfiCommerce)
                .HasMaxLength(300)
                .HasColumnName("asfi_commerce");
            entity.Property(e => e.AuthorizationCode)
                .HasMaxLength(200)
                .HasColumnName("authorization_code");
            entity.Property(e => e.BranchAddress)
                .HasMaxLength(200)
                .HasColumnName("branch_address");
            entity.Property(e => e.BranchId)
                .HasMaxLength(200)
                .HasColumnName("branch_id");
            entity.Property(e => e.Capital)
                .HasMaxLength(200)
                .HasColumnName("capital");
            entity.Property(e => e.Channel)
                .HasMaxLength(200)
                .HasColumnName("channel");
            entity.Property(e => e.CommerceId)
                .HasMaxLength(200)
                .HasColumnName("commerce_id");
            entity.Property(e => e.CommerceName)
                .HasMaxLength(200)
                .HasColumnName("commerce_name");
            entity.Property(e => e.CorrespondentId)
                .HasMaxLength(200)
                .HasColumnName("correspondent_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(200)
                .HasColumnName("created_date");
            entity.Property(e => e.CreditOperationIdentifier)
                .HasMaxLength(200)
                .HasColumnName("credit_operation_identifier");
            entity.Property(e => e.DateTransaction)
                .HasMaxLength(200)
                .HasColumnName("date_transaction");
            entity.Property(e => e.DebitAccountIdentifier)
                .HasMaxLength(200)
                .HasColumnName("debit_account_identifier");
            entity.Property(e => e.DeferredAmount)
                .HasMaxLength(200)
                .HasColumnName("deferred_amount");
            entity.Property(e => e.DeferredInterest)
                .HasMaxLength(200)
                .HasColumnName("deferred_interest");
            entity.Property(e => e.Device)
                .HasMaxLength(200)
                .HasColumnName("device");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(200)
                .HasColumnName("device_id");
            entity.Property(e => e.DeviceIp)
                .HasMaxLength(200)
                .HasColumnName("device_ip");
            entity.Property(e => e.ExchangeRate)
                .HasMaxLength(200)
                .HasColumnName("exchange_rate");
            entity.Property(e => e.FinancialTransactionTax)
                .HasMaxLength(200)
                .HasColumnName("financial_transaction_tax");
            entity.Property(e => e.InsuranceDes)
                .HasMaxLength(200)
                .HasColumnName("insurance_des");
            entity.Property(e => e.Interest)
                .HasMaxLength(200)
                .HasColumnName("interest");
            entity.Property(e => e.JudicialExpenses)
                .HasMaxLength(200)
                .HasColumnName("judicial_expenses");
            entity.Property(e => e.Nit)
                .HasMaxLength(200)
                .HasColumnName("nit");
            entity.Property(e => e.OperationCurrency)
                .HasMaxLength(200)
                .HasColumnName("operation_currency");
            entity.Property(e => e.PaymentIdentifier)
                .HasMaxLength(200)
                .HasColumnName("payment_identifier");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(200)
                .HasColumnName("payment_method");
            entity.Property(e => e.PenaltyInterest)
                .HasMaxLength(200)
                .HasColumnName("penalty_interest");
            entity.Property(e => e.Phone)
                .HasMaxLength(200)
                .HasColumnName("phone");
            entity.Property(e => e.Regional)
                .HasMaxLength(300)
                .HasColumnName("regional");
            entity.Property(e => e.RepresentativeDocument)
                .HasMaxLength(200)
                .HasColumnName("representative_document");
            entity.Property(e => e.RepresentativeName)
                .HasMaxLength(200)
                .HasColumnName("representative_name");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.TimeTransaction)
                .HasMaxLength(200)
                .HasColumnName("time_transaction");
            entity.Property(e => e.TraceNumber)
                .HasMaxLength(200)
                .HasColumnName("trace_number");
            entity.Property(e => e.TransactionCardNumber)
                .HasMaxLength(300)
                .HasColumnName("transaction_card_number");
            entity.Property(e => e.TransactionName)
                .HasMaxLength(200)
                .HasColumnName("transaction_name");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(200)
                .HasColumnName("transaction_type");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(200)
                .HasColumnName("updated_date");
            entity.Property(e => e.VoucherId)
                .HasMaxLength(200)
                .HasColumnName("voucher_id");
        });

        modelBuilder.Entity<CtlFile>(entity =>
        {
            entity.HasKey(e => e.CtlFilesId).HasName("ctl_files_pkey");

            entity.ToTable("ctl_files", "bank");

            entity.Property(e => e.CtlFilesId)
                .HasDefaultValueSql("nextval('ctl_files_ctl_files_id_seq'::regclass)")
                .HasColumnName("ctl_files_id");
            entity.Property(e => e.AppData).HasColumnName("app_data");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.FileName)
                .HasMaxLength(200)
                .HasColumnName("file_name");
            entity.Property(e => e.Hash)
                .HasMaxLength(200)
                .HasColumnName("hash");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("customer_pkey");

            entity.ToTable("customer", "bank");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('customer_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreationDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_date");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.DownloadIp)
                .HasMaxLength(100)
                .HasColumnName("download_ip");
            entity.Property(e => e.DownloadPort)
                .HasMaxLength(100)
                .HasColumnName("download_port");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.SelfLearning)
                .HasColumnType("bit(1)")
                .HasColumnName("self_learning");
            entity.Property(e => e.StatusTypeId).HasColumnName("status_type_id");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<DayTransaction>(entity =>
        {
            entity.HasKey(e => e.DayTransactionId).HasName("day_transactions_pkey");

            entity.ToTable("day_transactions", "bank");

            entity.Property(e => e.DayTransactionId)
                .HasMaxLength(100)
                .HasColumnName("day_transaction_id");
            entity.Property(e => e.OrderDays)
                .HasDefaultValueSql("nextval('day_transactions_order_days_seq'::regclass)")
                .HasColumnName("order_days");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("departments_pkey");

            entity.ToTable("departments", "bank");

            entity.Property(e => e.DepartmentId)
                .HasDefaultValueSql("nextval('departments_department_id_seq'::regclass)")
                .HasColumnName("department_id");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .HasColumnName("country_code");
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .HasColumnName("name");

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.Departments)
                .HasForeignKey(d => d.CountryCode)
                .HasConstraintName("departments_country_code_fkey");
        });

        modelBuilder.Entity<Deposit>(entity =>
        {
            entity.HasKey(e => e.DepositId).HasName("deposits_pkey");

            entity.ToTable("deposits", "bank");

            entity.Property(e => e.DepositId)
                .HasDefaultValueSql("nextval('deposits_deposit_id_seq'::regclass)")
                .HasColumnName("deposit_id");
            entity.Property(e => e.AccountId)
                .HasMaxLength(200)
                .HasColumnName("account_id");
            entity.Property(e => e.Amount)
                .HasMaxLength(200)
                .HasColumnName("amount");
            entity.Property(e => e.AsfiCommerce)
                .HasMaxLength(300)
                .HasColumnName("asfi_commerce");
            entity.Property(e => e.AuthorizationCode)
                .HasMaxLength(200)
                .HasColumnName("authorization_code");
            entity.Property(e => e.BranchAddress)
                .HasMaxLength(200)
                .HasColumnName("branch_address");
            entity.Property(e => e.BranchId)
                .HasMaxLength(200)
                .HasColumnName("branch_id");
            entity.Property(e => e.Channel)
                .HasMaxLength(200)
                .HasColumnName("channel");
            entity.Property(e => e.CommerceId)
                .HasMaxLength(200)
                .HasColumnName("commerce_id");
            entity.Property(e => e.CommerceName)
                .HasMaxLength(200)
                .HasColumnName("commerce_name");
            entity.Property(e => e.CorrespondentId)
                .HasMaxLength(200)
                .HasColumnName("correspondent_id");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(200)
                .HasColumnName("create_by");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(200)
                .HasColumnName("created_date");
            entity.Property(e => e.CreditedAccount)
                .HasMaxLength(200)
                .HasColumnName("credited_account");
            entity.Property(e => e.CreditedCurrency)
                .HasMaxLength(200)
                .HasColumnName("credited_currency");
            entity.Property(e => e.Currency)
                .HasMaxLength(200)
                .HasColumnName("currency");
            entity.Property(e => e.CurrentAccount)
                .HasMaxLength(200)
                .HasColumnName("current_account");
            entity.Property(e => e.DateTransaction)
                .HasMaxLength(200)
                .HasColumnName("date_transaction");
            entity.Property(e => e.Details)
                .HasMaxLength(1000)
                .HasColumnName("details");
            entity.Property(e => e.Device)
                .HasMaxLength(200)
                .HasColumnName("device");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(200)
                .HasColumnName("device_id");
            entity.Property(e => e.DeviceIp)
                .HasMaxLength(200)
                .HasColumnName("device_ip");
            entity.Property(e => e.ExchangeRate)
                .HasMaxLength(200)
                .HasColumnName("exchange_rate");
            entity.Property(e => e.ImportAccredited)
                .HasMaxLength(200)
                .HasColumnName("import_accredited");
            entity.Property(e => e.NameAccount)
                .HasMaxLength(200)
                .HasColumnName("name_account");
            entity.Property(e => e.Nit)
                .HasMaxLength(200)
                .HasColumnName("nit");
            entity.Property(e => e.PaymentIdentifier)
                .HasMaxLength(200)
                .HasColumnName("payment_identifier");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(200)
                .HasColumnName("payment_method");
            entity.Property(e => e.Phone)
                .HasMaxLength(200)
                .HasColumnName("phone");
            entity.Property(e => e.Regional)
                .HasMaxLength(300)
                .HasColumnName("regional");
            entity.Property(e => e.RepresentativeDocument)
                .HasMaxLength(200)
                .HasColumnName("representative_document");
            entity.Property(e => e.RepresentativeName)
                .HasMaxLength(200)
                .HasColumnName("representative_name");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.TimeTransaction)
                .HasMaxLength(200)
                .HasColumnName("time_transaction");
            entity.Property(e => e.TraceNumber)
                .HasMaxLength(200)
                .HasColumnName("trace_number");
            entity.Property(e => e.TransactionCardNumber)
                .HasMaxLength(300)
                .HasColumnName("transaction_card_number");
            entity.Property(e => e.TransactionName)
                .HasMaxLength(200)
                .HasColumnName("transaction_name");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(200)
                .HasColumnName("transaction_type");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(200)
                .HasColumnName("updated_date");
            entity.Property(e => e.VoucherId)
                .HasMaxLength(200)
                .HasColumnName("voucher_id");
        });

        modelBuilder.Entity<Device>(entity =>
        {
            entity.HasKey(e => e.DeviceId).HasName("devices_pkey");

            entity.ToTable("devices", "bank");

            entity.HasIndex(e => e.SerialNumber, "devices_serial_number_key").IsUnique();

            entity.Property(e => e.DeviceId)
                .ValueGeneratedNever()
                .HasColumnName("device_id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(200)
                .HasColumnName("account_number");
            entity.Property(e => e.AgentId)
                .HasMaxLength(100)
                .HasDefaultValueSql("'9'::character varying")
                .HasColumnName("agent_id");
            entity.Property(e => e.Apn)
                .HasMaxLength(100)
                .HasColumnName("apn");
            entity.Property(e => e.ApplicationKey)
                .HasMaxLength(100)
                .HasColumnName("application_key");
            entity.Property(e => e.BatteryLevel)
                .HasMaxLength(100)
                .HasColumnName("battery_level");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.CellPhoneNetwork)
                .HasMaxLength(100)
                .HasColumnName("cell_phone_network");
            entity.Property(e => e.CommerceId).HasColumnName("commerce_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.DeviceBrandId).HasColumnName("device_brand_id");
            entity.Property(e => e.DeviceDescription)
                .HasMaxLength(600)
                .HasColumnName("device_description");
            entity.Property(e => e.DeviceInterfaceId).HasColumnName("device_interface_id");
            entity.Property(e => e.DeviceModelId).HasColumnName("device_model_id");
            entity.Property(e => e.DeviceTagId).HasColumnName("device_tag_id");
            entity.Property(e => e.DeviceTypeId).HasColumnName("device_type_id");
            entity.Property(e => e.Imei)
                .HasMaxLength(200)
                .HasColumnName("imei");
            entity.Property(e => e.InstalledApplications).HasColumnName("installed_applications");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .HasColumnName("ip");
            entity.Property(e => e.KeyExpiryDays).HasColumnName("key_expiry_days");
            entity.Property(e => e.LastUpdatedDate).HasColumnName("last_updated_date");
            entity.Property(e => e.Latitude)
                .HasMaxLength(200)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasMaxLength(200)
                .HasColumnName("longitude");
            entity.Property(e => e.Mac)
                .HasMaxLength(100)
                .HasColumnName("mac");
            entity.Property(e => e.ProfileId).HasColumnName("profile_id");
            entity.Property(e => e.Ram)
                .HasMaxLength(100)
                .HasColumnName("ram");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(100)
                .HasColumnName("serial_number");
            entity.Property(e => e.SignalLevel)
                .HasMaxLength(100)
                .HasColumnName("signal_level");
            entity.Property(e => e.Sim)
                .HasMaxLength(100)
                .HasColumnName("sim");
            entity.Property(e => e.StatusTypeId).HasColumnName("status_type_id");
            entity.Property(e => e.UpdateStatusDeviceId).HasColumnName("update_status_device_id");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_date");
            entity.Property(e => e.ValidateImei).HasColumnName("validate_imei");
            entity.Property(e => e.ValidateSim).HasColumnName("validate_sim");

            entity.HasOne(d => d.Branch).WithMany(p => p.Devices)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("fk_branch_id");

            entity.HasOne(d => d.Commerce).WithMany(p => p.Devices)
                .HasForeignKey(d => d.CommerceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_commerce_id");

            entity.HasOne(d => d.DeviceBrand).WithMany(p => p.Devices)
                .HasForeignKey(d => d.DeviceBrandId)
                .HasConstraintName("fk_brand_id");

            entity.HasOne(d => d.DeviceInterface).WithMany(p => p.Devices)
                .HasForeignKey(d => d.DeviceInterfaceId)
                .HasConstraintName("fk_device_interface_id");

            entity.HasOne(d => d.DeviceModel).WithMany(p => p.Devices)
                .HasForeignKey(d => d.DeviceModelId)
                .HasConstraintName("fk_device_model_id");

            entity.HasOne(d => d.DeviceTag).WithMany(p => p.Devices)
                .HasForeignKey(d => d.DeviceTagId)
                .HasConstraintName("fk_device_tag_id");

            entity.HasOne(d => d.DeviceType).WithMany(p => p.Devices)
                .HasForeignKey(d => d.DeviceTypeId)
                .HasConstraintName("fk_device_type_id");

            entity.HasOne(d => d.UpdateStatusDevice).WithMany(p => p.Devices)
                .HasForeignKey(d => d.UpdateStatusDeviceId)
                .HasConstraintName("fk_update_status_id");
        });

        modelBuilder.Entity<DeviceBrand>(entity =>
        {
            entity.HasKey(e => e.DeviceBrandId).HasName("pk_device_brand_id");

            entity.ToTable("device_brands", "bank");

            entity.Property(e => e.DeviceBrandId)
                .HasDefaultValueSql("nextval('device_brands_device_brand_id_seq'::regclass)")
                .HasColumnName("device_brand_id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
        });

        modelBuilder.Entity<DeviceInterface>(entity =>
        {
            entity.HasKey(e => e.DeviceInterfaceId).HasName("pk_device_interface_id");

            entity.ToTable("device_interfaces", "bank");

            entity.Property(e => e.DeviceInterfaceId)
                .HasDefaultValueSql("nextval('device_interfaces_device_interface_id_seq'::regclass)")
                .HasColumnName("device_interface_id");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
        });

        modelBuilder.Entity<DeviceModel>(entity =>
        {
            entity.HasKey(e => e.DeviceModelId).HasName("pk_device_model_id");

            entity.ToTable("device_models", "bank");

            entity.Property(e => e.DeviceModelId)
                .HasDefaultValueSql("nextval('device_models_device_model_id_seq'::regclass)")
                .HasColumnName("device_model_id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
        });

        modelBuilder.Entity<DeviceTag>(entity =>
        {
            entity.HasKey(e => e.DeviceTagId).HasName("device_tags_pkey");

            entity.ToTable("device_tags", "bank");

            entity.Property(e => e.DeviceTagId)
                .HasDefaultValueSql("nextval('device_tags_device_tag_id_seq'::regclass)")
                .HasColumnName("device_tag_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(50)
                .HasColumnName("updated_date");
        });

        modelBuilder.Entity<DeviceType>(entity =>
        {
            entity.HasKey(e => e.DeviceTypeId).HasName("pk_device_type_id");

            entity.ToTable("device_types", "bank");

            entity.Property(e => e.DeviceTypeId)
                .HasDefaultValueSql("nextval('device_types_device_type_id_seq'::regclass)")
                .HasColumnName("device_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
        });

        modelBuilder.Entity<EmvappsAid>(entity =>
        {
            entity.HasKey(e => e.Aid).HasName("emvapps_aids_pkey");

            entity.ToTable("emvapps_aids", "bank");

            entity.HasIndex(e => e.Name, "unique_name_aids").IsUnique();

            entity.Property(e => e.Aid)
                .HasMaxLength(100)
                .HasColumnName("aid");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<EmvappsDetail>(entity =>
        {
            entity.HasKey(e => new { e.TemplateId, e.Aid, e.Tag }).HasName("emvapps_detail_pkey");

            entity.ToTable("emvapps_detail", "bank");

            entity.Property(e => e.TemplateId)
                .HasMaxLength(500)
                .HasColumnName("template_id");
            entity.Property(e => e.Aid)
                .HasMaxLength(100)
                .HasColumnName("aid");
            entity.Property(e => e.Tag)
                .HasMaxLength(100)
                .HasColumnName("tag");
            entity.Property(e => e.Value)
                .HasMaxLength(100)
                .HasColumnName("value");

            entity.HasOne(d => d.AidNavigation).WithMany(p => p.EmvappsDetails)
                .HasForeignKey(d => d.Aid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("emvapps_detail_aid_fkey");

            entity.HasOne(d => d.TagNavigation).WithMany(p => p.EmvappsDetails)
                .HasForeignKey(d => d.Tag)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("emvapps_detail_tag_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.EmvappsDetails)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("emvapps_detail_template_id_fkey");

            entity.HasOne(d => d.EmvappsMaster).WithMany(p => p.EmvappsDetails)
                .HasForeignKey(d => new { d.TemplateId, d.Aid })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("emvapps_detail_template_id_aid_fkey");
        });

        modelBuilder.Entity<EmvappsMaster>(entity =>
        {
            entity.HasKey(e => new { e.TemplateId, e.Aid }).HasName("emvapps_master_pkey");

            entity.ToTable("emvapps_master", "bank");

            entity.Property(e => e.TemplateId)
                .HasMaxLength(500)
                .HasColumnName("template_id");
            entity.Property(e => e.Aid)
                .HasMaxLength(100)
                .HasColumnName("aid");

            entity.HasOne(d => d.AidNavigation).WithMany(p => p.EmvappsMasters)
                .HasForeignKey(d => d.Aid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("emvapps_master_aid_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.EmvappsMasters)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("emvapps_master_template_id_fkey");
        });

        modelBuilder.Entity<EmvappsTag>(entity =>
        {
            entity.HasKey(e => e.Tag).HasName("emvapps_tags_pkey");

            entity.ToTable("emvapps_tags", "bank");

            entity.HasIndex(e => e.Name, "unique_name_tags").IsUnique();

            entity.Property(e => e.Tag)
                .HasMaxLength(500)
                .HasColumnName("tag");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Encryptor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("encryptors", "bank");

            entity.Property(e => e.EncryptorDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("encryptor_date");
            entity.Property(e => e.EncryptorId)
                .HasDefaultValueSql("nextval('encryptors_encryptor_id_seq'::regclass)")
                .HasColumnName("encryptor_id");
            entity.Property(e => e.EncryptorPrivate).HasColumnName("encryptor_private");
            entity.Property(e => e.EncryptorPublic).HasColumnName("encryptor_public");
        });

        modelBuilder.Entity<HistoricalCreditPayment>(entity =>
        {
            entity.HasKey(e => e.CreditPaymentId).HasName("historical_credit_payment_pkey");

            entity.ToTable("historical_credit_payment", "bank");

            entity.Property(e => e.CreditPaymentId)
                .HasDefaultValueSql("nextval('historical_credit_payment_credit_payment_id_seq'::regclass)")
                .HasColumnName("credit_payment_id");
            entity.Property(e => e.Amount)
                .HasMaxLength(200)
                .HasColumnName("amount");
            entity.Property(e => e.AmountCurrency)
                .HasMaxLength(200)
                .HasColumnName("amount_currency");
            entity.Property(e => e.AnnualPercentageRateCost)
                .HasMaxLength(200)
                .HasColumnName("annual_percentage_rate_cost");
            entity.Property(e => e.AsfiCommerce)
                .HasMaxLength(300)
                .HasColumnName("asfi_commerce");
            entity.Property(e => e.AuthorizationCode)
                .HasMaxLength(200)
                .HasColumnName("authorization_code");
            entity.Property(e => e.BranchAddress)
                .HasMaxLength(200)
                .HasColumnName("branch_address");
            entity.Property(e => e.BranchId)
                .HasMaxLength(200)
                .HasColumnName("branch_id");
            entity.Property(e => e.Capital)
                .HasMaxLength(200)
                .HasColumnName("capital");
            entity.Property(e => e.Channel)
                .HasMaxLength(200)
                .HasColumnName("channel");
            entity.Property(e => e.CommerceId)
                .HasMaxLength(200)
                .HasColumnName("commerce_id");
            entity.Property(e => e.CommerceName)
                .HasMaxLength(200)
                .HasColumnName("commerce_name");
            entity.Property(e => e.CorrespondentId)
                .HasMaxLength(200)
                .HasColumnName("correspondent_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(200)
                .HasColumnName("created_date");
            entity.Property(e => e.CreditOperationIdentifier)
                .HasMaxLength(200)
                .HasColumnName("credit_operation_identifier");
            entity.Property(e => e.DateTransaction)
                .HasMaxLength(200)
                .HasColumnName("date_transaction");
            entity.Property(e => e.DebitAccountIdentifier)
                .HasMaxLength(200)
                .HasColumnName("debit_account_identifier");
            entity.Property(e => e.DeferredAmount)
                .HasMaxLength(200)
                .HasColumnName("deferred_amount");
            entity.Property(e => e.DeferredInterest)
                .HasMaxLength(200)
                .HasColumnName("deferred_interest");
            entity.Property(e => e.Device)
                .HasMaxLength(200)
                .HasColumnName("device");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(200)
                .HasColumnName("device_id");
            entity.Property(e => e.DeviceIp)
                .HasMaxLength(200)
                .HasColumnName("device_ip");
            entity.Property(e => e.ExchangeRate)
                .HasMaxLength(200)
                .HasColumnName("exchange_rate");
            entity.Property(e => e.FinancialTransactionTax)
                .HasMaxLength(200)
                .HasColumnName("financial_transaction_tax");
            entity.Property(e => e.InsuranceDes)
                .HasMaxLength(200)
                .HasColumnName("insurance_des");
            entity.Property(e => e.Interest)
                .HasMaxLength(200)
                .HasColumnName("interest");
            entity.Property(e => e.JudicialExpenses)
                .HasMaxLength(200)
                .HasColumnName("judicial_expenses");
            entity.Property(e => e.Nit)
                .HasMaxLength(200)
                .HasColumnName("nit");
            entity.Property(e => e.OperationCurrency)
                .HasMaxLength(200)
                .HasColumnName("operation_currency");
            entity.Property(e => e.PaymentIdentifier)
                .HasMaxLength(200)
                .HasColumnName("payment_identifier");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(200)
                .HasColumnName("payment_method");
            entity.Property(e => e.PenaltyInterest)
                .HasMaxLength(200)
                .HasColumnName("penalty_interest");
            entity.Property(e => e.Phone)
                .HasMaxLength(200)
                .HasColumnName("phone");
            entity.Property(e => e.Regional)
                .HasMaxLength(300)
                .HasColumnName("regional");
            entity.Property(e => e.RepresentativeDocument)
                .HasMaxLength(200)
                .HasColumnName("representative_document");
            entity.Property(e => e.RepresentativeName)
                .HasMaxLength(200)
                .HasColumnName("representative_name");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.TimeTransaction)
                .HasMaxLength(200)
                .HasColumnName("time_transaction");
            entity.Property(e => e.TraceNumber)
                .HasMaxLength(200)
                .HasColumnName("trace_number");
            entity.Property(e => e.TransactionCardNumber)
                .HasMaxLength(300)
                .HasColumnName("transaction_card_number");
            entity.Property(e => e.TransactionName)
                .HasMaxLength(200)
                .HasColumnName("transaction_name");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(200)
                .HasColumnName("transaction_type");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(200)
                .HasColumnName("updated_date");
            entity.Property(e => e.VoucherId)
                .HasMaxLength(200)
                .HasColumnName("voucher_id");
        });

        modelBuilder.Entity<HistoricalDeposit>(entity =>
        {
            entity.HasKey(e => e.DepositId).HasName("historical_deposit_pkey");

            entity.ToTable("historical_deposit", "bank");

            entity.Property(e => e.DepositId)
                .HasDefaultValueSql("nextval('historical_deposit_deposit_id_seq'::regclass)")
                .HasColumnName("deposit_id");
            entity.Property(e => e.AccountId)
                .HasMaxLength(200)
                .HasColumnName("account_id");
            entity.Property(e => e.Amount)
                .HasMaxLength(200)
                .HasColumnName("amount");
            entity.Property(e => e.AsfiCommerce)
                .HasMaxLength(300)
                .HasColumnName("asfi_commerce");
            entity.Property(e => e.AuthorizationCode)
                .HasMaxLength(200)
                .HasColumnName("authorization_code");
            entity.Property(e => e.BranchAddress)
                .HasMaxLength(200)
                .HasColumnName("branch_address");
            entity.Property(e => e.BranchId)
                .HasMaxLength(200)
                .HasColumnName("branch_id");
            entity.Property(e => e.Channel)
                .HasMaxLength(200)
                .HasColumnName("channel");
            entity.Property(e => e.CommerceId)
                .HasMaxLength(200)
                .HasColumnName("commerce_id");
            entity.Property(e => e.CommerceName)
                .HasMaxLength(200)
                .HasColumnName("commerce_name");
            entity.Property(e => e.CorrespondentId)
                .HasMaxLength(200)
                .HasColumnName("correspondent_id");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(200)
                .HasColumnName("create_by");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(200)
                .HasColumnName("created_date");
            entity.Property(e => e.CreditedAccount)
                .HasMaxLength(200)
                .HasColumnName("credited_account");
            entity.Property(e => e.CreditedCurrency)
                .HasMaxLength(200)
                .HasColumnName("credited_currency");
            entity.Property(e => e.Currency)
                .HasMaxLength(200)
                .HasColumnName("currency");
            entity.Property(e => e.CurrentAccount)
                .HasMaxLength(200)
                .HasColumnName("current_account");
            entity.Property(e => e.DateTransaction)
                .HasMaxLength(200)
                .HasColumnName("date_transaction");
            entity.Property(e => e.Details)
                .HasMaxLength(1000)
                .HasColumnName("details");
            entity.Property(e => e.Device)
                .HasMaxLength(200)
                .HasColumnName("device");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(200)
                .HasColumnName("device_id");
            entity.Property(e => e.DeviceIp)
                .HasMaxLength(200)
                .HasColumnName("device_ip");
            entity.Property(e => e.ExchangeRate)
                .HasMaxLength(200)
                .HasColumnName("exchange_rate");
            entity.Property(e => e.ImportAccredited)
                .HasMaxLength(200)
                .HasColumnName("import_accredited");
            entity.Property(e => e.NameAccount)
                .HasMaxLength(200)
                .HasColumnName("name_account");
            entity.Property(e => e.Nit)
                .HasMaxLength(200)
                .HasColumnName("nit");
            entity.Property(e => e.PaymentIdentifier)
                .HasMaxLength(200)
                .HasColumnName("payment_identifier");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(200)
                .HasColumnName("payment_method");
            entity.Property(e => e.Phone)
                .HasMaxLength(200)
                .HasColumnName("phone");
            entity.Property(e => e.Regional)
                .HasMaxLength(300)
                .HasColumnName("regional");
            entity.Property(e => e.RepresentativeDocument)
                .HasMaxLength(200)
                .HasColumnName("representative_document");
            entity.Property(e => e.RepresentativeName)
                .HasMaxLength(200)
                .HasColumnName("representative_name");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.TimeTransaction)
                .HasMaxLength(200)
                .HasColumnName("time_transaction");
            entity.Property(e => e.TraceNumber)
                .HasMaxLength(200)
                .HasColumnName("trace_number");
            entity.Property(e => e.TransactionCardNumber)
                .HasMaxLength(300)
                .HasColumnName("transaction_card_number");
            entity.Property(e => e.TransactionName)
                .HasMaxLength(200)
                .HasColumnName("transaction_name");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(200)
                .HasColumnName("transaction_type");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(200)
                .HasColumnName("updated_date");
            entity.Property(e => e.VoucherId)
                .HasMaxLength(200)
                .HasColumnName("voucher_id");
        });

        modelBuilder.Entity<HistoricalPaymentService>(entity =>
        {
            entity.HasKey(e => e.PaymentServicesId).HasName("historical_payment_services_pkey");

            entity.ToTable("historical_payment_services", "bank");

            entity.Property(e => e.PaymentServicesId)
                .HasDefaultValueSql("nextval('historical_payment_services_payment_services_id_seq'::regclass)")
                .HasColumnName("payment_services_id");
            entity.Property(e => e.AsfiCommerce)
                .HasMaxLength(300)
                .HasColumnName("asfi_commerce");
            entity.Property(e => e.AuthorizationCode)
                .HasMaxLength(200)
                .HasColumnName("authorization_code");
            entity.Property(e => e.BranchAddress)
                .HasMaxLength(200)
                .HasColumnName("branch_address");
            entity.Property(e => e.BranchId)
                .HasMaxLength(200)
                .HasColumnName("branch_id");
            entity.Property(e => e.Channel)
                .HasMaxLength(200)
                .HasColumnName("channel");
            entity.Property(e => e.CommerceId)
                .HasMaxLength(200)
                .HasColumnName("commerce_id");
            entity.Property(e => e.CommerceName)
                .HasMaxLength(200)
                .HasColumnName("commerce_name");
            entity.Property(e => e.CorrespondentId)
                .HasMaxLength(200)
                .HasColumnName("correspondent_id");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(200)
                .HasColumnName("create_by");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(200)
                .HasColumnName("created_date");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .HasColumnName("customer_id");
            entity.Property(e => e.DateTransaction)
                .HasMaxLength(200)
                .HasColumnName("date_transaction");
            entity.Property(e => e.DebitAmount)
                .HasMaxLength(200)
                .HasColumnName("debit_amount");
            entity.Property(e => e.DebitCoin)
                .HasMaxLength(200)
                .HasColumnName("debit_coin");
            entity.Property(e => e.DebitCurrency)
                .HasMaxLength(200)
                .HasColumnName("debit_currency");
            entity.Property(e => e.Device)
                .HasMaxLength(200)
                .HasColumnName("device");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(200)
                .HasColumnName("device_id");
            entity.Property(e => e.ExchangeRate)
                .HasMaxLength(200)
                .HasColumnName("exchange_rate");
            entity.Property(e => e.ExchangeRateCurrency)
                .HasMaxLength(200)
                .HasColumnName("exchange_rate_currency");
            entity.Property(e => e.NameAccount)
                .HasMaxLength(200)
                .HasColumnName("name_account");
            entity.Property(e => e.Nit)
                .HasMaxLength(200)
                .HasColumnName("nit");
            entity.Property(e => e.PaymentIdentifier)
                .HasMaxLength(200)
                .HasColumnName("payment_identifier");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(200)
                .HasColumnName("payment_method");
            entity.Property(e => e.Period)
                .HasMaxLength(200)
                .HasColumnName("period");
            entity.Property(e => e.Phone)
                .HasMaxLength(200)
                .HasColumnName("phone");
            entity.Property(e => e.Regional)
                .HasMaxLength(300)
                .HasColumnName("regional");
            entity.Property(e => e.RepresentativeDocument)
                .HasMaxLength(200)
                .HasColumnName("representative_document");
            entity.Property(e => e.RepresentativeName)
                .HasMaxLength(200)
                .HasColumnName("representative_name");
            entity.Property(e => e.Sequential)
                .HasMaxLength(200)
                .HasColumnName("sequential");
            entity.Property(e => e.ServiceAccount)
                .HasMaxLength(200)
                .HasColumnName("service_account");
            entity.Property(e => e.ServiceDetail)
                .HasMaxLength(1000)
                .HasColumnName("service_detail");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(200)
                .HasColumnName("service_name");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.TimeTransaction)
                .HasMaxLength(200)
                .HasColumnName("time_transaction");
            entity.Property(e => e.TotalAmount)
                .HasMaxLength(200)
                .HasColumnName("total_amount");
            entity.Property(e => e.TotalAmountCurrency)
                .HasMaxLength(200)
                .HasColumnName("total_amount_currency");
            entity.Property(e => e.TraceNumber)
                .HasMaxLength(200)
                .HasColumnName("trace_number");
            entity.Property(e => e.TransactionCardNumber)
                .HasMaxLength(300)
                .HasColumnName("transaction_card_number");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(200)
                .HasColumnName("transaction_id");
            entity.Property(e => e.TransactionName)
                .HasMaxLength(200)
                .HasColumnName("transaction_name");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(200)
                .HasColumnName("updated_date");
        });

        modelBuilder.Entity<HistoricalWithdrawal>(entity =>
        {
            entity.HasKey(e => e.WithdrawalId).HasName("historical_withdrawal_pkey");

            entity.ToTable("historical_withdrawal", "bank");

            entity.Property(e => e.WithdrawalId)
                .HasDefaultValueSql("nextval('historical_withdrawal_withdrawal_id_seq'::regclass)")
                .HasColumnName("withdrawal_id");
            entity.Property(e => e.AccountId)
                .HasMaxLength(200)
                .HasColumnName("account_id");
            entity.Property(e => e.Amount)
                .HasMaxLength(200)
                .HasColumnName("amount");
            entity.Property(e => e.AsfiCommerce)
                .HasMaxLength(300)
                .HasColumnName("asfi_commerce");
            entity.Property(e => e.AuthorizationCode)
                .HasMaxLength(200)
                .HasColumnName("authorization_code");
            entity.Property(e => e.BranchAddress)
                .HasMaxLength(200)
                .HasColumnName("branch_address");
            entity.Property(e => e.BranchId)
                .HasMaxLength(200)
                .HasColumnName("branch_id");
            entity.Property(e => e.Channel)
                .HasMaxLength(200)
                .HasColumnName("channel");
            entity.Property(e => e.CommerceId)
                .HasMaxLength(200)
                .HasColumnName("commerce_id");
            entity.Property(e => e.CommerceName)
                .HasMaxLength(200)
                .HasColumnName("commerce_name");
            entity.Property(e => e.CorrespondentId)
                .HasMaxLength(200)
                .HasColumnName("correspondent_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(200)
                .HasColumnName("created_date");
            entity.Property(e => e.Currency)
                .HasMaxLength(200)
                .HasColumnName("currency");
            entity.Property(e => e.CurrentAccount)
                .HasMaxLength(200)
                .HasColumnName("current_account");
            entity.Property(e => e.DateTransaction)
                .HasMaxLength(200)
                .HasColumnName("date_transaction");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(200)
                .HasColumnName("debit_account");
            entity.Property(e => e.DebitAmount)
                .HasMaxLength(200)
                .HasColumnName("debit_amount");
            entity.Property(e => e.DebitCurrency)
                .HasMaxLength(200)
                .HasColumnName("debit_currency");
            entity.Property(e => e.Device)
                .HasMaxLength(200)
                .HasColumnName("device");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(200)
                .HasColumnName("device_id");
            entity.Property(e => e.ExchangeRate)
                .HasMaxLength(200)
                .HasColumnName("exchange_rate");
            entity.Property(e => e.IpDevice)
                .HasMaxLength(200)
                .HasColumnName("ip_device");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Nit)
                .HasMaxLength(200)
                .HasColumnName("nit");
            entity.Property(e => e.PaymentIdentifier)
                .HasMaxLength(200)
                .HasColumnName("payment_identifier");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(200)
                .HasColumnName("payment_method");
            entity.Property(e => e.Phone)
                .HasMaxLength(200)
                .HasColumnName("phone");
            entity.Property(e => e.Regional)
                .HasMaxLength(300)
                .HasColumnName("regional");
            entity.Property(e => e.RepresentativeDocument)
                .HasMaxLength(200)
                .HasColumnName("representative_document");
            entity.Property(e => e.RepresentativeName)
                .HasMaxLength(200)
                .HasColumnName("representative_name");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.TimeTransaction)
                .HasMaxLength(200)
                .HasColumnName("time_transaction");
            entity.Property(e => e.TraceNumber)
                .HasMaxLength(200)
                .HasColumnName("trace_number");
            entity.Property(e => e.TransactionCardNumber)
                .HasMaxLength(300)
                .HasColumnName("transaction_card_number");
            entity.Property(e => e.TransactionName)
                .HasMaxLength(200)
                .HasColumnName("transaction_name");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(200)
                .HasColumnName("transaction_type");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(200)
                .HasColumnName("updated_date");
            entity.Property(e => e.VoucherId)
                .HasMaxLength(200)
                .HasColumnName("voucher_id");
        });

        modelBuilder.Entity<LicenseForCustomer>(entity =>
        {
            entity.HasKey(e => e.LicenseForCustomerId).HasName("license_for_customer_pkey");

            entity.ToTable("license_for_customer", "bank");

            entity.Property(e => e.LicenseForCustomerId)
                .HasDefaultValueSql("nextval('license_for_customer_license_for_customer_id_seq'::regclass)")
                .HasColumnName("license_for_customer_id");
            entity.Property(e => e.CreationDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_date");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Key)
                .HasMaxLength(250)
                .HasColumnName("key");
            entity.Property(e => e.LicenseTypeId).HasColumnName("license_type_id");
            entity.Property(e => e.StatusTypeId).HasColumnName("status_type_id");

            entity.HasOne(d => d.LicenseType).WithMany(p => p.LicenseForCustomers)
                .HasForeignKey(d => d.LicenseTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_license_for_customer");

            entity.HasOne(d => d.StatusType).WithMany(p => p.LicenseForCustomers)
                .HasForeignKey(d => d.StatusTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_status_type");
        });

        modelBuilder.Entity<LicenseType>(entity =>
        {
            entity.HasKey(e => e.LicenseTypeId).HasName("license_type_pkey");

            entity.ToTable("license_type", "bank");

            entity.Property(e => e.LicenseTypeId)
                .HasDefaultValueSql("nextval('license_type_license_type_id_seq'::regclass)")
                .HasColumnName("license_type_id");
            entity.Property(e => e.DaysNumbers).HasColumnName("days_numbers");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
        });

        modelBuilder.Entity<LogTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("log_transactions", "bank");

            entity.Property(e => e.Application)
                .HasMaxLength(128)
                .HasColumnName("application");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(128)
                .HasColumnName("column_name");
            entity.Property(e => e.NewValue)
                .HasMaxLength(1000)
                .HasColumnName("new_value");
            entity.Property(e => e.OriginalValue)
                .HasMaxLength(1000)
                .HasColumnName("original_value");
            entity.Property(e => e.Pk)
                .HasMaxLength(1000)
                .HasColumnName("pk");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("transaction_date");
            entity.Property(e => e.Usr)
                .HasMaxLength(128)
                .HasColumnName("usr");
        });

        modelBuilder.Entity<LogsFunction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("logs_functions", "bank");

            entity.Property(e => e.LogCodeErrorChecked)
                .HasMaxLength(250)
                .HasColumnName("log_code_error_checked");
            entity.Property(e => e.LogCodeErrorDatabase)
                .HasMaxLength(500)
                .HasColumnName("log_code_error_database");
            entity.Property(e => e.LogDateInput)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("log_date_input");
            entity.Property(e => e.LogDateOutput)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("log_date_output");
            entity.Property(e => e.LogId)
                .HasDefaultValueSql("nextval('logs_functions_log_id_seq'::regclass)")
                .HasColumnName("log_id");
            entity.Property(e => e.LogMessageErrorChecked)
                .HasMaxLength(250)
                .HasColumnName("log_message_error_checked");
            entity.Property(e => e.LogMessageErrorDatabase)
                .HasMaxLength(500)
                .HasColumnName("log_message_error_database");
            entity.Property(e => e.LogNameObject)
                .HasMaxLength(250)
                .HasColumnName("log_name_object");
            entity.Property(e => e.LogParametersInput).HasColumnName("log_parameters_input");
            entity.Property(e => e.LogParametersOutput).HasColumnName("log_parameters_output");
            entity.Property(e => e.LogResponseTimeMilliseconds).HasColumnName("log_response_time_milliseconds");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .HasColumnName("login");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("pk_module_id");

            entity.ToTable("modules", "bank");

            entity.Property(e => e.ModuleId)
                .HasDefaultValueSql("nextval('modules_module_id_seq'::regclass)")
                .HasColumnName("module_id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ModulesSubmodulesApp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("modules_submodules_apps", "bank");

            entity.Property(e => e.AppName)
                .HasMaxLength(150)
                .HasColumnName("app_name");
            entity.Property(e => e.Module)
                .HasMaxLength(150)
                .HasColumnName("module");
            entity.Property(e => e.Submodule)
                .HasMaxLength(150)
                .HasColumnName("submodule");
        });

        modelBuilder.Entity<ObfuscationField>(entity =>
        {
            entity.HasKey(e => e.ObfuscationFieldId).HasName("obfuscation_fields_pkey");

            entity.ToTable("obfuscation_fields", "bank");

            entity.Property(e => e.ObfuscationFieldId)
                .HasDefaultValueSql("nextval('obfuscation_fields_obfuscation_field_id_seq'::regclass)")
                .HasColumnName("obfuscation_field_id");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(200)
                .HasColumnName("column_name");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.ObfuscationFieldName)
                .HasMaxLength(200)
                .HasColumnName("obfuscation_field_name");
            entity.Property(e => e.RoleGroupId).HasColumnName("role_group_id");
            entity.Property(e => e.RuleId).HasColumnName("rule_id");
            entity.Property(e => e.RuleTypeId).HasColumnName("rule_type_id");
            entity.Property(e => e.SubmoduleId).HasColumnName("submodule_id");
            entity.Property(e => e.TableId).HasColumnName("table_id");

            entity.HasOne(d => d.Module).WithMany(p => p.ObfuscationFields)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("fk_modules");

            entity.HasOne(d => d.RoleGroup).WithMany(p => p.ObfuscationFields)
                .HasForeignKey(d => d.RoleGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sec_groups");

            entity.HasOne(d => d.RuleType).WithMany(p => p.ObfuscationFields)
                .HasForeignKey(d => d.RuleTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_obfuscation_rule_type");

            entity.HasOne(d => d.Submodule).WithMany(p => p.ObfuscationFields)
                .HasForeignKey(d => d.SubmoduleId)
                .HasConstraintName("fk_submodules");

            entity.HasOne(d => d.Table).WithMany(p => p.ObfuscationFields)
                .HasForeignKey(d => d.TableId)
                .HasConstraintName("fk_tables");
        });

        modelBuilder.Entity<ObfuscationRule>(entity =>
        {
            entity.HasKey(e => e.ObfuscationRuleId).HasName("obfuscation_rule_pkey");

            entity.ToTable("obfuscation_rule", "bank");

            entity.Property(e => e.ObfuscationRuleId)
                .HasDefaultValueSql("nextval('obfuscation_rule_obfuscation_rule_id_seq'::regclass)")
                .HasColumnName("obfuscation_rule_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.ObfuscateAll).HasColumnName("obfuscate_all");
            entity.Property(e => e.ObfuscatedCharactersEnd).HasColumnName("obfuscated_characters_end");
            entity.Property(e => e.ObfuscatedCharactersStart).HasColumnName("obfuscated_characters_start");
            entity.Property(e => e.ObfuscationPerWord).HasColumnName("obfuscation_per_word");
            entity.Property(e => e.ObfuscationRuleTypeId).HasColumnName("obfuscation_rule_type_id");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.VisibleCharactersEnd).HasColumnName("visible_characters_end");
            entity.Property(e => e.VisibleCharactersStart).HasColumnName("visible_characters_start");
            entity.Property(e => e.VisibleWordsEnd).HasColumnName("visible_words_end");
            entity.Property(e => e.VisibleWordsStart).HasColumnName("visible_words_start");

            entity.HasOne(d => d.ObfuscationRuleType).WithMany(p => p.ObfuscationRules)
                .HasForeignKey(d => d.ObfuscationRuleTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("obfuscation_rule_obfuscation_rule_type_id_fkey");
        });

        modelBuilder.Entity<ObfuscationRuleType>(entity =>
        {
            entity.HasKey(e => e.ObfuscationRuleTypeId).HasName("obfuscation_rule_type_pkey");

            entity.ToTable("obfuscation_rule_type", "bank");

            entity.Property(e => e.ObfuscationRuleTypeId)
                .HasDefaultValueSql("nextval('obfuscation_rule_type_obfuscation_rule_type_id_seq'::regclass)")
                .HasColumnName("obfuscation_rule_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
        });

        modelBuilder.Entity<PaymentService>(entity =>
        {
            entity.HasKey(e => e.PaymentServicesId).HasName("payment_services_pkey");

            entity.ToTable("payment_services", "bank");

            entity.Property(e => e.PaymentServicesId)
                .HasDefaultValueSql("nextval('payment_services_payment_services_id_seq'::regclass)")
                .HasColumnName("payment_services_id");
            entity.Property(e => e.AsfiCommerce)
                .HasMaxLength(300)
                .HasColumnName("asfi_commerce");
            entity.Property(e => e.AuthorizationCode)
                .HasMaxLength(200)
                .HasColumnName("authorization_code");
            entity.Property(e => e.BranchAddress)
                .HasMaxLength(200)
                .HasColumnName("branch_address");
            entity.Property(e => e.BranchId)
                .HasMaxLength(200)
                .HasColumnName("branch_id");
            entity.Property(e => e.Channel)
                .HasMaxLength(200)
                .HasColumnName("channel");
            entity.Property(e => e.CommerceId)
                .HasMaxLength(200)
                .HasColumnName("commerce_id");
            entity.Property(e => e.CommerceName)
                .HasMaxLength(200)
                .HasColumnName("commerce_name");
            entity.Property(e => e.CorrespondentId)
                .HasMaxLength(200)
                .HasColumnName("correspondent_id");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(200)
                .HasColumnName("create_by");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(200)
                .HasColumnName("created_date");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(200)
                .HasColumnName("customer_id");
            entity.Property(e => e.DateTransaction)
                .HasMaxLength(200)
                .HasColumnName("date_transaction");
            entity.Property(e => e.DebitAmount)
                .HasMaxLength(200)
                .HasColumnName("debit_amount");
            entity.Property(e => e.DebitCoin)
                .HasMaxLength(200)
                .HasColumnName("debit_coin");
            entity.Property(e => e.DebitCurrency)
                .HasMaxLength(200)
                .HasColumnName("debit_currency");
            entity.Property(e => e.Device)
                .HasMaxLength(200)
                .HasColumnName("device");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(200)
                .HasColumnName("device_id");
            entity.Property(e => e.ExchangeRate)
                .HasMaxLength(200)
                .HasColumnName("exchange_rate");
            entity.Property(e => e.ExchangeRateCurrency)
                .HasMaxLength(200)
                .HasColumnName("exchange_rate_currency");
            entity.Property(e => e.NameAccount)
                .HasMaxLength(200)
                .HasColumnName("name_account");
            entity.Property(e => e.Nit)
                .HasMaxLength(200)
                .HasColumnName("nit");
            entity.Property(e => e.PaymentIdentifier)
                .HasMaxLength(200)
                .HasColumnName("payment_identifier");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(200)
                .HasColumnName("payment_method");
            entity.Property(e => e.Period)
                .HasMaxLength(200)
                .HasColumnName("period");
            entity.Property(e => e.Phone)
                .HasMaxLength(200)
                .HasColumnName("phone");
            entity.Property(e => e.Regional)
                .HasMaxLength(300)
                .HasColumnName("regional");
            entity.Property(e => e.RepresentativeDocument)
                .HasMaxLength(200)
                .HasColumnName("representative_document");
            entity.Property(e => e.RepresentativeName)
                .HasMaxLength(200)
                .HasColumnName("representative_name");
            entity.Property(e => e.Sequential)
                .HasMaxLength(200)
                .HasColumnName("sequential");
            entity.Property(e => e.ServiceAccount)
                .HasMaxLength(200)
                .HasColumnName("service_account");
            entity.Property(e => e.ServiceDetail)
                .HasMaxLength(1000)
                .HasColumnName("service_detail");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(200)
                .HasColumnName("service_name");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.TimeTransaction)
                .HasMaxLength(200)
                .HasColumnName("time_transaction");
            entity.Property(e => e.TotalAmount)
                .HasMaxLength(200)
                .HasColumnName("total_amount");
            entity.Property(e => e.TotalAmountCurrency)
                .HasMaxLength(200)
                .HasColumnName("total_amount_currency");
            entity.Property(e => e.TraceNumber)
                .HasMaxLength(200)
                .HasColumnName("trace_number");
            entity.Property(e => e.TransactionCardNumber)
                .HasMaxLength(300)
                .HasColumnName("transaction_card_number");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(200)
                .HasColumnName("transaction_id");
            entity.Property(e => e.TransactionName)
                .HasMaxLength(200)
                .HasColumnName("transaction_name");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(200)
                .HasColumnName("updated_date");
        });

        modelBuilder.Entity<PaymentStatus>(entity =>
        {
            entity.HasKey(e => e.PaymentStatusId).HasName("payment_status_pkey");

            entity.ToTable("payment_status", "bank");

            entity.Property(e => e.PaymentStatusId)
                .HasDefaultValueSql("nextval('payment_status_payment_status_id_seq'::regclass)")
                .HasColumnName("payment_status_id");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.ProfileId).HasName("profiles_pkey");

            entity.ToTable("profiles", "bank");

            entity.Property(e => e.ProfileId)
                .HasDefaultValueSql("nextval('profiles_profile_id_seq'::regclass)")
                .HasColumnName("profile_id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.TemplateCapks)
                .HasMaxLength(500)
                .HasColumnName("template_capks");
            entity.Property(e => e.TemplateEmvapps)
                .HasMaxLength(500)
                .HasColumnName("template_emvapps");
            entity.Property(e => e.TemplateRanges)
                .HasMaxLength(500)
                .HasColumnName("template_ranges");
            entity.Property(e => e.TemplateTransactions)
                .HasMaxLength(500)
                .HasColumnName("template_transactions");

            entity.HasOne(d => d.TemplateCapksNavigation).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.TemplateCapks)
                .HasConstraintName("fk_capks_profiles");

            entity.HasOne(d => d.TemplateEmvappsNavigation).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.TemplateEmvapps)
                .HasConstraintName("fk_emvapps_profiles");

            entity.HasOne(d => d.TemplateRangesNavigation).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.TemplateRanges)
                .HasConstraintName("fk_ranges_profiles");

            entity.HasOne(d => d.TemplateTransactionsNavigation).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.TemplateTransactions)
                .HasConstraintName("fk_template_trx_profiles");
        });

        modelBuilder.Entity<Range>(entity =>
        {
            entity.HasKey(e => new { e.TemplateId, e.RangeId }).HasName("ranges_pkey");

            entity.ToTable("ranges", "bank");

            entity.Property(e => e.TemplateId)
                .HasMaxLength(500)
                .HasColumnName("template_id");
            entity.Property(e => e.RangeId).HasColumnName("range_id");
            entity.Property(e => e.CardType)
                .HasMaxLength(50)
                .HasColumnName("card_type");
            entity.Property(e => e.CntDigitsLowerLimit)
                .HasMaxLength(50)
                .HasColumnName("cnt_digits_lower_limit");
            entity.Property(e => e.CntDigitsUpperLimit)
                .HasMaxLength(50)
                .HasColumnName("cnt_digits_upper_limit");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.LowerLimit)
                .HasMaxLength(50)
                .HasColumnName("lower_limit");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_date");
            entity.Property(e => e.UpperLimit)
                .HasMaxLength(50)
                .HasColumnName("upper_limit");

            entity.HasOne(d => d.Template).WithMany(p => p.Ranges)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ranges_template_id_fkey");
        });

        modelBuilder.Entity<Representative>(entity =>
        {
            entity.HasKey(e => e.RepresentativeId).HasName("representatives_pkey");

            entity.ToTable("representatives", "bank");

            entity.Property(e => e.RepresentativeId)
                .HasDefaultValueSql("nextval('representatives_representative_id_seq'::regclass)")
                .HasColumnName("representative_id");
            entity.Property(e => e.Address)
                .HasMaxLength(600)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(600)
                .HasColumnName("email");
            entity.Property(e => e.IdentificationNumber)
                .HasMaxLength(600)
                .HasColumnName("identification_number");
            entity.Property(e => e.IdentificationType).HasColumnName("identification_type");
            entity.Property(e => e.Name)
                .HasMaxLength(600)
                .HasColumnName("name");
            entity.Property(e => e.Nit)
                .HasMaxLength(600)
                .HasColumnName("nit");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(600)
                .HasColumnName("phone_number");
            entity.Property(e => e.VirtualCardNumber)
                .HasMaxLength(600)
                .HasColumnName("virtual_card_number");

            entity.HasOne(d => d.IdentificationTypeNavigation).WithMany(p => p.Representatives)
                .HasForeignKey(d => d.IdentificationType)
                .HasConstraintName("fk_representative_identification_type");
        });

        modelBuilder.Entity<RepresentativeIdentificationType>(entity =>
        {
            entity.HasKey(e => e.RepresentativeIdentificationTypeId).HasName("representative_identification_types_pkey");

            entity.ToTable("representative_identification_types", "bank");

            entity.Property(e => e.RepresentativeIdentificationTypeId)
                .HasDefaultValueSql("nextval('representative_identification_representative_identification_seq'::regclass)")
                .HasColumnName("representative_identification_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
        });

        modelBuilder.Entity<ScLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sc_log_pkey");

            entity.ToTable("sc_log", "bank");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('sc_log_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(30)
                .HasColumnName("action");
            entity.Property(e => e.Application)
                .HasMaxLength(255)
                .HasColumnName("application");
            entity.Property(e => e.Creator)
                .HasMaxLength(30)
                .HasColumnName("creator");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.InsertedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("inserted_date");
            entity.Property(e => e.IpUser)
                .HasMaxLength(255)
                .HasColumnName("ip_user");
            entity.Property(e => e.Username)
                .HasMaxLength(90)
                .HasColumnName("username");
        });

        modelBuilder.Entity<SecApp>(entity =>
        {
            entity.HasKey(e => e.AppName).HasName("pk_sec_apps");

            entity.ToTable("sec_apps", "bank");

            entity.Property(e => e.AppName)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("app_name");
            entity.Property(e => e.AppType).HasColumnName("app_type");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<SecEmail>(entity =>
        {
            entity.HasKey(e => e.SecEmailId).HasName("sec_email_pkey");

            entity.ToTable("sec_email", "bank");

            entity.Property(e => e.SecEmailId)
                .HasDefaultValueSql("nextval('sec_email_sec_email_id_seq'::regclass)")
                .HasColumnName("sec_email_id");
            entity.Property(e => e.AuthenticationFlag).HasColumnName("authentication_flag");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.PlainValue)
                .HasMaxLength(200)
                .HasColumnName("plain_value");
            entity.Property(e => e.Port)
                .HasMaxLength(10)
                .HasColumnName("port");
            entity.Property(e => e.Smtp)
                .HasMaxLength(50)
                .HasColumnName("smtp");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<SecGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("sec_groups_pkey");

            entity.ToTable("sec_groups", "bank");

            entity.Property(e => e.GroupId)
                .HasDefaultValueSql("nextval('sec_groups_group_id_seq'::regclass)")
                .HasColumnName("group_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
        });

        modelBuilder.Entity<SecGroupsApp>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.AppName }).HasName("sec_groups_apps_pkey");

            entity.ToTable("sec_groups_apps", "bank");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.AppName)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("app_name");
            entity.Property(e => e.Module)
                .HasMaxLength(150)
                .HasColumnName("module");
            entity.Property(e => e.PrivAccess)
                .HasMaxLength(100)
                .HasColumnName("priv_access");
            entity.Property(e => e.PrivDelete)
                .HasMaxLength(100)
                .HasColumnName("priv_delete");
            entity.Property(e => e.PrivExport)
                .HasMaxLength(100)
                .HasColumnName("priv_export");
            entity.Property(e => e.PrivInsert)
                .HasMaxLength(100)
                .HasColumnName("priv_insert");
            entity.Property(e => e.PrivPrint)
                .HasMaxLength(100)
                .HasColumnName("priv_print");
            entity.Property(e => e.PrivUpdate)
                .HasMaxLength(100)
                .HasColumnName("priv_update");
            entity.Property(e => e.Submodule)
                .HasMaxLength(150)
                .HasColumnName("submodule");

            entity.HasOne(d => d.Group).WithMany(p => p.SecGroupsApps)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sec_groups_apps_group_id_fkey");
        });

        modelBuilder.Entity<SecUser>(entity =>
        {
            entity.HasKey(e => e.Login).HasName("pk_sec_users");

            entity.ToTable("sec_users", "bank");

            entity.Property(e => e.Login)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("login");
            entity.Property(e => e.ActivationCode).HasColumnName("activation_code");
            entity.Property(e => e.AuthAttempts).HasColumnName("auth_attempts");
            entity.Property(e => e.AuthenticationCode).HasColumnName("authentication_code");
            entity.Property(e => e.DateTimeUltActive)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_time_ult_active");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .HasColumnName("email");
            entity.Property(e => e.EntryDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("entry_date");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.PrivAdmin)
                .HasMaxLength(500)
                .HasColumnName("priv_admin");
            entity.Property(e => e.Pswd)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("pswd");
            entity.Property(e => e.RegisteredUser)
                .HasMaxLength(100)
                .HasColumnName("registered_user");
            entity.Property(e => e.TagUser).HasColumnName("tag_user");
            entity.Property(e => e.UserUltHigh)
                .HasMaxLength(100)
                .HasColumnName("user_ult_high");
            entity.Property(e => e.UsrActive)
                .HasMaxLength(500)
                .HasColumnName("usr_active");
            entity.Property(e => e.UsrAttempts).HasColumnName("usr_attempts");
            entity.Property(e => e.UsrDateCreationKey)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("usr_date_creation_key");
            entity.Property(e => e.UsrDateExpKey)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("usr_date_exp_key");
            entity.Property(e => e.ValidityCode)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("validity_code");

            entity.HasOne(d => d.TagUserNavigation).WithMany(p => p.SecUsers)
                .HasForeignKey(d => d.TagUser)
                .HasConstraintName("sec_users_tag_user_fkey");

            entity.HasMany(d => d.Groups).WithMany(p => p.Logins)
                .UsingEntity<Dictionary<string, object>>(
                    "SecUsersGroup",
                    r => r.HasOne<SecGroup>().WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("sec_users_groups_group_id_fkey"),
                    l => l.HasOne<SecUser>().WithMany()
                        .HasForeignKey("Login")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("sec_users_groups_login_fkey"),
                    j =>
                    {
                        j.HasKey("Login", "GroupId").HasName("sec_users_groups_pkey");
                        j.ToTable("sec_users_groups", "bank");
                        j.IndexerProperty<string>("Login")
                            .HasMaxLength(150)
                            .HasDefaultValueSql("''::character varying")
                            .HasColumnName("login");
                        j.IndexerProperty<int>("GroupId").HasColumnName("group_id");
                    });
        });

        modelBuilder.Entity<SecUsersKeyHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sec_users_key_history_pkey");

            entity.ToTable("sec_users_key_history", "bank");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('sec_users_key_history_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.UsuHashOld)
                .HasMaxLength(250)
                .HasColumnName("usu_hash_old");
            entity.Property(e => e.UsuLogin)
                .HasMaxLength(150)
                .HasColumnName("usu_login");

            entity.HasOne(d => d.UsuLoginNavigation).WithMany(p => p.SecUsersKeyHistories)
                .HasForeignKey(d => d.UsuLogin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sec_users_key_history_usu_login_fkey");
        });

        modelBuilder.Entity<StatusType>(entity =>
        {
            entity.HasKey(e => e.StatusTypeId).HasName("pk_status_type_id");

            entity.ToTable("status_type", "bank");

            entity.Property(e => e.StatusTypeId)
                .HasDefaultValueSql("nextval('status_type_status_type_id_seq'::regclass)")
                .HasColumnName("status_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Submodule>(entity =>
        {
            entity.HasKey(e => e.SubmoduleId).HasName("pk_submodule_id");

            entity.ToTable("submodules", "bank");

            entity.Property(e => e.SubmoduleId)
                .HasDefaultValueSql("nextval('submodules_submodule_id_seq'::regclass)")
                .HasColumnName("submodule_id");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");

            entity.HasOne(d => d.Module).WithMany(p => p.Submodules)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("fk_module_id");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.TableId).HasName("tables_pkey");

            entity.ToTable("tables", "bank");

            entity.Property(e => e.TableId)
                .HasDefaultValueSql("nextval('tables_table_id_seq'::regclass)")
                .HasColumnName("table_id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.SubmoduleId).HasColumnName("submodule_id");

            entity.HasOne(d => d.Module).WithMany(p => p.Tables)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("fk_tables_modules");

            entity.HasOne(d => d.Submodule).WithMany(p => p.Tables)
                .HasForeignKey(d => d.SubmoduleId)
                .HasConstraintName("fk_tables_submodules");
        });

        modelBuilder.Entity<TemplateBranchesHour>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("template_branches_hours_pkey");

            entity.ToTable("template_branches_hours", "bank");

            entity.Property(e => e.TemplateId)
                .HasMaxLength(200)
                .HasColumnName("template_id");
        });

        modelBuilder.Entity<TemplateCapk>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("template_capks_pkey");

            entity.ToTable("template_capks", "bank");

            entity.Property(e => e.TemplateId)
                .HasMaxLength(500)
                .HasColumnName("template_id");
        });

        modelBuilder.Entity<TemplateEmvapp>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("template_emvapps_pkey");

            entity.ToTable("template_emvapps", "bank");

            entity.Property(e => e.TemplateId)
                .HasMaxLength(500)
                .HasColumnName("template_id");
        });

        modelBuilder.Entity<TemplateRange>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("template_ranges_pkey");

            entity.ToTable("template_ranges", "bank");

            entity.Property(e => e.TemplateId)
                .HasMaxLength(500)
                .HasColumnName("template_id");
        });

        modelBuilder.Entity<TemplateTransaction>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("template_transactions_pkey");

            entity.ToTable("template_transactions", "bank");

            entity.Property(e => e.TemplateId)
                .HasMaxLength(500)
                .HasColumnName("template_id");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => new { e.TemplateId, e.TransactionId }).HasName("transactions_pkey");

            entity.ToTable("transactions", "bank");

            entity.Property(e => e.TemplateId)
                .HasMaxLength(500)
                .HasColumnName("template_id");
            entity.Property(e => e.TransactionId)
                .HasDefaultValueSql("nextval('transactions_transaction_id_seq'::regclass)")
                .HasColumnName("transaction_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.DailyTransactions).HasColumnName("daily_transactions");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.MaximumAmount)
                .HasMaxLength(100)
                .HasColumnName("maximum_amount");
            entity.Property(e => e.MaximumDollarAmount)
                .HasMaxLength(100)
                .HasColumnName("maximum_dollar_amount");
            entity.Property(e => e.MinimumAmount)
                .HasMaxLength(100)
                .HasColumnName("minimum_amount");
            entity.Property(e => e.MinimumAmountDollars)
                .HasMaxLength(100)
                .HasColumnName("minimum_amount_dollars");
            entity.Property(e => e.PrintVoucher).HasColumnName("print_voucher");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasColumnName("status");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(200)
                .HasColumnName("transaction_type");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_date");

            entity.HasOne(d => d.Template).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_template_transaction");
        });

        modelBuilder.Entity<TypesCommerce>(entity =>
        {
            entity.HasKey(e => e.TypeCommerceId).HasName("types_commerce_pkey");

            entity.ToTable("types_commerce", "bank");

            entity.Property(e => e.TypeCommerceId)
                .HasDefaultValueSql("nextval('types_commerce_type_commerce_id_seq'::regclass)")
                .HasColumnName("type_commerce_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_date");
        });

        modelBuilder.Entity<UpdateStatusDevice>(entity =>
        {
            entity.HasKey(e => e.UpdateStatusDeviceId).HasName("pk_update_status_device_id");

            entity.ToTable("update_status_device", "bank");

            entity.Property(e => e.UpdateStatusDeviceId)
                .HasDefaultValueSql("nextval('update_status_device_update_status_device_id_seq'::regclass)")
                .HasColumnName("update_status_device_id");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
        });

        modelBuilder.Entity<UserTag>(entity =>
        {
            entity.HasKey(e => e.UserTagId).HasName("user_tags_pkey");

            entity.ToTable("user_tags", "bank");

            entity.Property(e => e.UserTagId)
                .HasDefaultValueSql("nextval('user_tags_user_tag_id_seq'::regclass)")
                .HasColumnName("user_tag_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(200)
                .HasColumnName("update_by");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_date");
            entity.Property(e => e.UserTagsDescription)
                .HasMaxLength(100)
                .HasColumnName("user_tags_description");
            entity.Property(e => e.UserTagsName)
                .HasMaxLength(100)
                .HasColumnName("user_tags_name");
            entity.Property(e => e.UserTagsStatus).HasColumnName("user_tags_status");
        });

        modelBuilder.Entity<Withdrawal>(entity =>
        {
            entity.HasKey(e => e.WithdrawalId).HasName("withdrawal_pkey");

            entity.ToTable("withdrawal", "bank");

            entity.Property(e => e.WithdrawalId)
                .HasDefaultValueSql("nextval('withdrawal_withdrawal_id_seq'::regclass)")
                .HasColumnName("withdrawal_id");
            entity.Property(e => e.AccountId)
                .HasMaxLength(200)
                .HasColumnName("account_id");
            entity.Property(e => e.Amount)
                .HasMaxLength(200)
                .HasColumnName("amount");
            entity.Property(e => e.AsfiCommerce)
                .HasMaxLength(300)
                .HasColumnName("asfi_commerce");
            entity.Property(e => e.AuthorizationCode)
                .HasMaxLength(200)
                .HasColumnName("authorization_code");
            entity.Property(e => e.BranchAddress)
                .HasMaxLength(200)
                .HasColumnName("branch_address");
            entity.Property(e => e.BranchId)
                .HasMaxLength(200)
                .HasColumnName("branch_id");
            entity.Property(e => e.Channel)
                .HasMaxLength(200)
                .HasColumnName("channel");
            entity.Property(e => e.CommerceId)
                .HasMaxLength(200)
                .HasColumnName("commerce_id");
            entity.Property(e => e.CommerceName)
                .HasMaxLength(200)
                .HasColumnName("commerce_name");
            entity.Property(e => e.CorrespondentId)
                .HasMaxLength(200)
                .HasColumnName("correspondent_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(200)
                .HasColumnName("created_date");
            entity.Property(e => e.Currency)
                .HasMaxLength(200)
                .HasColumnName("currency");
            entity.Property(e => e.CurrentAccount)
                .HasMaxLength(200)
                .HasColumnName("current_account");
            entity.Property(e => e.DateTransaction)
                .HasMaxLength(200)
                .HasColumnName("date_transaction");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(200)
                .HasColumnName("debit_account");
            entity.Property(e => e.DebitAmount)
                .HasMaxLength(200)
                .HasColumnName("debit_amount");
            entity.Property(e => e.DebitCurrency)
                .HasMaxLength(200)
                .HasColumnName("debit_currency");
            entity.Property(e => e.Device)
                .HasMaxLength(200)
                .HasColumnName("device");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(200)
                .HasColumnName("device_id");
            entity.Property(e => e.ExchangeRate)
                .HasMaxLength(200)
                .HasColumnName("exchange_rate");
            entity.Property(e => e.IpDevice)
                .HasMaxLength(200)
                .HasColumnName("ip_device");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Nit)
                .HasMaxLength(200)
                .HasColumnName("nit");
            entity.Property(e => e.PaymentIdentifier)
                .HasMaxLength(200)
                .HasColumnName("payment_identifier");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(200)
                .HasColumnName("payment_method");
            entity.Property(e => e.Phone)
                .HasMaxLength(200)
                .HasColumnName("phone");
            entity.Property(e => e.Regional)
                .HasMaxLength(300)
                .HasColumnName("regional");
            entity.Property(e => e.RepresentativeDocument)
                .HasMaxLength(200)
                .HasColumnName("representative_document");
            entity.Property(e => e.RepresentativeName)
                .HasMaxLength(200)
                .HasColumnName("representative_name");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.TimeTransaction)
                .HasMaxLength(200)
                .HasColumnName("time_transaction");
            entity.Property(e => e.TraceNumber)
                .HasMaxLength(200)
                .HasColumnName("trace_number");
            entity.Property(e => e.TransactionCardNumber)
                .HasMaxLength(300)
                .HasColumnName("transaction_card_number");
            entity.Property(e => e.TransactionName)
                .HasMaxLength(200)
                .HasColumnName("transaction_name");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(200)
                .HasColumnName("transaction_type");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(200)
                .HasColumnName("updated_date");
            entity.Property(e => e.VoucherId)
                .HasMaxLength(200)
                .HasColumnName("voucher_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class RexRimsContext : DbContext
{
	IConfiguration appConfig;
	public RexRimsContext(IConfiguration config)
	{
		appConfig = config;
	}
	
    public RexRimsContext(DbContextOptions<RexRimsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessControl> AccessControls { get; set; }

    public virtual DbSet<ActionsLog> ActionsLogs { get; set; }

    public virtual DbSet<Agreement> Agreements { get; set; }

    public virtual DbSet<AmazonErrorOrder> AmazonErrorOrders { get; set; }

    public virtual DbSet<AmazonFbaFix> AmazonFbaFixes { get; set; }

    public virtual DbSet<AmazonFbaFixImportedOrder> AmazonFbaFixImportedOrders { get; set; }

    public virtual DbSet<AmazonFbaFixImportedOrderLine> AmazonFbaFixImportedOrderLines { get; set; }

    public virtual DbSet<AmazonStock> AmazonStocks { get; set; }

    public virtual DbSet<Attribute> Attributes { get; set; }

    public virtual DbSet<AttributeValue> AttributeValues { get; set; }

    public virtual DbSet<AttributeValueView> AttributeValueViews { get; set; }

    public virtual DbSet<AttributeView> AttributeViews { get; set; }

    public virtual DbSet<AutoReport> AutoReports { get; set; }

    public virtual DbSet<AutoReportLog> AutoReportLogs { get; set; }

    public virtual DbSet<AutoReportSchedule> AutoReportSchedules { get; set; }

    public virtual DbSet<BulkImportOperation> BulkImportOperations { get; set; }

    public virtual DbSet<BulletDescription> BulletDescriptions { get; set; }

    public virtual DbSet<CareSymbol> CareSymbols { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryByDesignView> CategoryByDesignViews { get; set; }

    public virtual DbSet<CategoryByProductView> CategoryByProductViews { get; set; }

    public virtual DbSet<CategoryWithFullNameView> CategoryWithFullNameViews { get; set; }

    public virtual DbSet<CcorderPayment> CcorderPayments { get; set; }

    public virtual DbSet<CheckResponse> CheckResponses { get; set; }

    public virtual DbSet<CommodityCode> CommodityCodes { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyMessage> CompanyMessages { get; set; }

    public virtual DbSet<ContactType> ContactTypes { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAccountActivation> CustomerAccountActivations { get; set; }

    public virtual DbSet<CustomerAgreement> CustomerAgreements { get; set; }

    public virtual DbSet<CustomerBranch> CustomerBranches { get; set; }

    public virtual DbSet<CustomerContact> CustomerContacts { get; set; }

    public virtual DbSet<CustomerMessage> CustomerMessages { get; set; }

    public virtual DbSet<CustomerOnWatch> CustomerOnWatches { get; set; }

    public virtual DbSet<CustomerOnWatchRetail> CustomerOnWatchRetails { get; set; }

    public virtual DbSet<CustomerOnWatchTrade> CustomerOnWatchTrades { get; set; }

    public virtual DbSet<CustomerOrigin> CustomerOrigins { get; set; }

    public virtual DbSet<CustomerRank> CustomerRanks { get; set; }

    public virtual DbSet<CustomerRlapi> CustomerRlapis { get; set; }

    public virtual DbSet<CustomerTerm> CustomerTerms { get; set; }

    public virtual DbSet<CustomerTransaction> CustomerTransactions { get; set; }

    public virtual DbSet<DotcomCategory> DotcomCategories { get; set; }

    public virtual DbSet<DotcomChangeLog> DotcomChangeLogs { get; set; }

    public virtual DbSet<DotcomEbayCategory> DotcomEbayCategories { get; set; }

    public virtual DbSet<DotcomRange> DotcomRanges { get; set; }

    public virtual DbSet<DotcomRangeCategory> DotcomRangeCategories { get; set; }

    public virtual DbSet<DotcomStockCategory> DotcomStockCategories { get; set; }

    public virtual DbSet<DotcomUploadBatch> DotcomUploadBatches { get; set; }

    public virtual DbSet<DotcomUploadCategory> DotcomUploadCategories { get; set; }

    public virtual DbSet<DotcomUploadStock> DotcomUploadStocks { get; set; }

    public virtual DbSet<Dpdbatch> Dpdbatches { get; set; }

    public virtual DbSet<Dpdorder> Dpdorders { get; set; }

    public virtual DbSet<EBayCategory> EBayCategories { get; set; }

    public virtual DbSet<EBayRelatedProduct> EBayRelatedProducts { get; set; }

    public virtual DbSet<EBayStoreCategory> EBayStoreCategories { get; set; }

    public virtual DbSet<EBaySubtitle> EBaySubtitles { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<EmailTemplateLanguage> EmailTemplateLanguages { get; set; }

    public virtual DbSet<FormResource> FormResources { get; set; }

    public virtual DbSet<Fscdescription> Fscdescriptions { get; set; }

    public virtual DbSet<ImportedOrder> ImportedOrders { get; set; }

    public virtual DbSet<ImportedOrderForAllocate> ImportedOrderForAllocates { get; set; }

    public virtual DbSet<ImportedOrderForDelete> ImportedOrderForDeletes { get; set; }

    public virtual DbSet<ImportedOrderLine> ImportedOrderLines { get; set; }

    public virtual DbSet<ImportedOrderLog> ImportedOrderLogs { get; set; }

    public virtual DbSet<ImportedOrderShippedStatus> ImportedOrderShippedStatuses { get; set; }

    public virtual DbSet<ImportedPlatform> ImportedPlatforms { get; set; }

    public virtual DbSet<Incoterm> Incoterms { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceLine> InvoiceLines { get; set; }

    public virtual DbSet<InvoicePreference> InvoicePreferences { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LoginHistory> LoginHistories { get; set; }

    public virtual DbSet<LowStockAlert> LowStockAlerts { get; set; }

    public virtual DbSet<LowStockAlertItem> LowStockAlertItems { get; set; }

    public virtual DbSet<MailMessage> MailMessages { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderChangeLog> OrderChangeLogs { get; set; }

    public virtual DbSet<OrderForInvoice> OrderForInvoices { get; set; }

    public virtual DbSet<OrderLine> OrderLines { get; set; }

    public virtual DbSet<OrderLineForInvoice> OrderLineForInvoices { get; set; }

    public virtual DbSet<OrderLineImported> OrderLineImporteds { get; set; }

    public virtual DbSet<OrderReceivedBy> OrderReceivedBies { get; set; }

    public virtual DbSet<OrderTransport> OrderTransports { get; set; }

    public virtual DbSet<ParcelForceBatch> ParcelForceBatches { get; set; }

    public virtual DbSet<ParcelForceOrder> ParcelForceOrders { get; set; }

    public virtual DbSet<ParcelForceParcel> ParcelForceParcels { get; set; }

    public virtual DbSet<PendingRegistration> PendingRegistrations { get; set; }

    public virtual DbSet<PostageGroup> PostageGroups { get; set; }

    public virtual DbSet<PostageGroupPostcode> PostageGroupPostcodes { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    public virtual DbSet<PurchaseOrderBatchNumber> PurchaseOrderBatchNumbers { get; set; }

    public virtual DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }

    public virtual DbSet<RemoteCustomer> RemoteCustomers { get; set; }

    public virtual DbSet<RemoteOrder> RemoteOrders { get; set; }

    public virtual DbSet<Rimsclient> Rimsclients { get; set; }

    public virtual DbSet<RlapiPrinter> RlapiPrinters { get; set; }

    public virtual DbSet<RlapiPrinterDocument> RlapiPrinterDocuments { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoyalMailBatch> RoyalMailBatches { get; set; }

    public virtual DbSet<RoyalMailOrder> RoyalMailOrders { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<StockAmount> StockAmounts { get; set; }

    public virtual DbSet<StockCareInstructionsTranslation> StockCareInstructionsTranslations { get; set; }

    public virtual DbSet<StockCareSymbol> StockCareSymbols { get; set; }

    public virtual DbSet<StockFullDetail> StockFullDetails { get; set; }

    public virtual DbSet<StockImage> StockImages { get; set; }

    public virtual DbSet<StockLocationSortOrder> StockLocationSortOrders { get; set; }

    public virtual DbSet<StockMaterial> StockMaterials { get; set; }

    public virtual DbSet<StockMaterialDetail> StockMaterialDetails { get; set; }

    public virtual DbSet<StockMeasurement> StockMeasurements { get; set; }

    public virtual DbSet<StockMultiplier> StockMultipliers { get; set; }

    public virtual DbSet<StockOnNotification> StockOnNotifications { get; set; }

    public virtual DbSet<StockReceived> StockReceiveds { get; set; }

    public virtual DbSet<StockRequestList> StockRequestLists { get; set; }

    public virtual DbSet<StockRequestListItem> StockRequestListItems { get; set; }

    public virtual DbSet<StockRetailStringLanguage> StockRetailStringLanguages { get; set; }

    public virtual DbSet<StockRetailStringLanguageChangeLog> StockRetailStringLanguageChangeLogs { get; set; }

    public virtual DbSet<StockRetailStringMessage> StockRetailStringMessages { get; set; }

    public virtual DbSet<StockRetailWebsite> StockRetailWebsites { get; set; }

    public virtual DbSet<StockReturn> StockReturns { get; set; }

    public virtual DbSet<StockSortOrder> StockSortOrders { get; set; }

    public virtual DbSet<StockStringLanguage> StockStringLanguages { get; set; }

    public virtual DbSet<StockStringLanguageChangeLog> StockStringLanguageChangeLogs { get; set; }

    public virtual DbSet<StockStringMessage> StockStringMessages { get; set; }

    public virtual DbSet<StockTradeWebsite> StockTradeWebsites { get; set; }

    public virtual DbSet<StockTranslated> StockTranslateds { get; set; }

    public virtual DbSet<StockView> StockViews { get; set; }

    public virtual DbSet<StockWarehouse> StockWarehouses { get; set; }

    public virtual DbSet<StringLanguage> StringLanguages { get; set; }

    public virtual DbSet<StringMessage> StringMessages { get; set; }

    public virtual DbSet<Subscriber> Subscribers { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SupplierAddress> SupplierAddresses { get; set; }

    public virtual DbSet<SupplierCertificate> SupplierCertificates { get; set; }

    public virtual DbSet<SupplierCertificateStock> SupplierCertificateStocks { get; set; }

    public virtual DbSet<TempInvoiceForSync> TempInvoiceForSyncs { get; set; }

    public virtual DbSet<TempSaleStock> TempSaleStocks { get; set; }

    public virtual DbSet<TotalOutstanding> TotalOutstandings { get; set; }

    public virtual DbSet<UkmailBatch> UkmailBatches { get; set; }

    public virtual DbSet<UkmailOrder> UkmailOrders { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<UnpaidOrder> UnpaidOrders { get; set; }

    public virtual DbSet<UpdateDotcomgiftshopNow> UpdateDotcomgiftshopNows { get; set; }

    public virtual DbSet<UploadStockImage> UploadStockImages { get; set; }

    public virtual DbSet<UpsexcludedPostCode> UpsexcludedPostCodes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserCompany> UserCompanies { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<UsersInRole> UsersInRoles { get; set; }

    public virtual DbSet<UsersRlapi> UsersRlapis { get; set; }

    public virtual DbSet<VatexcludedStock> VatexcludedStocks { get; set; }

    public virtual DbSet<VatexclusionInvoice> VatexclusionInvoices { get; set; }

    public virtual DbSet<Vathistory> Vathistories { get; set; }

    public virtual DbSet<WebAccountType> WebAccountTypes { get; set; }

    public virtual DbSet<XfsChangedRow> XfsChangedRows { get; set; }

    public virtual DbSet<XmlfeedError> XmlfeedErrors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(appConfig.GetConnectionString("RexRIMSDBConnection"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccessControl>(entity =>
        {
            entity.ToTable("AccessControl");

            entity.Property(e => e.AccessControlId)
                .ValueGeneratedNever()
                .HasColumnName("AccessControlID");
            entity.Property(e => e.ApplicationName).HasMaxLength(100);
            entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            entity.Property(e => e.RoleName).HasMaxLength(100);

            entity.HasOne(d => d.Resource).WithMany(p => p.AccessControls)
                .HasForeignKey(d => d.ResourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccessControl_FormResources");
        });

        modelBuilder.Entity<ActionsLog>(entity =>
        {
            entity.HasKey(e => e.ActionLogId);

            entity.ToTable("ActionsLog");

            entity.HasIndex(e => new { e.ActionType, e.ActionDate }, "IDX_ActionsLog_ActionType_ActionDate").HasFillFactor(80);

            entity.Property(e => e.ActionLogId).HasColumnName("ActionLogID");
            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.ActionText).HasMaxLength(1024);
            entity.Property(e => e.ActionType).HasMaxLength(50);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Agreement>(entity =>
        {
            entity.ToTable("Agreement");

            entity.Property(e => e.AgreementId).HasColumnName("AgreementID");
            entity.Property(e => e.AgreementDate).HasColumnType("datetime");
            entity.Property(e => e.AgreementHtmlStringId).HasColumnName("AgreementHTML_StringID");
            entity.Property(e => e.TitleStringId).HasColumnName("Title_StringID");
        });

        modelBuilder.Entity<AmazonErrorOrder>(entity =>
        {
            entity.HasKey(e => e.OriginalOrderId);

            entity.ToTable("AmazonErrorOrder");

            entity.Property(e => e.OriginalOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OriginalOrderID");
            entity.Property(e => e.LastDownloadOrUploadAttempt).HasColumnType("datetime");
            entity.Property(e => e.LastSentErrorEmail).HasColumnType("datetime");
            entity.Property(e => e.SubType).HasMaxLength(32);
        });

        modelBuilder.Entity<AmazonFbaFix>(entity =>
        {
            entity.HasKey(e => e.FixId);

            entity.ToTable("AmazonFBA_Fix");

            entity.Property(e => e.FixId).HasColumnName("FixID");
            entity.Property(e => e.Invoice)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AmazonFbaFixImportedOrder>(entity =>
        {
            entity.HasKey(e => new { e.FixId, e.ImportedOrderId }).HasName("PK_AmazonFBA_FixImportedOrders");

            entity.ToTable("AmazonFBA_FixImportedOrder");

            entity.Property(e => e.FixId).HasColumnName("FixID");
            entity.Property(e => e.ImportedOrderId).HasColumnName("ImportedOrderID");
        });

        modelBuilder.Entity<AmazonFbaFixImportedOrderLine>(entity =>
        {
            entity.HasKey(e => new { e.FixId, e.ImportedOrderLineId });

            entity.ToTable("AmazonFBA_FixImportedOrderLine");

            entity.Property(e => e.FixId).HasColumnName("FixID");
            entity.Property(e => e.ImportedOrderLineId).HasColumnName("ImportedOrderLineID");
        });

        modelBuilder.Entity<AmazonStock>(entity =>
        {
            entity.HasKey(e => e.StockCode);

            entity.ToTable("AmazonStock");

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Attribute>(entity =>
        {
            entity.ToTable("Attribute");

            entity.Property(e => e.AttributeId).HasColumnName("AttributeID");
            entity.Property(e => e.TitleStringId).HasColumnName("TitleStringID");

            entity.HasOne(d => d.TitleString).WithMany(p => p.Attributes)
                .HasForeignKey(d => d.TitleStringId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attribute_TitleStringID");
        });

        modelBuilder.Entity<AttributeValue>(entity =>
        {
            entity.ToTable("AttributeValue");

            entity.Property(e => e.AttributeValueId).HasColumnName("AttributeValueID");
            entity.Property(e => e.AttributeId).HasColumnName("AttributeID");
            entity.Property(e => e.TitleStringId).HasColumnName("TitleStringID");

            entity.HasOne(d => d.Attribute).WithMany(p => p.AttributeValues)
                .HasForeignKey(d => d.AttributeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttributeValue_AttributeID");

            entity.HasOne(d => d.TitleString).WithMany(p => p.AttributeValues)
                .HasForeignKey(d => d.TitleStringId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttributeValue_TitleStringID");
        });

        modelBuilder.Entity<AttributeValueView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AttributeValueView");

            entity.Property(e => e.AttributeId).HasColumnName("AttributeID");
            entity.Property(e => e.AttributeValueId).HasColumnName("AttributeValueID");
            entity.Property(e => e.TitleStringId).HasColumnName("TitleStringID");
        });

        modelBuilder.Entity<AttributeView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AttributeView");

            entity.Property(e => e.AttributeId).HasColumnName("AttributeID");
            entity.Property(e => e.TitleStringId).HasColumnName("TitleStringID");
        });

        modelBuilder.Entity<AutoReport>(entity =>
        {
            entity.HasKey(e => e.AutoReportCode);

            entity.ToTable("AutoReport");

            entity.Property(e => e.AutoReportCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AutoReportLog>(entity =>
        {
            entity.ToTable("AutoReportLog");

            entity.Property(e => e.AutoReportLogId).HasColumnName("AutoReportLogID");
            entity.Property(e => e.AutoReportScheduleId).HasColumnName("AutoReportScheduleID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ReportFileName)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.AutoReportSchedule).WithMany(p => p.AutoReportLogs)
                .HasForeignKey(d => d.AutoReportScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutoReportLog_AutoReportScheduleID");
        });

        modelBuilder.Entity<AutoReportSchedule>(entity =>
        {
            entity.HasKey(e => e.AutoReportScheduleId).HasName("PK_AutoRunReportSchedule");

            entity.ToTable("AutoReportSchedule");

            entity.Property(e => e.AutoReportScheduleId).HasColumnName("AutoReportScheduleID");
            entity.Property(e => e.AutoReportCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastRun).HasColumnType("datetime");
            entity.Property(e => e.Scheduled)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.AutoReportCodeNavigation).WithMany(p => p.AutoReportSchedules)
                .HasForeignKey(d => d.AutoReportCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutoRunReportSchedule_AutoReportCode");
        });

        modelBuilder.Entity<BulkImportOperation>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ErrorDetails).HasMaxLength(500);
            entity.Property(e => e.NotificationDateRead).HasColumnType("datetime");
            entity.Property(e => e.OperationDataType).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<BulletDescription>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LanguageId).HasColumnName("Language_ID");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CareSymbol>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CareSymbol");

            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Text)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category", tb => tb.HasTrigger("tr_Category_ChangedRows_xfs"));

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryImageName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IntroTextStringId).HasColumnName("IntroText_StringID");
            entity.Property(e => e.NameStringId).HasColumnName("Name_StringID");
            entity.Property(e => e.ParentCategoryId).HasColumnName("ParentCategoryID");
            entity.Property(e => e.Tid).HasColumnName("TID");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
            entity.Property(e => e.Visable).HasDefaultValue(false);
            entity.Property(e => e.XfsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("xfs_SynchronizationKeyID");

            entity.HasOne(d => d.IntroTextString).WithMany(p => p.CategoryIntroTextStrings)
                .HasForeignKey(d => d.IntroTextStringId)
                .HasConstraintName("FK_StockCategory_StringMessage_IntroText");

            entity.HasOne(d => d.NameString).WithMany(p => p.CategoryNameStrings)
                .HasForeignKey(d => d.NameStringId)
                .HasConstraintName("FK_StockCategory_StringMessage_Name");
        });

        modelBuilder.Entity<CategoryByDesignView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CategoryByDesignView");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryImageName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IntroTextStringId).HasColumnName("IntroText_StringID");
            entity.Property(e => e.NameEnglish).HasColumnName("Name_English");
            entity.Property(e => e.NameStringId).HasColumnName("Name_StringID");
            entity.Property(e => e.ParentCategoryId).HasColumnName("ParentCategoryID");
            entity.Property(e => e.Tid).HasColumnName("TID");
            entity.Property(e => e.XfsSynchronizationKeyId).HasColumnName("xfs_SynchronizationKeyID");
        });

        modelBuilder.Entity<CategoryByProductView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CategoryByProductView");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryImageName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IntroTextStringId).HasColumnName("IntroText_StringID");
            entity.Property(e => e.NameEnglish).HasColumnName("Name_English");
            entity.Property(e => e.NameStringId).HasColumnName("Name_StringID");
            entity.Property(e => e.ParentCategoryId).HasColumnName("ParentCategoryID");
            entity.Property(e => e.Tid).HasColumnName("TID");
            entity.Property(e => e.XfsSynchronizationKeyId).HasColumnName("xfs_SynchronizationKeyID");
        });

        modelBuilder.Entity<CategoryWithFullNameView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CategoryWithFullNameView");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.RootId).HasColumnName("RootID");
        });

        modelBuilder.Entity<CcorderPayment>(entity =>
        {
            entity.ToTable("CCOrderPayment");

            entity.Property(e => e.CcorderPaymentId)
                .ValueGeneratedNever()
                .HasColumnName("CCOrderPaymentID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AutorisationCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("autorisationCode");
            entity.Property(e => e.CcExpMm)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ccExpMM");
            entity.Property(e => e.CcExpYy)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ccExpYY");
            entity.Property(e => e.CcIssue)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ccIssue");
            entity.Property(e => e.CcNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ccNumber");
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.County)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("customerAccount");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMail");
            entity.Property(e => e.Invoice)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderReference)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("orderReference");
            entity.Property(e => e.OriginatorUnitId).HasColumnName("OriginatorUnitID");
            entity.Property(e => e.PaymentDateAnswer)
                .HasColumnType("smalldatetime")
                .HasColumnName("paymentDateAnswer");
            entity.Property(e => e.PaymentDateRequest)
                .HasColumnType("smalldatetime")
                .HasColumnName("paymentDateRequest");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Postcode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Pending")
                .HasColumnName("status");
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.TlsSynchronizationKeyId).HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.Town)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TranAmount)
                .HasColumnType("money")
                .HasColumnName("tranAmount");
            entity.Property(e => e.TranMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tranMessage");
            entity.Property(e => e.TranReference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tranReference");
            entity.Property(e => e.TranResult)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tranResult");
            entity.Property(e => e.TranTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("tranTime");
            entity.Property(e => e.ValuePaid)
                .HasColumnType("money")
                .HasColumnName("valuePaid");
            entity.Property(e => e.ValueSentToPayment)
                .HasColumnType("money")
                .HasColumnName("valueSentToPayment");
        });

        modelBuilder.Entity<CheckResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VATNumberCheckResponse");

            entity.ToTable("CheckResponse");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.CheckDate).HasColumnType("datetime");
            entity.Property(e => e.CheckNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CheckType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CountryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(100);
            entity.Property(e => e.OrderId)
                .HasMaxLength(100)
                .HasColumnName("OrderID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<CommodityCode>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CommodityCode");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(100);
            entity.Property(e => e.Text).HasMaxLength(200);
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.Property(e => e.Address1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address4)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Vat1)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("VAT1");
            entity.Property(e => e.Vatregistration)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VATRegistration");
        });

        modelBuilder.Entity<CompanyMessage>(entity =>
        {
            entity.ToTable("CompanyMessage");

            entity.Property(e => e.CompanyMessageId).HasColumnName("CompanyMessageID");
            entity.Property(e => e.Body)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.FromCustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ReadDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ToUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ToUserID");
        });

        modelBuilder.Entity<ContactType>(entity =>
        {
            entity.ToTable("ContactType");

            entity.Property(e => e.ContactTypeId)
                .ValueGeneratedNever()
                .HasColumnName("ContactTypeID");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.HasKey(e => e.GuidId);

            entity.Property(e => e.GuidId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("GuidID");
            entity.Property(e => e.CounterType)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OriginatorUnitId).HasColumnName("OriginatorUnitID");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.HasIndex(e => e.Code, "IX_Country").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Crukcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CRUKCode");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DotcomCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DpdcountryCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DPDCountryCode");
            entity.Property(e => e.DpdtermsOfDelivery)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("DAP")
                .HasColumnName("DPDTermsOfDelivery");
            entity.Property(e => e.Eec).HasColumnName("EEC");
            entity.Property(e => e.Eeccode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("EECCode");
            entity.Property(e => e.ExcludeDpdtrade).HasColumnName("ExcludeDPDTrade");
            entity.Property(e => e.FormatProvider)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RemotePostcodes).IsUnicode(false);
            entity.Property(e => e.RetailPostage).HasColumnType("smallmoney");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
            entity.Property(e => e.UpscountryCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("UPSCountryCode");
            entity.Property(e => e.Vatrate)
                .HasColumnType("money")
                .HasColumnName("VATRate");

            entity.HasOne(d => d.Currency).WithMany(p => p.Countries)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Country_CurrencyID");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.ToTable("Currency");

            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.FormatProvider)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.LongName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.RetailExchangeRate).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.Shortname)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Account);

            entity.ToTable("Customer");

            entity.HasIndex(e => new { e.Account, e.Name, e.Firstname, e.Surname, e.Other2, e.Other3, e.Postcode }, "IX_Customer").HasFillFactor(80);

            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.AccountType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address4)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AddressNote)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AddressRef)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CatalogAddressId).HasColumnName("CatalogAddressID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Contact)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerTermsId).HasColumnName("CustomerTermsID");
            entity.Property(e => e.Dapoverride).HasColumnName("DAPOverride");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DetailsLastUpdated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Eori)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EORI");
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.FirstOrderDate).HasColumnType("datetime");
            entity.Property(e => e.Firstname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HowFound).HasMaxLength(100);
            entity.Property(e => e.IncotermCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("EXW");
            entity.Property(e => e.InvoicePrintDiscount).HasColumnType("money");
            entity.Property(e => e.IsEorivalid).HasColumnName("IsEORIValid");
            entity.Property(e => e.IsVatnumberApproved)
                .HasDefaultValue(true)
                .HasColumnName("IsVATNumberApproved");
            entity.Property(e => e.IsVatnumberValid).HasColumnName("IsVATNumberValid");
            entity.Property(e => e.LastCash).HasColumnType("smalldatetime");
            entity.Property(e => e.LastOrdered).HasColumnType("smalldatetime");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.OriginalBalance).HasColumnType("smallmoney");
            entity.Property(e => e.Other1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Other2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Other3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Outstanding).HasColumnType("money");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Postcode)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.RetailerType).IsUnicode(false);
            entity.Property(e => e.SearchKeyword)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SellerType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SellingOnWebsites).IsUnicode(false);
            entity.Property(e => e.Shortname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SignupMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Telex)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TELEX");
            entity.Property(e => e.TermsAgreed).HasDefaultValue(true);
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.Title)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TradePeriod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vatnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VATNumber");
            entity.Property(e => e.WantsCatalogue)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.WebAccountId)
                .HasDefaultValue(1)
                .HasColumnName("WebAccountID");
            entity.Property(e => e.WebAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CustomerOrigin).WithMany(p => p.Customers)
                .HasForeignKey(d => d.CustomerOriginId)
                .HasConstraintName("FK_Customer_CustomerOrigin");
        });

        modelBuilder.Entity<CustomerAccountActivation>(entity =>
        {
            entity.ToTable("CustomerAccountActivation");

            entity.Property(e => e.ConfirmedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerAgreement>(entity =>
        {
            entity.HasKey(e => new { e.AgreementId, e.CustomerAccount });

            entity.ToTable("CustomerAgreement");

            entity.Property(e => e.AgreementId).HasColumnName("AgreementID");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AcceptedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Agreement).WithMany(p => p.CustomerAgreements)
                .HasForeignKey(d => d.AgreementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerAgreement_AgreementID");
        });

        modelBuilder.Entity<CustomerBranch>(entity =>
        {
            entity.HasKey(e => new { e.CustomerBranchId, e.Originator }).HasName("PK_CustomerBranch_1");

            entity.ToTable("CustomerBranch");

            entity.Property(e => e.CustomerBranchId).HasColumnName("CustomerBranchID");
            entity.Property(e => e.AccountType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Address1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address4)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AddressRef)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CatalogAddressId).HasColumnName("CatalogAddressID");
            entity.Property(e => e.Contact)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.Firstname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IsApproved).HasDefaultValue(true);
            entity.Property(e => e.LastCash).HasColumnType("smalldatetime");
            entity.Property(e => e.LastOrdered).HasColumnType("smalldatetime");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.Other1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Other2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Outstanding).HasColumnType("smallmoney");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Postcode)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Shortname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Telex)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TELEX");
            entity.Property(e => e.Terms)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TermsAgreed).HasDefaultValue(true);
            entity.Property(e => e.Title)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
            entity.Property(e => e.Vatnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VATNumber");
            entity.Property(e => e.WantsCatalogue)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");

            entity.HasOne(d => d.CustomerAccountNavigation).WithMany(p => p.CustomerBranches)
                .HasForeignKey(d => d.CustomerAccount)
                .HasConstraintName("FK_CustomerBranch_Customer");
        });

        modelBuilder.Entity<CustomerContact>(entity =>
        {
            entity.HasKey(e => new { e.CustomerContactId, e.Originator });

            entity.ToTable("CustomerContact");

            entity.HasIndex(e => new { e.CustomerAccount, e.CustomerDepartment }, "UQ_CustomerAccount_CustomerDepartment")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.CustomerContactId).HasColumnName("CustomerContactID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerDepartment)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email1ContactTypeId).HasColumnName("Email1ContactTypeID");
            entity.Property(e => e.Email2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email2ContactTypeId).HasColumnName("Email2ContactTypeID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Phone1)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Phone1ContactTypeId).HasColumnName("Phone1ContactTypeID");
            entity.Property(e => e.Phone2)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Phone2ContactTypeId).HasColumnName("Phone2ContactTypeID");
            entity.Property(e => e.Phone3)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Phone3ContactTypeId).HasColumnName("Phone3ContactTypeID");
            entity.Property(e => e.Surname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.Title)
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.HasOne(d => d.CustomerAccountNavigation).WithMany(p => p.CustomerContacts)
                .HasForeignKey(d => d.CustomerAccount)
                .HasConstraintName("FK_CustomerContact_Customer");

            entity.HasOne(d => d.Email1ContactType).WithMany(p => p.CustomerContactEmail1ContactTypes)
                .HasForeignKey(d => d.Email1ContactTypeId)
                .HasConstraintName("FK_CustomerContact_ContactType4");

            entity.HasOne(d => d.Email2ContactType).WithMany(p => p.CustomerContactEmail2ContactTypes)
                .HasForeignKey(d => d.Email2ContactTypeId)
                .HasConstraintName("FK_CustomerContact_ContactType5");

            entity.HasOne(d => d.Phone1ContactType).WithMany(p => p.CustomerContactPhone1ContactTypes)
                .HasForeignKey(d => d.Phone1ContactTypeId)
                .HasConstraintName("FK_CustomerContact_ContactType1");

            entity.HasOne(d => d.Phone2ContactType).WithMany(p => p.CustomerContactPhone2ContactTypes)
                .HasForeignKey(d => d.Phone2ContactTypeId)
                .HasConstraintName("FK_CustomerContact_ContactType2");

            entity.HasOne(d => d.Phone3ContactType).WithMany(p => p.CustomerContactPhone3ContactTypes)
                .HasForeignKey(d => d.Phone3ContactTypeId)
                .HasConstraintName("FK_CustomerContact_ContactType3");
        });

        modelBuilder.Entity<CustomerMessage>(entity =>
        {
            entity.ToTable("CustomerMessage");

            entity.Property(e => e.CustomerMessageId).HasColumnName("CustomerMessageID");
            entity.Property(e => e.Body)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FromUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FromUserID");
            entity.Property(e => e.ReadDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ToCustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ToCustomerId).HasColumnName("ToCustomerID");
        });

        modelBuilder.Entity<CustomerOnWatch>(entity =>
        {
            entity.ToTable("CustomerOnWatch");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PostCode).HasMaxLength(100);
            entity.Property(e => e.Reason).HasMaxLength(200);
        });

        modelBuilder.Entity<CustomerOnWatchRetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CustomerOnWatchRetail");

            entity.Property(e => e.CustomerOnWatchId).HasColumnName("CustomerOnWatchID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.ImportedOrderId).HasColumnName("ImportedOrderID");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Postcode).HasMaxLength(100);
        });

        modelBuilder.Entity<CustomerOnWatchTrade>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CustomerOnWatchTrade");

            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerOnWatchId).HasColumnName("CustomerOnWatchID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Postcode).HasMaxLength(100);
        });

        modelBuilder.Entity<CustomerOrigin>(entity =>
        {
            entity.ToTable("CustomerOrigin");

            entity.HasIndex(e => e.Name, "UQ_CustomerOrigin_Name")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerRank>(entity =>
        {
            entity.ToTable("CustomerRank");

            entity.HasIndex(e => new { e.CustomerAccount, e.RankYear, e.RankMonth }, "UQ_CustomerRank")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.CustomerRankId).HasColumnName("CustomerRankID");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RankChangeDirection)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalRank).HasComputedColumnSql("(([FrequencyRank]+[RecencyRank])+[MonetaryRank])", false);
        });

        modelBuilder.Entity<CustomerRlapi>(entity =>
        {
            entity.HasKey(e => e.Account);

            entity.ToTable("CustomerRLAPI");

            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Access)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerTerm>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CustomerTermsId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CustomerTermsID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerTransaction>(entity =>
        {
            entity.HasKey(e => e.CustomerTransactionId).IsClustered(false);

            entity.ToTable("CustomerTransaction");

            entity.HasIndex(e => e.CustomerAccount, "IDX_CustomerTransaction_CustomerAccount").HasFillFactor(80);

            entity.HasIndex(e => e.Reference, "IDX_CustomerTransaction_Reference").HasFillFactor(80);

            entity.Property(e => e.CustomerTransactionId).HasColumnName("CustomerTransactionID");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.DeliveryCustomerBranchId).HasColumnName("DeliveryCustomerBranchID");
            entity.Property(e => e.Mandate)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Period)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Reference)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.SettledDate).HasColumnType("datetime");
            entity.Property(e => e.SettledValue).HasColumnType("money");
            entity.Property(e => e.Text)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UserPkid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserPKID");
            entity.Property(e => e.Value1).HasColumnType("money");
            entity.Property(e => e.Value2).HasColumnType("money");
            entity.Property(e => e.Value3).HasColumnType("money");
            entity.Property(e => e.Value4).HasColumnType("money");
            entity.Property(e => e.Value4Ster)
                .HasColumnType("money")
                .HasColumnName("Value4_Ster");
            entity.Property(e => e.Value5).HasColumnType("money");
            entity.Property(e => e.Value6).HasColumnType("money");
        });

        modelBuilder.Entity<DotcomCategory>(entity =>
        {
            entity.HasKey(e => e.Tid);

            entity.ToTable("DotcomCategory");

            entity.Property(e => e.Tid)
                .ValueGeneratedNever()
                .HasColumnName("TID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DotcomChangeLog>(entity =>
        {
            entity.ToTable("DotcomChangeLog");

            entity.Property(e => e.DotcomChangeLogId).HasColumnName("DotcomChangeLogID");
            entity.Property(e => e.ActionName).HasMaxLength(32);
            entity.Property(e => e.Flags).HasMaxLength(256);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.Text).HasMaxLength(256);
            entity.Property(e => e.Tid).HasColumnName("TID");
        });

        modelBuilder.Entity<DotcomEbayCategory>(entity =>
        {
            entity.HasKey(e => e.Tid);

            entity.ToTable("DotcomEbayCategory");

            entity.Property(e => e.Tid)
                .ValueGeneratedNever()
                .HasColumnName("TID");
            entity.Property(e => e.EBayCategoryId).HasColumnName("eBayCategoryID");
            entity.Property(e => e.StoreCategoryId).HasColumnName("StoreCategoryID");
        });

        modelBuilder.Entity<DotcomRange>(entity =>
        {
            entity.ToTable("DotcomRange");

            entity.Property(e => e.DotcomRangeId).HasColumnName("DotcomRangeID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<DotcomRangeCategory>(entity =>
        {
            entity.HasKey(e => e.Tid).HasName("PK_DotcomRangeStock");

            entity.ToTable("DotcomRangeCategory");

            entity.Property(e => e.Tid)
                .ValueGeneratedNever()
                .HasColumnName("TID");
            entity.Property(e => e.DotcomRangeId).HasColumnName("DotcomRangeID");

            entity.HasOne(d => d.DotcomRange).WithMany(p => p.DotcomRangeCategories)
                .HasForeignKey(d => d.DotcomRangeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DotcomRangeStock_DotcomRangeID");

            entity.HasOne(d => d.TidNavigation).WithOne(p => p.DotcomRangeCategory)
                .HasForeignKey<DotcomRangeCategory>(d => d.Tid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DotcomRangeStock_TID");
        });

        modelBuilder.Entity<DotcomStockCategory>(entity =>
        {
            entity.HasKey(e => new { e.Stockcode, e.Tid });

            entity.ToTable("DotcomStockCategory");

            entity.Property(e => e.Stockcode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Tid).HasColumnName("TID");

            entity.HasOne(d => d.StockcodeNavigation).WithMany(p => p.DotcomStockCategories)
                .HasForeignKey(d => d.Stockcode)
                .HasConstraintName("FK_DotcomStockCategory_DotcomCategory");
        });

        modelBuilder.Entity<DotcomUploadBatch>(entity =>
        {
            entity.ToTable("DotcomUploadBatch");

            entity.Property(e => e.DotcomUploadBatchId).HasColumnName("DotcomUploadBatchID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DotcomUploadCategory>(entity =>
        {
            entity.HasKey(e => new { e.DotcomUploadBatchId, e.Tid });

            entity.ToTable("DotcomUploadCategory");

            entity.Property(e => e.DotcomUploadBatchId).HasColumnName("DotcomUploadBatchID");
            entity.Property(e => e.Tid).HasColumnName("TID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.DotcomUploadBatch).WithMany(p => p.DotcomUploadCategories)
                .HasForeignKey(d => d.DotcomUploadBatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DotcomUploadCategory_DotcomUploadBatchID");
        });

        modelBuilder.Entity<DotcomUploadStock>(entity =>
        {
            entity.HasKey(e => new { e.DotcomUploadBatchId, e.Tid, e.StockCode });

            entity.ToTable("DotcomUploadStock");

            entity.Property(e => e.DotcomUploadBatchId).HasColumnName("DotcomUploadBatchID");
            entity.Property(e => e.Tid).HasColumnName("TID");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ActionName).HasMaxLength(50);

            entity.HasOne(d => d.DotcomUploadBatch).WithMany(p => p.DotcomUploadStocks)
                .HasForeignKey(d => d.DotcomUploadBatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DotcomUploadStock_DotcomUploadBatchID");
        });

        modelBuilder.Entity<Dpdbatch>(entity =>
        {
            entity.ToTable("DPDBatch");

            entity.Property(e => e.DpdbatchId).HasColumnName("DPDBatchID");
            entity.Property(e => e.CollectionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Dpdorder>(entity =>
        {
            entity.HasKey(e => e.ImportedOrderId);

            entity.ToTable("DPDOrder");

            entity.Property(e => e.ImportedOrderId)
                .ValueGeneratedNever()
                .HasColumnName("ImportedOrderID");
            entity.Property(e => e.AccountCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BarcodeContent)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DpdbatchId).HasColumnName("DPDBatchID");
            entity.Property(e => e.ParcelNumber).HasDefaultValue(1);
            entity.Property(e => e.ParcelTrackingNo)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.ServiceCode)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Dpdbatch).WithMany(p => p.Dpdorders)
                .HasForeignKey(d => d.DpdbatchId)
                .HasConstraintName("FK_DPDOrder_DPDBarchID");

            entity.HasOne(d => d.ImportedOrder).WithOne(p => p.Dpdorder)
                .HasForeignKey<Dpdorder>(d => d.ImportedOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DPDOrder_ImportedOrderID");
        });

        modelBuilder.Entity<EBayCategory>(entity =>
        {
            entity.ToTable("eBayCategory");

            entity.Property(e => e.EBayCategoryId)
                .ValueGeneratedNever()
                .HasColumnName("eBayCategoryID");
            entity.Property(e => e.FullPath).HasMaxLength(500);
            entity.Property(e => e.LastSynchronizedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
        });

        modelBuilder.Entity<EBayRelatedProduct>(entity =>
        {
            entity.HasKey(e => e.StockCode);

            entity.ToTable("eBayRelatedProduct");

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EBayStoreCategory>(entity =>
        {
            entity.HasKey(e => e.StoreCategoryId);

            entity.ToTable("eBayStoreCategory");

            entity.Property(e => e.StoreCategoryId)
                .ValueGeneratedNever()
                .HasColumnName("StoreCategoryID");
            entity.Property(e => e.FullPath).HasMaxLength(500);
            entity.Property(e => e.LastSynchronizedDate).HasColumnType("datetime");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<EBaySubtitle>(entity =>
        {
            entity.HasKey(e => e.SubtitleId);

            entity.ToTable("eBaySubtitle");

            entity.Property(e => e.SubtitleId).HasColumnName("SubtitleID");
            entity.Property(e => e.Text).HasMaxLength(55);
        });

        modelBuilder.Entity<EmailTemplate>(entity =>
        {
            entity.ToTable("EmailTemplate");

            entity.Property(e => e.EmailTemplateId)
                .ValueGeneratedNever()
                .HasColumnName("EmailTemplateID");
            entity.Property(e => e.Bcc)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("BCC");
            entity.Property(e => e.Cc)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CC");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.FromEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FromName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.OnlyLanguageId).HasColumnName("OnlyLanguageID");
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmailTemplateLanguage>(entity =>
        {
            entity.HasKey(e => new { e.EmailTemplateId, e.LanguageId });

            entity.ToTable("EmailTemplateLanguage");

            entity.Property(e => e.EmailTemplateId).HasColumnName("EmailTemplateID");
            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.Subject).HasMaxLength(100);

            entity.HasOne(d => d.EmailTemplate).WithMany(p => p.EmailTemplateLanguages)
                .HasForeignKey(d => d.EmailTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailTemplateLanguage_EmailTemplateID");

            entity.HasOne(d => d.Language).WithMany(p => p.EmailTemplateLanguages)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailTemplateLanguage_LanguageID");
        });

        modelBuilder.Entity<FormResource>(entity =>
        {
            entity.HasKey(e => e.Pkid);

            entity.Property(e => e.Pkid)
                .ValueGeneratedNever()
                .HasColumnName("PKID");
            entity.Property(e => e.FormName)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Fscdescription>(entity =>
        {
            entity.ToTable("FSCDescription");

            entity.HasIndex(e => e.DescriptionText, "UQ_FSCDescription_DescriptionText")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.FscdescriptionId).HasColumnName("FSCDescriptionID");
            entity.Property(e => e.DescriptionText)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImportedOrder>(entity =>
        {
            entity.ToTable("ImportedOrder");

            entity.HasIndex(e => e.BatchNumber, "IDX_ImportedOrder_BatchNumber").HasFillFactor(80);

            entity.HasIndex(e => e.Email, "IDX_ImportedOrder_Email").HasFillFactor(80);

            entity.HasIndex(e => e.OriginalOrderId, "IDX_ImportedOrder_OriginalOrderID").HasFillFactor(80);

            entity.HasIndex(e => new { e.PickingListPrintedDate, e.IsAllocated, e.IsCanceled, e.PlatformId }, "IX_ImportedOrder_PickingListPrintedDate_IsAllocated_IsCanceled").HasFillFactor(80);

            entity.HasIndex(e => new { e.ForImport, e.IsAllocated, e.PlatformId }, "_dta_index_ImportedOrder_5_1092198941__K29_K40_K32").HasFillFactor(80);

            entity.HasIndex(e => new { e.ForImport, e.DeliveryCompany }, "_dta_index_ImportedOrder_5_1092198941__K29_K9_2_5_6_7_13_15_16_18_22_32").HasFillFactor(80);

            entity.Property(e => e.ImportedOrderId)
                .ValueGeneratedNever()
                .HasColumnName("ImportedOrderID");
            entity.Property(e => e.AutoPrintErrorMessage).HasMaxLength(256);
            entity.Property(e => e.BatchInRops).HasColumnName("BatchInROPS");
            entity.Property(e => e.BatchNumber)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddress1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddress2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddress3)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BillingAddress4)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BillingCompany)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BillingCountry)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BillingFirstname)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BillingPhone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BillingSurname)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CarrierScannedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CarrierScannedId).HasColumnName("CarrierScannedID");
            entity.Property(e => e.CompanyId)
                .HasDefaultValue(2)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CouponCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CouponDiscount).HasColumnType("smallmoney");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerComment)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CustomerEori)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CustomerEORI");
            entity.Property(e => e.CustomerVat)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CustomerVAT");
            entity.Property(e => e.DeliveryAddress1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryAddress2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryAddress3)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryAddress4)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryCompany)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryCountry)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryFirstname)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryPhone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryRate).HasColumnType("smallmoney");
            entity.Property(e => e.DeliverySurname)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryUpslocationId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DeliveryUPSLocationID");
            entity.Property(e => e.DpdtermsOfDelivery)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DPDTermsOfDelivery");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.FirstDespatchDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceReference)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.ManifestPrintedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.NoLabelInRops).HasColumnName("NoLabelInROPS");
            entity.Property(e => e.OrderStatus).HasMaxLength(50);
            entity.Property(e => e.OrderTotal).HasColumnType("smallmoney");
            entity.Property(e => e.OriginalOrderId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OriginalOrderID");
            entity.Property(e => e.PackerDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PackerId).HasColumnName("PackerID");
            entity.Property(e => e.ParcelServiceProvider).HasMaxLength(50);
            entity.Property(e => e.ParcelServiceProviderOverride).HasMaxLength(50);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PickerDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PickerId).HasColumnName("PickerID");
            entity.Property(e => e.PickerPackerAppPrintedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PickingListCompletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PickingListPrintedDate).HasColumnType("datetime");
            entity.Property(e => e.PlatformId).HasColumnName("PlatformID");
            entity.Property(e => e.PrintedDate).HasColumnType("datetime");
            entity.Property(e => e.SentToRops)
                .HasColumnType("smalldatetime")
                .HasColumnName("SentToROPS");
            entity.Property(e => e.SequenceInRops).HasColumnName("SequenceInROPS");
            entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.TrackingNumber).HasMaxLength(100);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UtcModifiedDate).HasColumnType("smalldatetime");

            entity.HasOne(d => d.Currency).WithMany(p => p.ImportedOrders)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("FK_ImportedOrder_CurrencyID");

            entity.HasOne(d => d.Language).WithMany(p => p.ImportedOrders)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_ImportedOrder_LanguageID");

            entity.HasOne(d => d.Packer).WithMany(p => p.ImportedOrderPackers)
                .HasForeignKey(d => d.PackerId)
                .HasConstraintName("FK_Packer_Users");

            entity.HasOne(d => d.Picker).WithMany(p => p.ImportedOrderPickers)
                .HasForeignKey(d => d.PickerId)
                .HasConstraintName("FK_Picker_Users");

            entity.HasOne(d => d.Platform).WithMany(p => p.ImportedOrders)
                .HasForeignKey(d => d.PlatformId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportedOrder_PlatformID");
        });

        modelBuilder.Entity<ImportedOrderForAllocate>(entity =>
        {
            entity.ToTable("ImportedOrderForAllocate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ImportedOrderId).HasColumnName("ImportedOrderID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<ImportedOrderForDelete>(entity =>
        {
            entity.HasKey(e => e.ImportedOrderId);

            entity.ToTable("ImportedOrderForDelete");

            entity.Property(e => e.ImportedOrderId)
                .ValueGeneratedNever()
                .HasColumnName("ImportedOrderID");
        });

        modelBuilder.Entity<ImportedOrderLine>(entity =>
        {
            entity.ToTable("ImportedOrderLine");

            entity.HasIndex(e => e.ImportedOrderId, "IX_ImportedOrderLine_ImportedOrderID").HasFillFactor(80);

            entity.HasIndex(e => e.StockCode, "_dta_index_ImportedOrderLine_5_1381579960__K2").HasFillFactor(80);

            entity.Property(e => e.ImportedOrderLineId)
                .ValueGeneratedNever()
                .HasColumnName("ImportedOrderLineID");
            entity.Property(e => e.Fees).HasColumnType("smallmoney");
            entity.Property(e => e.ImportedOrderId).HasColumnName("ImportedOrderID");
            entity.Property(e => e.Option)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OriginalOrderLineId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OriginalOrderLineID");
            entity.Property(e => e.PickingListPickedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ShippingPrice).HasColumnType("smallmoney");
            entity.Property(e => e.StockCode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TotalPrice).HasColumnType("smallmoney");

            entity.HasOne(d => d.ImportedOrder).WithMany(p => p.ImportedOrderLines)
                .HasForeignKey(d => d.ImportedOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportedOrderLine_ImportedOrderID");
        });

        modelBuilder.Entity<ImportedOrderLog>(entity =>
        {
            entity.ToTable("ImportedOrderLog");

            entity.Property(e => e.ImportedOrderLogId).HasColumnName("ImportedOrderLogID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ImportedOrderId).HasColumnName("ImportedOrderID");
            entity.Property(e => e.OrderStatus).HasMaxLength(50);
            entity.Property(e => e.ParcelServiceProvider).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.ImportedOrder).WithMany(p => p.ImportedOrderLogs)
                .HasForeignKey(d => d.ImportedOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportedOrderLog_ImportedOrderID");
        });

        modelBuilder.Entity<ImportedOrderShippedStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ImportedOrderShippedStatus");

            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryCompany).HasMaxLength(50);
            entity.Property(e => e.ImportedOrderId).HasColumnName("ImportedOrderID");
            entity.Property(e => e.OriginalOrderId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OriginalOrderID");
            entity.Property(e => e.PlatformId).HasColumnName("PlatformID");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImportedPlatform>(entity =>
        {
            entity.HasKey(e => e.PlatformId);

            entity.ToTable("ImportedPlatform");

            entity.Property(e => e.PlatformId)
                .ValueGeneratedNever()
                .HasColumnName("PlatformID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Incoterm>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_Incoterms");

            entity.ToTable("Incoterm");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.Invoice1).IsClustered(false);

            entity.ToTable("Invoice");

            entity.HasIndex(e => e.CustomerAccount, "IDX_Invoice_CustomerAccount").HasFillFactor(80);

            entity.Property(e => e.Invoice1)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Invoice");
            entity.Property(e => e.AccountType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CardPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConsignmentNumber)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId)
                .HasDefaultValue(97)
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerBranchId).HasColumnName("CustomerBranchID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerReference)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Deleted)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryCountryId).HasColumnName("DeliveryCountryID");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Eeccode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("EECCode");
            entity.Property(e => e.Eechidden).HasColumnName("EECHidden");
            entity.Property(e => e.EmailedToCustomerDate).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(7, 2)");
            entity.Property(e => e.Goods).HasColumnType("money");
            entity.Property(e => e.Goods1).HasColumnType("money");
            entity.Property(e => e.Goods2).HasColumnType("money");
            entity.Property(e => e.Goods3).HasColumnType("money");
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.OrderComments)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OrderID");
            entity.Property(e => e.PackedDate).HasColumnType("datetime");
            entity.Property(e => e.Paid).HasColumnType("money");
            entity.Property(e => e.PayerName).HasMaxLength(256);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ReceivedBy)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Rep)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("REP");
            entity.Property(e => e.SettlementDiscount).HasColumnType("smallmoney");
            entity.Property(e => e.ShowOnline).HasDefaultValue(true);
            entity.Property(e => e.TheirReference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.Vat)
                .HasColumnType("money")
                .HasColumnName("VAT");
            entity.Property(e => e.Vatnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VATNumber");
            entity.Property(e => e.Vatrate)
                .HasColumnType("smallmoney")
                .HasColumnName("VATRate");
            entity.Property(e => e.Xstot1)
                .HasColumnType("money")
                .HasColumnName("XSTOT1");
            entity.Property(e => e.Xstot2)
                .HasColumnType("money")
                .HasColumnName("XSTOT2");
            entity.Property(e => e.Xstot3)
                .HasColumnType("money")
                .HasColumnName("XSTOT3");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Invoice_CurrencyID");

            entity.HasOne(d => d.CustomerAccountNavigation).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.CustomerAccount)
                .HasConstraintName("FK_Invoice_Customer");
        });

        modelBuilder.Entity<InvoiceLine>(entity =>
        {
            entity.HasKey(e => e.InvoiceLineId).IsClustered(false);

            entity.ToTable("InvoiceLine");

            entity.HasIndex(e => e.Invoice, "IDX_InvoiceLine_Invoice").HasFillFactor(80);

            entity.HasIndex(e => e.StockCode, "IDX_InvoiceLine_StockCode").HasFillFactor(80);

            entity.Property(e => e.InvoiceLineId).HasColumnName("InvoiceLineID");
            entity.Property(e => e.CostValue).HasColumnType("money");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Invoice)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.SalesValue).HasColumnType("money");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.StockReturnId).HasColumnName("StockReturnID");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.Vat).HasColumnName("VAT");

            entity.HasOne(d => d.InvoiceNavigation).WithMany(p => p.InvoiceLines)
                .HasForeignKey(d => d.Invoice)
                .HasConstraintName("FK_InvoiceLine_Invoice");
        });

        modelBuilder.Entity<InvoicePreference>(entity =>
        {
            entity.ToTable("InvoicePreference");

            entity.HasIndex(e => e.CustomerAccount, "IX_InvoicePreference_CustomerAccount").HasFillFactor(80);

            entity.HasIndex(e => new { e.CustomerAccount, e.EmailType }, "UQ_InvoicePreference_CustomerAccount_EmailType")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.InvoicePreferenceId).HasColumnName("InvoicePreferenceID");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmailType)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("Language");

            entity.Property(e => e.RecordId).HasColumnName("Record_ID");
            entity.Property(e => e.IsRtl)
                .HasDefaultValue(false)
                .HasColumnName("isRTL");
            entity.Property(e => e.IsSupported)
                .HasDefaultValue(false)
                .HasColumnName("isSupported");
            entity.Property(e => e.LangStringId).HasColumnName("LangStringID");
        });

        modelBuilder.Entity<LoginHistory>(entity =>
        {
            entity.ToTable("LoginHistory");

            entity.Property(e => e.LoginHistoryId).HasColumnName("LoginHistoryID");
            entity.Property(e => e.AppName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LoginDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UserHostAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.WebAccountId).HasColumnName("WebAccountID");
        });

        modelBuilder.Entity<LowStockAlert>(entity =>
        {
            entity.ToTable("LowStockAlert");

            entity.Property(e => e.LowStockAlertId).HasColumnName("LowStockAlertID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LowStockAlertItem>(entity =>
        {
            entity.ToTable("LowStockAlertItem");

            entity.Property(e => e.LowStockAlertItemId).HasColumnName("LowStockAlertItemID");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.LowStockAlertId).HasColumnName("LowStockAlertID");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MailMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MailMessages");

            entity.ToTable("MailMessage");

            entity.HasIndex(e => e.Status, "IX_MailMessage_Status").HasFillFactor(80);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AzureStorageAttachments).IsUnicode(false);
            entity.Property(e => e.FromEmail).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(32);
            entity.Property(e => e.Subject).HasMaxLength(200);
            entity.Property(e => e.UtcInsertedOn).HasColumnType("datetime");
            entity.Property(e => e.UtcUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.ToTable("Material");

            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.StringId).HasColumnName("String_ID");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.Originator, e.OriginatorUnitId }).IsClustered(false);

            entity.ToTable("Order");

            entity.HasIndex(e => new { e.Originator, e.Status, e.OrderDate }, "IDX_OrderLine_Order_Originator_Status_OrderDate").HasFillFactor(80);

            entity.HasIndex(e => e.CustomerAccount, "IDX_Order_CustomerAccount").HasFillFactor(80);

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OriginatorUnitId).HasColumnName("OriginatorUnitID");
            entity.Property(e => e.AckPrt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACK_PRT");
            entity.Property(e => e.Acstat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACStat");
            entity.Property(e => e.CcorderPayment).HasColumnName("CCOrderPayment");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConsignmentNumber)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerBranchId).HasColumnName("CustomerBranchID");
            entity.Property(e => e.CustomerReference)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CustomerServiceInformation)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryAddressId).HasColumnName("DeliveryAddressID");
            entity.Property(e => e.DeliveryAsap).HasColumnName("DeliveryASAP");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryWeekOf).HasColumnType("smalldatetime");
            entity.Property(e => e.DeliveryWhen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExchangeRate)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(7, 2)");
            entity.Property(e => e.InvoiceAddressId).HasColumnName("InvoiceAddressID");
            entity.Property(e => e.IsApproved).HasDefaultValue(true);
            entity.Property(e => e.IsNew).HasDefaultValue(true);
            entity.Property(e => e.LockSource)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LockedOn).HasColumnType("datetime");
            entity.Property(e => e.OrderComments)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");
            entity.Property(e => e.OrderType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.OrderValue).HasColumnType("money");
            entity.Property(e => e.OrderedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OverrideVatrate)
                .HasColumnType("money")
                .HasColumnName("OverrideVATRate");
            entity.Property(e => e.PackedDate).HasColumnType("datetime");
            entity.Property(e => e.PackingNotePrintedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PickedDate).HasColumnType("datetime");
            entity.Property(e => e.PnWh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PN_WH");
            entity.Property(e => e.ReceivedById).HasColumnName("ReceivedByID");
            entity.Property(e => e.ReserveLevel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("NONE");
            entity.Property(e => e.RexLondonSyncNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SentToPackingNoteScreenDate).HasColumnType("datetime");
            entity.Property(e => e.SentToPackingNoteScreenUserId).HasColumnName("SentToPackingNoteScreenUserID");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasDefaultValue("Active");
            entity.Property(e => e.Terms)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TheirReference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.ValueToSupply).HasColumnType("money");
            entity.Property(e => e.WarehouseCompanyId).HasColumnName("WarehouseCompanyID");
        });

        modelBuilder.Entity<OrderChangeLog>(entity =>
        {
            entity.ToTable("OrderChangeLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChangedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderOriginatorUnitId).HasColumnName("OrderOriginatorUnitID");
            entity.Property(e => e.OrderStatus).IsUnicode(false);
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<OrderForInvoice>(entity =>
        {
            entity.ToTable("OrderForInvoice");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Eechidden).HasColumnName("EECHidden");
            entity.Property(e => e.Invoice).HasMaxLength(7);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderOriginatorUnitId).HasColumnName("OrderOriginatorUnitID");
            entity.Property(e => e.PayerName).HasMaxLength(256);
            entity.Property(e => e.ShowOnline).HasDefaultValue(true);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.Vatrate)
                .HasColumnType("smallmoney")
                .HasColumnName("VATRate");
        });

        modelBuilder.Entity<OrderLine>(entity =>
        {
            entity.HasKey(e => new { e.OrderLineId, e.Originator, e.OriginatorUnitId }).IsClustered(false);

            entity.ToTable("OrderLine");

            entity.HasIndex(e => e.IsInvoiced, "IDX_OrderLine_IsInvoiced").HasFillFactor(80);

            entity.HasIndex(e => new { e.OrderId, e.OrderOriginator, e.OrderOriginatorUnitId, e.IsInvoiced }, "IDX_OrderLine_KeyAndIsInvoiced").HasFillFactor(80);

            entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");
            entity.Property(e => e.OriginatorUnitId).HasColumnName("OriginatorUnitID");
            entity.Property(e => e.Binlocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BINLocation");
            entity.Property(e => e.Bord).HasColumnName("BORD");
            entity.Property(e => e.Boxes).IsUnicode(false);
            entity.Property(e => e.Cos)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("COS");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Foc).HasColumnName("FOC");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderOriginatorUnitId).HasColumnName("OrderOriginatorUnitID");
            entity.Property(e => e.Pnprint).HasColumnName("PNPRINT");
            entity.Property(e => e.Price).HasColumnType("smallmoney");
            entity.Property(e => e.ProdType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROD_TYPE");
            entity.Property(e => e.Qts).HasColumnName("QTS");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.StockReturnId).HasColumnName("StockReturnID");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.Unit)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Vat).HasColumnName("VAT");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderLines)
                .HasForeignKey(d => new { d.OrderId, d.OrderOriginator, d.OrderOriginatorUnitId })
                .HasConstraintName("FK_OrderLine_Order");
        });

        modelBuilder.Entity<OrderLineForInvoice>(entity =>
        {
            entity.ToTable("OrderLineForInvoice");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OrderForInvoiceId).HasColumnName("OrderForInvoiceID");
            entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");
            entity.Property(e => e.OriginatorUnitId).HasColumnName("OriginatorUnitID");
        });

        modelBuilder.Entity<OrderLineImported>(entity =>
        {
            entity.HasKey(e => new { e.OrderLineId, e.Originator, e.OriginatorUnitId, e.ImportedOrderLineId });

            entity.ToTable("OrderLineImported");

            entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");
            entity.Property(e => e.OriginatorUnitId).HasColumnName("OriginatorUnitID");
            entity.Property(e => e.ImportedOrderLineId).HasColumnName("ImportedOrderLineID");
        });

        modelBuilder.Entity<OrderReceivedBy>(entity =>
        {
            entity.ToTable("OrderReceivedBy");

            entity.Property(e => e.OrderReceivedById).HasColumnName("OrderReceivedByID");
            entity.Property(e => e.OrderReceivedBy1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OrderReceivedBy");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
            entity.Property(e => e.Visable).HasDefaultValue(true);
        });

        modelBuilder.Entity<OrderTransport>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.OrderOriginator, e.OrderOriginatorUnitId, e.PurchaseOrderId });

            entity.ToTable("OrderTransport");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderOriginatorUnitId).HasColumnName("OrderOriginatorUnitID");
            entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrderID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ParcelForceBatch>(entity =>
        {
            entity.ToTable("ParcelForceBatch");

            entity.HasIndex(e => new { e.BatchNumber, e.CollectionDate }, "UNQ_ParcelForceBatch_BatchNumber_CollectionDate")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.ParcelForceBatchId).HasColumnName("ParcelForceBatchID");
            entity.Property(e => e.BatchNumber)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CollectionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ParcelForceOrder>(entity =>
        {
            entity.HasKey(e => e.ImportedOrderId);

            entity.ToTable("ParcelForceOrder");

            entity.Property(e => e.ImportedOrderId)
                .ValueGeneratedNever()
                .HasColumnName("ImportedOrderID");
            entity.Property(e => e.AccountCode)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.CollectionId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CollectionID");
            entity.Property(e => e.ConsignmentNumber)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.ContractNumber)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.IsApi).HasColumnName("IsAPI");
            entity.Property(e => e.ParcelForceBatchId).HasColumnName("ParcelForceBatchID");
            entity.Property(e => e.SenderReference)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ServiceCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ShippingDate).HasColumnType("datetime");
            entity.Property(e => e.WeekendHandlingCode)
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.HasOne(d => d.ImportedOrder).WithOne(p => p.ParcelForceOrder)
                .HasForeignKey<ParcelForceOrder>(d => d.ImportedOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParcelForceOrder_ImportedOrderID");

            entity.HasOne(d => d.ParcelForceBatch).WithMany(p => p.ParcelForceOrders)
                .HasForeignKey(d => d.ParcelForceBatchId)
                .HasConstraintName("FK_ParcelForceBatch_ParcelForceBatchID");
        });

        modelBuilder.Entity<ParcelForceParcel>(entity =>
        {
            entity.ToTable("ParcelForceParcel");

            entity.Property(e => e.ParcelForceParcelId).HasColumnName("ParcelForceParcelID");
            entity.Property(e => e.ImportedOrderId).HasColumnName("ImportedOrderID");
            entity.Property(e => e.ParcelNumber)
                .HasMaxLength(13)
                .IsUnicode(false);

            entity.HasOne(d => d.ImportedOrder).WithMany(p => p.ParcelForceParcels)
                .HasForeignKey(d => d.ImportedOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParcelForceParcel_ImportedOrderID");
        });

        modelBuilder.Entity<PendingRegistration>(entity =>
        {
            entity.HasKey(e => e.CustomerAccount);

            entity.ToTable("PendingRegistration");

            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmailId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RegCode)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");

            entity.HasOne(d => d.CustomerAccountNavigation).WithOne(p => p.PendingRegistration)
                .HasForeignKey<PendingRegistration>(d => d.CustomerAccount)
                .HasConstraintName("FK_PendingRegistration_Customer");
        });

        modelBuilder.Entity<PostageGroup>(entity =>
        {
            entity.ToTable("PostageGroup");

            entity.Property(e => e.PostageGroupId).HasColumnName("PostageGroupID");
            entity.Property(e => e.AdditionalCarriage).HasColumnType("money");
            entity.Property(e => e.Carriage).HasColumnType("money");
            entity.Property(e => e.CarriagePercent).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.EndAmount).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.PostageGroupType)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.StartAmount).HasColumnType("money");

            entity.HasMany(d => d.Countries).WithMany(p => p.PostageGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "PostageGroupCountry",
                    r => r.HasOne<Country>().WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PostageGroupCountry_CountryID"),
                    l => l.HasOne<PostageGroup>().WithMany()
                        .HasForeignKey("PostageGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PostageGroupCountry_PostageGroupID"),
                    j =>
                    {
                        j.HasKey("PostageGroupId", "CountryId");
                        j.ToTable("PostageGroupCountry");
                        j.IndexerProperty<int>("PostageGroupId").HasColumnName("PostageGroupID");
                        j.IndexerProperty<int>("CountryId").HasColumnName("CountryID");
                    });
        });

        modelBuilder.Entity<PostageGroupPostcode>(entity =>
        {
            entity.ToTable("PostageGroupPostcode");

            entity.Property(e => e.PostageGroupPostcodeId).HasColumnName("PostageGroupPostcodeID");
            entity.Property(e => e.PostageGroupId).HasColumnName("PostageGroupID");
            entity.Property(e => e.PostcodeRange)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.PostageGroup).WithMany(p => p.PostageGroupPostcodes)
                .HasForeignKey(d => d.PostageGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostageGroupPostcode_PostageGroupID");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.ToTable("PurchaseOrder");

            entity.Property(e => e.Address1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address4)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Contact)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DeliveryAddress1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Delivery_Address1");
            entity.Property(e => e.DeliveryAddress2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Delivery_Address2");
            entity.Property(e => e.DeliveryAddress3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Delivery_Address3");
            entity.Property(e => e.DeliveryAddress4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Delivery_Address4");
            entity.Property(e => e.DeliveryName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Delivery_Name");
            entity.Property(e => e.DispatchedBy).HasColumnType("smalldatetime");
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.IsInDevelopment).HasDefaultValue(true);
            entity.Property(e => e.LastUpdated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.OrderValue).HasColumnType("money");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TransportOrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TransportOrderID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");

            entity.HasOne(d => d.SupplierCodeNavigation).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.SupplierCode)
                .HasConstraintName("FK_PurchaseOrder_Supplier");
        });

        modelBuilder.Entity<PurchaseOrderBatchNumber>(entity =>
        {
            entity.HasKey(e => new { e.StockCode, e.BatchNumber });

            entity.ToTable("PurchaseOrderBatchNumber");

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.BatchNumber)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PurchaseOrderItem>(entity =>
        {
            entity.ToTable("PurchaseOrderItem");

            entity.HasIndex(e => e.StockCode, "IDX_PurchaseOrderItem_StockCode").HasFillFactor(80);

            entity.Property(e => e.Barcode)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.BatchNumber)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PartCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("smallmoney");
            entity.Property(e => e.StockCategory)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseOrderItems)
                .HasForeignKey(d => d.PurchaseOrderId)
                .HasConstraintName("FK_PurchaseOrderItem_PurchaseOrder");
        });

        modelBuilder.Entity<RemoteCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerAccount);

            entity.ToTable("RemoteCustomer");

            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateAdded).HasColumnType("datetime");
        });

        modelBuilder.Entity<RemoteOrder>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.Originator, e.OriginatorUnitId });

            entity.ToTable("RemoteOrder");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OriginatorUnitId).HasColumnName("OriginatorUnitID");
            entity.Property(e => e.DateAdded).HasColumnType("datetime");
        });

        modelBuilder.Entity<Rimsclient>(entity =>
        {
            entity.HasKey(e => new { e.MachineName, e.Application });

            entity.ToTable("RIMSClient");

            entity.Property(e => e.MachineName).HasMaxLength(256);
            entity.Property(e => e.Application)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.InstalledVersion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RlapiPrinter>(entity =>
        {
            entity.HasKey(e => e.PrinterId);

            entity.ToTable("RlapiPrinter");

            entity.Property(e => e.ComputerName).HasMaxLength(100);
            entity.Property(e => e.PrinterFriendlyName).HasMaxLength(200);
            entity.Property(e => e.PrinterName).HasMaxLength(200);
        });

        modelBuilder.Entity<RlapiPrinterDocument>(entity =>
        {
            entity.ToTable("RlapiPrinterDocument");

            entity.Property(e => e.DateAdded).HasColumnType("datetime");
            entity.Property(e => e.DatePrinted)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DocumentFormat)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DocumentName).HasMaxLength(200);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Rolename);

            entity.HasIndex(e => e.Rolename, "IX_Roles").HasFillFactor(80);

            entity.Property(e => e.Rolename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ApplicationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
        });

        modelBuilder.Entity<RoyalMailBatch>(entity =>
        {
            entity.ToTable("RoyalMailBatch");

            entity.Property(e => e.RoyalMailBatchId).HasColumnName("RoyalMailBatchID");
            entity.Property(e => e.Apiversion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APIVersion");
            entity.Property(e => e.CollectionDate).HasColumnType("datetime");
            entity.Property(e => e.Number).IsUnicode(false);
        });

        modelBuilder.Entity<RoyalMailOrder>(entity =>
        {
            entity.HasKey(e => e.ImportedOrderId);

            entity.ToTable("RoyalMailOrder");

            entity.Property(e => e.ImportedOrderId)
                .ValueGeneratedNever()
                .HasColumnName("ImportedOrderID");
            entity.Property(e => e.RoyalMailBatchId).HasColumnName("RoyalMailBatchID");
            entity.Property(e => e.SafeplaceText).HasMaxLength(30);
            entity.Property(e => e.ServiceCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.ImportedOrder).WithOne(p => p.RoyalMailOrder)
                .HasForeignKey<RoyalMailOrder>(d => d.ImportedOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoyalMailOrder_ImportedOrderID");

            entity.HasOne(d => d.RoyalMailBatch).WithMany(p => p.RoyalMailOrders)
                .HasForeignKey(d => d.RoyalMailBatchId)
                .HasConstraintName("FK_RoyalMailOrder_RoyalMailBatchID");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Name);

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.StockCode);

            entity.ToTable("Stock");

            entity.HasIndex(e => e.Barcode, "IX_Barcode").IsUnique();

            entity.HasIndex(e => e.FscdescriptionId, "IX_Stock_FSCDescriptionID").HasFillFactor(80);

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.AltCommCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Barcode)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.CareinstructionsId).HasColumnName("Careinstructions_Id");
            entity.Property(e => e.CostMultiplier).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.CustomsDescription)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryDateConfirmed).HasColumnType("datetime");
            entity.Property(e => e.DetailedPackagingMaterialsId).HasColumnName("DetailedPackagingMaterialsID");
            entity.Property(e => e.DetailedProductMaterialsId).HasColumnName("DetailedProductMaterialsID");
            entity.Property(e => e.DistributionRelativeScore).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DotcomCatAdded).HasColumnType("datetime");
            entity.Property(e => e.EecCommCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EEC_CommCode");
            entity.Property(e => e.EecUnitMass)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("EEC_UnitMass");
            entity.Property(e => e.ExtendedDescriptionId).HasColumnName("ExtendedDescription_Id");
            entity.Property(e => e.FinalArtworkApproved).HasColumnType("datetime");
            entity.Property(e => e.Fsccertificate)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FSCCertificate");
            entity.Property(e => e.Fscclassification)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FSCClassification");
            entity.Property(e => e.FscdescriptionId).HasColumnName("FSCDescriptionID");
            entity.Property(e => e.HiddenReason)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsDotcomgiftshop).HasDefaultValue(true);
            entity.Property(e => e.LastModified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.MarketValue).HasColumnType("smallmoney");
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.NetCost).HasColumnType("smallmoney");
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.ProductionSampleApproved).HasColumnType("datetime");
            entity.Property(e => e.QuantityBreakPrice).HasColumnType("smallmoney");
            entity.Property(e => e.RemoveFromUkmail).HasColumnName("RemoveFromUKMail");
            entity.Property(e => e.ReorderDeliveryDateConfirmed).HasColumnType("datetime");
            entity.Property(e => e.ReorderPlaced).HasColumnType("datetime");
            entity.Property(e => e.ReorderProductionSamplesApproved).HasColumnType("datetime");
            entity.Property(e => e.ReorderShippingDateConfirmed).HasColumnType("datetime");
            entity.Property(e => e.SalePrice).HasColumnType("smallmoney");
            entity.Property(e => e.Scored).HasColumnType("datetime");
            entity.Property(e => e.ShippingDateConfirmed).HasColumnType("datetime");
            entity.Property(e => e.ShortDescriptionId).HasColumnName("ShortDescription_Id");
            entity.Property(e => e.SterlingCost).HasColumnType("smallmoney");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TemporaryOutOfStockDate).HasColumnType("datetime");
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TotalRelativeScore)
                .HasComputedColumnSql("(round(([ValueRelativeScore]*(0.4)+[UnitsRelativeScore]*(0.3))+[DistributionRelativeScore]*(0.3),(2)))", false)
                .HasColumnType("numeric(9, 3)");
            entity.Property(e => e.UnitsRelativeScore).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.UseSecondaryGtnforPurchaseOrder).HasColumnName("UseSecondaryGTNForPurchaseOrder");
            entity.Property(e => e.ValueRelativeScore).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.XfsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("xfs_SynchronizationKeyID");

            entity.HasOne(d => d.Fscdescription).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.FscdescriptionId)
                .HasConstraintName("FK_Stock_FSCDescriptionID");

            entity.HasMany(d => d.AttributeValues).WithMany(p => p.StockCodes)
                .UsingEntity<Dictionary<string, object>>(
                    "StockAttributeValue",
                    r => r.HasOne<AttributeValue>().WithMany()
                        .HasForeignKey("AttributeValueId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_StockAttributeValue_AttributeValueID"),
                    l => l.HasOne<Stock>().WithMany()
                        .HasForeignKey("StockCode")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_StockAttributeValue_StockCode"),
                    j =>
                    {
                        j.HasKey("StockCode", "AttributeValueId");
                        j.ToTable("StockAttributeValue");
                        j.IndexerProperty<string>("StockCode")
                            .HasMaxLength(16)
                            .IsUnicode(false);
                        j.IndexerProperty<int>("AttributeValueId").HasColumnName("AttributeValueID");
                    });

            entity.HasMany(d => d.Categories).WithMany(p => p.StockCodes)
                .UsingEntity<Dictionary<string, object>>(
                    "StockCategory",
                    r => r.HasOne<Category>().WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_StockkCategory_CategoryID"),
                    l => l.HasOne<Stock>().WithMany()
                        .HasForeignKey("StockCode")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_StockkCategory_StockCode"),
                    j =>
                    {
                        j.HasKey("StockCode", "CategoryId");
                        j.ToTable("StockCategory");
                        j.IndexerProperty<string>("StockCode")
                            .HasMaxLength(16)
                            .IsUnicode(false);
                        j.IndexerProperty<int>("CategoryId").HasColumnName("CategoryID");
                    });
        });

        modelBuilder.Entity<StockAmount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StockAmount");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockCareInstructionsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.CareInstructionsId, e.LanguageId }).HasName("PK_StockCareInstructionsTranslations_1");

            entity.Property(e => e.CareInstructionsId).HasColumnName("CareInstructionsID");
            entity.Property(e => e.StockCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Language).WithMany(p => p.StockCareInstructionsTranslations)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockCareInst_StringMessages");
        });

        modelBuilder.Entity<StockCareSymbol>(entity =>
        {
            entity.HasKey(e => new { e.StockCode, e.CareSymbolCode });

            entity.ToTable("StockCareSymbol");

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CareSymbolCode)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockFullDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StockFullDetail");

            entity.Property(e => e.Barcode)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.CatalogId).HasColumnName("CatalogID");
            entity.Property(e => e.Diameter).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.DiscountPrice).HasColumnType("smallmoney");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.MaterialEnglish).IsUnicode(false);
            entity.Property(e => e.MaterialFrench).IsUnicode(false);
            entity.Property(e => e.MaterialGerman).IsUnicode(false);
            entity.Property(e => e.NextDeliveryDate).HasColumnType("smalldatetime");
            entity.Property(e => e.QuantityBreakPrice).HasColumnType("smallmoney");
            entity.Property(e => e.RestrictUk).HasColumnName("RestrictUK");
            entity.Property(e => e.RetailPrice).HasColumnType("smallmoney");
            entity.Property(e => e.Rrp)
                .HasColumnType("smallmoney")
                .HasColumnName("RRP");
            entity.Property(e => e.SalePrice).HasColumnType("smallmoney");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TemporaryOutOfStockDate).HasColumnType("datetime");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 1)");
        });

        modelBuilder.Entity<StockImage>(entity =>
        {
            entity.ToTable("StockImage", tb => tb.HasTrigger("tr_StockImage_ChangedRows_xfs"));

            entity.HasIndex(e => e.StockCode, "IDX_StockImage_StockCode").HasFillFactor(80);

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImageName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ImageType)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
            entity.Property(e => e.XfsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("xfs_SynchronizationKeyID");
        });

        modelBuilder.Entity<StockLocationSortOrder>(entity =>
        {
            entity.HasKey(e => new { e.Code, e.SubType, e.CompanyId });

            entity.ToTable("StockLocationSortOrder");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SubType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
        });

        modelBuilder.Entity<StockMaterial>(entity =>
        {
            entity.HasKey(e => e.MaterialId);

            entity.ToTable("StockMaterial");

            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.StringId).HasColumnName("String_ID");
        });

        modelBuilder.Entity<StockMaterialDetail>(entity =>
        {
            entity.HasKey(e => new { e.StockCode, e.StockMaterialId });

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.StockMaterialId).HasColumnName("StockMaterialID");

            entity.HasOne(d => d.StockCodeNavigation).WithMany(p => p.StockMaterialDetails)
                .HasForeignKey(d => d.StockCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockMaterialDetails_Stock");

            entity.HasOne(d => d.StockMaterial).WithMany(p => p.StockMaterialDetails)
                .HasForeignKey(d => d.StockMaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockMaterialDetails_Material");
        });

        modelBuilder.Entity<StockMeasurement>(entity =>
        {
            entity.HasKey(e => new { e.StockCode, e.SubType });

            entity.ToTable("StockMeasurement", tb => tb.HasTrigger("tr_StockMeasurement_Amazon"));

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SubType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Diameter).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.ExemptPlasticPackagingWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.GlassPackagingWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.MetalsPackagingWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PaperPackagingWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PlasticPackagingWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.RecycledPlasticPackagingWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.WoodPackagingWeight).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<StockMultiplier>(entity =>
        {
            entity.HasKey(e => e.StockCode);

            entity.ToTable("StockMultiplier");

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockOnNotification>(entity =>
        {
            entity.ToTable("StockOnNotification");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.CustomerAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Stockcode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.CustomerAccountNavigation).WithMany(p => p.StockOnNotifications)
                .HasForeignKey(d => d.CustomerAccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockOnNotification_Customer");

            entity.HasOne(d => d.StockcodeNavigation).WithMany(p => p.StockOnNotifications)
                .HasForeignKey(d => d.Stockcode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockOnNotification_Stock");
        });

        modelBuilder.Entity<StockReceived>(entity =>
        {
            entity.ToTable("StockReceived");

            entity.Property(e => e.StockReceivedId).HasColumnName("StockReceivedID");
            entity.Property(e => e.LastDeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockRequestList>(entity =>
        {
            entity.HasKey(e => e.StockCode).HasName("PK_StockRequestLis");

            entity.ToTable("StockRequestList");

            entity.HasIndex(e => e.Rowguid, "index_573505372")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Barcode)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Binlocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BINLocation");
            entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("rowguid");
            entity.Property(e => e.ShortDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockRequestListItem>(entity =>
        {
            entity.HasKey(e => e.StockCode).HasName("PK_StockRequestList_1");

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockRetailStringLanguage>(entity =>
        {
            entity.HasKey(e => new { e.StringId, e.LanguageId });

            entity.ToTable("StockRetailStringLanguage");

            entity.Property(e => e.StringId).HasColumnName("String_ID");
            entity.Property(e => e.LanguageId).HasColumnName("Language_ID");
            entity.Property(e => e.LastTranslated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Language).WithMany(p => p.StockRetailStringLanguages)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockRetailStringLanguage_StockRetailStringMessage");
        });

        modelBuilder.Entity<StockRetailStringLanguageChangeLog>(entity =>
        {
            entity.ToTable("StockRetailStringLanguageChangeLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LanguageId).HasColumnName("Language_ID");
            entity.Property(e => e.StringId).HasColumnName("String_ID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Language).WithMany(p => p.StockRetailStringLanguageChangeLogs)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockRetailStringLanguageChangeLog_Language_ID");

            entity.HasOne(d => d.User).WithMany(p => p.StockRetailStringLanguageChangeLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockRetailStringLanguageChangeLog_UserID");
        });

        modelBuilder.Entity<StockRetailStringMessage>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("StockRetailStringMessage");

            entity.Property(e => e.RecordId)
                .ValueGeneratedNever()
                .HasColumnName("Record_ID");
            entity.Property(e => e.StringCode)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockRetailWebsite>(entity =>
        {
            entity.HasKey(e => e.StockCode);

            entity.ToTable("StockRetailWebsite", tb =>
                {
                    tb.HasTrigger("tr_StockRetailWebsite_Amazon");
                    tb.HasTrigger("tr_StockRetailWebsite_ChangedRows_xfs");
                });

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.AmazonPrice).HasColumnType("smallmoney");
            entity.Property(e => e.CareInstructionsId).HasColumnName("CareInstructions_Id");
            entity.Property(e => e.DotcomgiftshopUrlId).HasColumnName("DotcomgiftshopUrl_ID");
            entity.Property(e => e.EBayAutoDetermineCategories)
                .HasDefaultValue(true)
                .HasColumnName("eBayAutoDetermineCategories");
            entity.Property(e => e.EBayDescription).HasColumnName("eBayDescription");
            entity.Property(e => e.EBayFreeShipping).HasColumnName("eBayFreeShipping");
            entity.Property(e => e.EBayHidden).HasColumnName("eBayHidden");
            entity.Property(e => e.EBayHiddenReason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("eBayHiddenReason");
            entity.Property(e => e.EBayIgnoreQuantityUpdate).HasColumnName("eBayIgnoreQuantityUpdate");
            entity.Property(e => e.EBayMaxQuantity).HasColumnName("eBayMaxQuantity");
            entity.Property(e => e.EBayPrice)
                .HasColumnType("money")
                .HasColumnName("eBayPrice");
            entity.Property(e => e.EBayPrimaryCategoryId).HasColumnName("eBayPrimaryCategoryID");
            entity.Property(e => e.EBaySecondaryCategoryId).HasColumnName("eBaySecondaryCategoryID");
            entity.Property(e => e.EBayStorePrimaryCategoryId).HasColumnName("eBayStorePrimaryCategoryID");
            entity.Property(e => e.EBayStoreSecondaryCategoryId).HasColumnName("eBayStoreSecondaryCategoryID");
            entity.Property(e => e.EBayTitle)
                .HasMaxLength(65)
                .HasColumnName("eBayTitle");
            entity.Property(e => e.ExtendedDescriptionId).HasColumnName("ExtendedDescription_Id");
            entity.Property(e => e.HiddenReason)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProductImageUrl).HasMaxLength(255);
            entity.Property(e => e.ProductUrl).HasMaxLength(255);
            entity.Property(e => e.RetailPrice).HasColumnType("smallmoney");
            entity.Property(e => e.RetailPriceEur)
                .HasColumnType("money")
                .HasColumnName("RetailPriceEUR");
            entity.Property(e => e.Rrp)
                .HasColumnType("smallmoney")
                .HasColumnName("RRP");
            entity.Property(e => e.ShortDescriptionId).HasColumnName("ShortDescription_Id");
            entity.Property(e => e.StockId).HasColumnName("StockID");
            entity.Property(e => e.SuggestedPrice).HasColumnType("smallmoney");
            entity.Property(e => e.Ukonly).HasColumnName("UKOnly");
            entity.Property(e => e.XfsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("xfs_SynchronizationKeyID");
        });

        modelBuilder.Entity<StockReturn>(entity =>
        {
            entity.ToTable("StockReturn");

            entity.Property(e => e.StockReturnId).HasColumnName("StockReturnID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockSortOrder>(entity =>
        {
            entity.ToTable("StockSortOrder");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockStringLanguage>(entity =>
        {
            entity.HasKey(e => new { e.StringId, e.LanguageId }).HasName("StockStringLanguage_PK");

            entity.ToTable("StockStringLanguage");

            entity.Property(e => e.StringId).HasColumnName("String_ID");
            entity.Property(e => e.LanguageId).HasColumnName("Language_ID");
            entity.Property(e => e.LastTranslated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Language).WithMany(p => p.StockStringLanguages)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockStringLanguage_Language");

            entity.HasOne(d => d.String).WithMany(p => p.StockStringLanguages)
                .HasForeignKey(d => d.StringId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockStringLanguage_StockStringMessage");
        });

        modelBuilder.Entity<StockStringLanguageChangeLog>(entity =>
        {
            entity.ToTable("StockStringLanguageChangeLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LanguageId).HasColumnName("Language_ID");
            entity.Property(e => e.StringId).HasColumnName("String_ID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Language).WithMany(p => p.StockStringLanguageChangeLogs)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockStringLanguageChangeLog_Language_ID");

            entity.HasOne(d => d.User).WithMany(p => p.StockStringLanguageChangeLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockStringLanguageChangeLog_UserID");
        });

        modelBuilder.Entity<StockStringMessage>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("StockStringMessage");

            entity.Property(e => e.RecordId)
                .ValueGeneratedNever()
                .HasColumnName("Record_ID");
            entity.Property(e => e.StringCode)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockTradeWebsite>(entity =>
        {
            entity.HasKey(e => e.StockCode);

            entity.ToTable("StockTradeWebsite");

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.DiscountPrice).HasColumnType("smallmoney");
            entity.Property(e => e.RestrictUk).HasColumnName("RestrictUK");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
        });

        modelBuilder.Entity<StockTranslated>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StockTranslated");

            entity.Property(e => e.DetailedPackagingMaterialsEnglish).HasColumnName("DetailedPackagingMaterials_English");
            entity.Property(e => e.DetailedPackagingMaterialsFrench).HasColumnName("DetailedPackagingMaterials_French");
            entity.Property(e => e.DetailedPackagingMaterialsGerman).HasColumnName("DetailedPackagingMaterials_German");
            entity.Property(e => e.DetailedPackagingMaterialsId).HasColumnName("DetailedPackagingMaterialsID");
            entity.Property(e => e.DetailedPackagingMaterialsSpanish).HasColumnName("DetailedPackagingMaterials_Spanish");
            entity.Property(e => e.DetailedProductMaterialsEnglish).HasColumnName("DetailedProductMaterials_English");
            entity.Property(e => e.DetailedProductMaterialsFrench).HasColumnName("DetailedProductMaterials_French");
            entity.Property(e => e.DetailedProductMaterialsGerman).HasColumnName("DetailedProductMaterials_German");
            entity.Property(e => e.DetailedProductMaterialsId).HasColumnName("DetailedProductMaterialsID");
            entity.Property(e => e.DetailedProductMaterialsSpanish).HasColumnName("DetailedProductMaterials_Spanish");
            entity.Property(e => e.DotcomgiftshopUrlEnglish).HasColumnName("DotcomgiftshopUrl_English");
            entity.Property(e => e.DotcomgiftshopUrlFrench).HasColumnName("DotcomgiftshopUrl_French");
            entity.Property(e => e.DotcomgiftshopUrlGerman).HasColumnName("DotcomgiftshopUrl_German");
            entity.Property(e => e.DotcomgiftshopUrlId).HasColumnName("DotcomgiftshopUrlID");
            entity.Property(e => e.DotcomgiftshopUrlSpanish).HasColumnName("DotcomgiftshopUrl_Spanish");
            entity.Property(e => e.RetailExtendedDescriptionEnglish).HasColumnName("RetailExtendedDescription_English");
            entity.Property(e => e.RetailExtendedDescriptionFrench).HasColumnName("RetailExtendedDescription_French");
            entity.Property(e => e.RetailExtendedDescriptionGerman).HasColumnName("RetailExtendedDescription_German");
            entity.Property(e => e.RetailExtendedDescriptionId).HasColumnName("RetailExtendedDescriptionID");
            entity.Property(e => e.RetailExtendedDescriptionSpanish).HasColumnName("RetailExtendedDescription_Spanish");
            entity.Property(e => e.RetailShortDescriptionEnglish).HasColumnName("RetailShortDescription_English");
            entity.Property(e => e.RetailShortDescriptionFrench).HasColumnName("RetailShortDescription_French");
            entity.Property(e => e.RetailShortDescriptionGerman).HasColumnName("RetailShortDescription_German");
            entity.Property(e => e.RetailShortDescriptionId).HasColumnName("RetailShortDescriptionID");
            entity.Property(e => e.RetailShortDescriptionSpanish).HasColumnName("RetailShortDescription_Spanish");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.TradeExtendedDescriptionEnglish).HasColumnName("TradeExtendedDescription_English");
            entity.Property(e => e.TradeExtendedDescriptionFrench).HasColumnName("TradeExtendedDescription_French");
            entity.Property(e => e.TradeExtendedDescriptionGerman).HasColumnName("TradeExtendedDescription_German");
            entity.Property(e => e.TradeExtendedDescriptionId).HasColumnName("TradeExtendedDescriptionID");
            entity.Property(e => e.TradeExtendedDescriptionSpanish).HasColumnName("TradeExtendedDescription_Spanish");
            entity.Property(e => e.TradeShortDescriptionEnglish).HasColumnName("TradeShortDescription_English");
            entity.Property(e => e.TradeShortDescriptionFrench).HasColumnName("TradeShortDescription_French");
            entity.Property(e => e.TradeShortDescriptionGerman).HasColumnName("TradeShortDescription_German");
            entity.Property(e => e.TradeShortDescriptionId).HasColumnName("TradeShortDescriptionID");
            entity.Property(e => e.TradeShortDescriptionSpanish).HasColumnName("TradeShortDescription_Spanish");
        });

        modelBuilder.Entity<StockView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StockView");

            entity.Property(e => e.AltCommCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AmazonPrice).HasColumnType("smallmoney");
            entity.Property(e => e.Barcode)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Binlocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BINLocation");
            entity.Property(e => e.CareInstructionsId).HasColumnName("CareInstructions_ID");
            entity.Property(e => e.CartonAdjustedDiameter)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_Diameter");
            entity.Property(e => e.CartonAdjustedExemptPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_ExemptPlasticPackagingWeight");
            entity.Property(e => e.CartonAdjustedGlassPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_GlassPackagingWeight");
            entity.Property(e => e.CartonAdjustedHeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_Height");
            entity.Property(e => e.CartonAdjustedLength)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_Length");
            entity.Property(e => e.CartonAdjustedMetalsPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_MetalsPackagingWeight");
            entity.Property(e => e.CartonAdjustedPaperPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_PaperPackagingWeight");
            entity.Property(e => e.CartonAdjustedPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_PlasticPackagingWeight");
            entity.Property(e => e.CartonAdjustedRecycledPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_RecycledPlasticPackagingWeight");
            entity.Property(e => e.CartonAdjustedStockAmount).HasColumnName("CartonAdjusted_StockAmount");
            entity.Property(e => e.CartonAdjustedWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_Weight");
            entity.Property(e => e.CartonAdjustedWidth)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_Width");
            entity.Property(e => e.CartonAdjustedWoodPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("CartonAdjusted_WoodPackagingWeight");
            entity.Property(e => e.CartonDiameter)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_Diameter");
            entity.Property(e => e.CartonExemptPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_ExemptPlasticPackagingWeight");
            entity.Property(e => e.CartonGlassPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_GlassPackagingWeight");
            entity.Property(e => e.CartonHeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_Height");
            entity.Property(e => e.CartonLength)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_Length");
            entity.Property(e => e.CartonMetalsPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_MetalsPackagingWeight");
            entity.Property(e => e.CartonPaperPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_PaperPackagingWeight");
            entity.Property(e => e.CartonPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_PlasticPackagingWeight");
            entity.Property(e => e.CartonRecycledPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_RecycledPlasticPackagingWeight");
            entity.Property(e => e.CartonStockAmount).HasColumnName("Carton_StockAmount");
            entity.Property(e => e.CartonWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_Weight");
            entity.Property(e => e.CartonWidth)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_Width");
            entity.Property(e => e.CartonWoodPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Carton_WoodPackagingWeight");
            entity.Property(e => e.CashAndCarryLocation)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CashAndCarryLocationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CostMultiplier).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CustomsDescription)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryDateConfirmed).HasColumnType("datetime");
            entity.Property(e => e.DetailedPackagingMaterialsId).HasColumnName("DetailedPackagingMaterialsID");
            entity.Property(e => e.DetailedProductMaterialsId).HasColumnName("DetailedProductMaterialsID");
            entity.Property(e => e.DiscountPrice).HasColumnType("smallmoney");
            entity.Property(e => e.DistributionRelativeScore).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DotcomCatAdded).HasColumnType("datetime");
            entity.Property(e => e.DotcomgiftshopUrlId).HasColumnName("DotcomgiftshopUrl_ID");
            entity.Property(e => e.EBayAutoDetermineCategories).HasColumnName("eBayAutoDetermineCategories");
            entity.Property(e => e.EBayDescription).HasColumnName("eBayDescription");
            entity.Property(e => e.EBayFreeShipping).HasColumnName("eBayFreeShipping");
            entity.Property(e => e.EBayHidden).HasColumnName("eBayHidden");
            entity.Property(e => e.EBayHiddenReason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("eBayHiddenReason");
            entity.Property(e => e.EBayIgnoreQuantityUpdate).HasColumnName("eBayIgnoreQuantityUpdate");
            entity.Property(e => e.EBayMaxQuantity).HasColumnName("eBayMaxQuantity");
            entity.Property(e => e.EBayPrice)
                .HasColumnType("money")
                .HasColumnName("eBayPrice");
            entity.Property(e => e.EBayPrimaryCategoryId).HasColumnName("eBayPrimaryCategoryID");
            entity.Property(e => e.EBaySecondaryCategoryId).HasColumnName("eBaySecondaryCategoryID");
            entity.Property(e => e.EBayStorePrimaryCategoryId).HasColumnName("eBayStorePrimaryCategoryID");
            entity.Property(e => e.EBayStoreSecondaryCategoryId).HasColumnName("eBayStoreSecondaryCategoryID");
            entity.Property(e => e.EBayTitle)
                .HasMaxLength(65)
                .HasColumnName("eBayTitle");
            entity.Property(e => e.EecCommCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EEC_CommCode");
            entity.Property(e => e.EecUnitMass)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("EEC_UnitMass");
            entity.Property(e => e.EuAllocatedStock).HasColumnName("EU_AllocatedStock");
            entity.Property(e => e.EuBackorderStock).HasColumnName("EU_BackorderStock");
            entity.Property(e => e.EuBinlocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EU_BINLocation");
            entity.Property(e => e.EuLastDeliveryDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("EU_LastDeliveryDate");
            entity.Property(e => e.EuLastDeliveryStockAmount).HasColumnName("EU_LastDeliveryStockAmount");
            entity.Property(e => e.EuLastSaleDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("EU_LastSaleDate");
            entity.Property(e => e.EuLowStockAlert).HasColumnName("EU_LowStockAlert");
            entity.Property(e => e.EuReservedStock).HasColumnName("EU_ReservedStock");
            entity.Property(e => e.EuRetailLocation)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("EU_RetailLocation");
            entity.Property(e => e.EuRetailLocationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EU_RetailLocationType");
            entity.Property(e => e.EuSupplierCode2)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("EU_SupplierCode2");
            entity.Property(e => e.EuSupplierFirstDeliveryDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("EU_Supplier_FirstDeliveryDate");
            entity.Property(e => e.EuSupplierId).HasColumnName("EU_SupplierID");
            entity.Property(e => e.EuSupplierLastPurchaseDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("EU_Supplier_LastPurchaseDate");
            entity.Property(e => e.EuSupplierLastReceivedStock)
                .HasColumnType("smalldatetime")
                .HasColumnName("EU_Supplier_LastReceivedStock");
            entity.Property(e => e.EuSupplierLeadTime).HasColumnName("EU_Supplier_LeadTime");
            entity.Property(e => e.EuSupplierNextDeliveryDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("EU_Supplier_NextDeliveryDate");
            entity.Property(e => e.EuTimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("EU_TimeStampID");
            entity.Property(e => e.EuWarehouseStock).HasColumnName("EU_WarehouseStock");
            entity.Property(e => e.EuWholesaleLocation)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("EU_WholesaleLocation");
            entity.Property(e => e.EuWholesaleLocationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EU_WholesaleLocationType");
            entity.Property(e => e.ExtendedDescriptionId).HasColumnName("ExtendedDescription_ID");
            entity.Property(e => e.FinalArtworkApproved).HasColumnType("datetime");
            entity.Property(e => e.Fsccertificate)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FSCCertificate");
            entity.Property(e => e.Fscclassification)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FSCClassification");
            entity.Property(e => e.FscdescriptionId).HasColumnName("FSCDescriptionID");
            entity.Property(e => e.HiddenReason)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.InnerAdjustedDiameter)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_Diameter");
            entity.Property(e => e.InnerAdjustedExemptPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_ExemptPlasticPackagingWeight");
            entity.Property(e => e.InnerAdjustedGlassPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_GlassPackagingWeight");
            entity.Property(e => e.InnerAdjustedHeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_Height");
            entity.Property(e => e.InnerAdjustedLength)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_Length");
            entity.Property(e => e.InnerAdjustedMetalsPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_MetalsPackagingWeight");
            entity.Property(e => e.InnerAdjustedPaperPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_PaperPackagingWeight");
            entity.Property(e => e.InnerAdjustedPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_PlasticPackagingWeight");
            entity.Property(e => e.InnerAdjustedRecycledPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_RecycledPlasticPackagingWeight");
            entity.Property(e => e.InnerAdjustedStockAmount).HasColumnName("InnerAdjusted_StockAmount");
            entity.Property(e => e.InnerAdjustedWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_Weight");
            entity.Property(e => e.InnerAdjustedWidth)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_Width");
            entity.Property(e => e.InnerAdjustedWoodPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("InnerAdjusted_WoodPackagingWeight");
            entity.Property(e => e.InnerDiameter)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_Diameter");
            entity.Property(e => e.InnerExemptPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_ExemptPlasticPackagingWeight");
            entity.Property(e => e.InnerGlassPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_GlassPackagingWeight");
            entity.Property(e => e.InnerHeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_Height");
            entity.Property(e => e.InnerLength)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_Length");
            entity.Property(e => e.InnerMetalsPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_MetalsPackagingWeight");
            entity.Property(e => e.InnerPaperPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_PaperPackagingWeight");
            entity.Property(e => e.InnerPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_PlasticPackagingWeight");
            entity.Property(e => e.InnerRecycledPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_RecycledPlasticPackagingWeight");
            entity.Property(e => e.InnerStockAmount).HasColumnName("Inner_StockAmount");
            entity.Property(e => e.InnerWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_Weight");
            entity.Property(e => e.InnerWidth)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_Width");
            entity.Property(e => e.InnerWoodPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Inner_WoodPackagingWeight");
            entity.Property(e => e.LastDeliveryDate).HasColumnType("smalldatetime");
            entity.Property(e => e.LastModified).HasColumnType("smalldatetime");
            entity.Property(e => e.LastSaleDate).HasColumnType("smalldatetime");
            entity.Property(e => e.MarketValue).HasColumnType("smallmoney");
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.NetCost).HasColumnType("smallmoney");
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.ProductDiameter)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_Diameter");
            entity.Property(e => e.ProductExemptPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_ExemptPlasticPackagingWeight");
            entity.Property(e => e.ProductGlassPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_GlassPackagingWeight");
            entity.Property(e => e.ProductHeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_Height");
            entity.Property(e => e.ProductLength)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_Length");
            entity.Property(e => e.ProductMetalsPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_MetalsPackagingWeight");
            entity.Property(e => e.ProductPaperPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_PaperPackagingWeight");
            entity.Property(e => e.ProductPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_PlasticPackagingWeight");
            entity.Property(e => e.ProductRecycledPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_RecycledPlasticPackagingWeight");
            entity.Property(e => e.ProductStockAmount).HasColumnName("Product_StockAmount");
            entity.Property(e => e.ProductWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_Weight");
            entity.Property(e => e.ProductWidth)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_Width");
            entity.Property(e => e.ProductWoodPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Product_WoodPackagingWeight");
            entity.Property(e => e.ProductionSampleApproved).HasColumnType("datetime");
            entity.Property(e => e.QuantityBreakPrice).HasColumnType("smallmoney");
            entity.Property(e => e.RemoveFromUkmail).HasColumnName("RemoveFromUKMail");
            entity.Property(e => e.ReorderDeliveryDateConfirmed).HasColumnType("datetime");
            entity.Property(e => e.ReorderPlaced).HasColumnType("datetime");
            entity.Property(e => e.ReorderProductionSamplesApproved).HasColumnType("datetime");
            entity.Property(e => e.ReorderShippingDateConfirmed).HasColumnType("datetime");
            entity.Property(e => e.RestrictUk).HasColumnName("RestrictUK");
            entity.Property(e => e.RetailExtendedDescriptionId).HasColumnName("RetailExtendedDescriptionID");
            entity.Property(e => e.RetailHiddenReason)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RetailLocation)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.RetailLocationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RetailPrice).HasColumnType("smallmoney");
            entity.Property(e => e.RetailPriceEur)
                .HasColumnType("money")
                .HasColumnName("RetailPriceEUR");
            entity.Property(e => e.RetailShortDescriptionId).HasColumnName("RetailShortDescriptionID");
            entity.Property(e => e.Rrp)
                .HasColumnType("smallmoney")
                .HasColumnName("RRP");
            entity.Property(e => e.SalePrice).HasColumnType("smallmoney");
            entity.Property(e => e.ShippingDateConfirmed).HasColumnType("datetime");
            entity.Property(e => e.ShippingDiameter)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_Diameter");
            entity.Property(e => e.ShippingExemptPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_ExemptPlasticPackagingWeight");
            entity.Property(e => e.ShippingGlassPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_GlassPackagingWeight");
            entity.Property(e => e.ShippingHeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_Height");
            entity.Property(e => e.ShippingLength)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_Length");
            entity.Property(e => e.ShippingMetalsPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_MetalsPackagingWeight");
            entity.Property(e => e.ShippingPaperPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_PaperPackagingWeight");
            entity.Property(e => e.ShippingPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_PlasticPackagingWeight");
            entity.Property(e => e.ShippingRecycledPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_RecycledPlasticPackagingWeight");
            entity.Property(e => e.ShippingStockAmount).HasColumnName("Shipping_StockAmount");
            entity.Property(e => e.ShippingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_Weight");
            entity.Property(e => e.ShippingWidth)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_Width");
            entity.Property(e => e.ShippingWoodPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Shipping_WoodPackagingWeight");
            entity.Property(e => e.ShortDescriptionId).HasColumnName("ShortDescription_ID");
            entity.Property(e => e.SterlingCost).HasColumnType("smallmoney");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SubAdjustedDiameter)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_Diameter");
            entity.Property(e => e.SubAdjustedExemptPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_ExemptPlasticPackagingWeight");
            entity.Property(e => e.SubAdjustedGlassPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_GlassPackagingWeight");
            entity.Property(e => e.SubAdjustedHeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_Height");
            entity.Property(e => e.SubAdjustedLength)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_Length");
            entity.Property(e => e.SubAdjustedMetalsPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_MetalsPackagingWeight");
            entity.Property(e => e.SubAdjustedPaperPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_PaperPackagingWeight");
            entity.Property(e => e.SubAdjustedPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_PlasticPackagingWeight");
            entity.Property(e => e.SubAdjustedRecycledPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_RecycledPlasticPackagingWeight");
            entity.Property(e => e.SubAdjustedStockAmount).HasColumnName("SubAdjusted_StockAmount");
            entity.Property(e => e.SubAdjustedWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_Weight");
            entity.Property(e => e.SubAdjustedWidth)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_Width");
            entity.Property(e => e.SubAdjustedWoodPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SubAdjusted_WoodPackagingWeight");
            entity.Property(e => e.SubDiameter)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_Diameter");
            entity.Property(e => e.SubExemptPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_ExemptPlasticPackagingWeight");
            entity.Property(e => e.SubGlassPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_GlassPackagingWeight");
            entity.Property(e => e.SubHeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_Height");
            entity.Property(e => e.SubLength)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_Length");
            entity.Property(e => e.SubMetalsPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_MetalsPackagingWeight");
            entity.Property(e => e.SubPaperPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_PaperPackagingWeight");
            entity.Property(e => e.SubPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_PlasticPackagingWeight");
            entity.Property(e => e.SubRecycledPlasticPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_RecycledPlasticPackagingWeight");
            entity.Property(e => e.SubStockAmount).HasColumnName("Sub_StockAmount");
            entity.Property(e => e.SubWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_Weight");
            entity.Property(e => e.SubWidth)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_Width");
            entity.Property(e => e.SubWoodPackagingWeight)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Sub_WoodPackagingWeight");
            entity.Property(e => e.SuggestedPrice).HasColumnType("smallmoney");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SupplierCode2)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.SupplierFirstDeliveryDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Supplier_FirstDeliveryDate");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.SupplierLastPurchaseDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Supplier_LastPurchaseDate");
            entity.Property(e => e.SupplierLastReceivedStock)
                .HasColumnType("smalldatetime")
                .HasColumnName("Supplier_LastReceivedStock");
            entity.Property(e => e.SupplierLeadTime).HasColumnName("Supplier_LeadTime");
            entity.Property(e => e.SupplierNextDeliveryDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Supplier_NextDeliveryDate");
            entity.Property(e => e.TemporaryOutOfStockDate).HasColumnType("datetime");
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.TotalRelativeScore).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.UkTimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("UK_TimeStampID");
            entity.Property(e => e.Ukonly).HasColumnName("UKOnly");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.UnitsRelativeScore).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.UseSecondaryGtnforPurchaseOrder).HasColumnName("UseSecondaryGTNForPurchaseOrder");
            entity.Property(e => e.ValueRelativeScore).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.XfsSynchronizationKeyId).HasColumnName("xfs_SynchronizationKeyID");
        });

        modelBuilder.Entity<StockWarehouse>(entity =>
        {
            entity.HasKey(e => new { e.StockCode, e.CompanyId });

            entity.ToTable("StockWarehouse", tb =>
                {
                    tb.HasTrigger("tr_StockWarehouse_Amazon");
                    tb.HasTrigger("tr_StockWarehouse_ChangedRows_xfs");
                });

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Binlocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BINLocation");
            entity.Property(e => e.LastDeliveryDate).HasColumnType("smalldatetime");
            entity.Property(e => e.LastSaleDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RetailLocation)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.RetailLocationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SupplierCode2)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.SupplierFirstDeliveryDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Supplier_FirstDeliveryDate");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.SupplierLastPurchaseDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Supplier_LastPurchaseDate");
            entity.Property(e => e.SupplierLastReceivedStock)
                .HasColumnType("smalldatetime")
                .HasColumnName("Supplier_LastReceivedStock");
            entity.Property(e => e.SupplierLeadTime).HasColumnName("Supplier_LeadTime");
            entity.Property(e => e.SupplierNextDeliveryDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Supplier_NextDeliveryDate");
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.WholesaleLocation)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.WholesaleLocationType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<StringLanguage>(entity =>
        {
            entity.HasKey(e => new { e.StringId, e.LanguageId }).HasName("StringLanguage_PK");

            entity.ToTable("StringLanguage");

            entity.Property(e => e.StringId).HasColumnName("String_ID");
            entity.Property(e => e.LanguageId).HasColumnName("Language_ID");
            entity.Property(e => e.TranslatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Language).WithMany(p => p.StringLanguages)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StringLanguage_Language");

            entity.HasOne(d => d.String).WithMany(p => p.StringLanguages)
                .HasForeignKey(d => d.StringId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("StringMessages_StringLanguage_FK1");
        });

        modelBuilder.Entity<StringMessage>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("StringMessages_PK");

            entity.ToTable("StringMessage");

            entity.HasIndex(e => e.StringCode, "IDX_StringCode").HasFillFactor(80);

            entity.Property(e => e.RecordId).HasColumnName("Record_ID");
            entity.Property(e => e.StringCode)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Subscriber>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Subscriber");

            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CountryName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Firstname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HowFound)
                .HasMaxLength(58)
                .IsUnicode(false);
            entity.Property(e => e.Language)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.LastInvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RetailerType).IsUnicode(false);
            entity.Property(e => e.SignupMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierCode);

            entity.ToTable("Supplier");

            entity.Property(e => e.SupplierCode)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.AccountsAddressId).HasColumnName("AccountsAddressID");
            entity.Property(e => e.ChequePayee)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Costmultiplier).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.LastOrderedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TimeStampId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("TimeStampID");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TradingAddressId).HasColumnName("TradingAddressID");
        });

        modelBuilder.Entity<SupplierAddress>(entity =>
        {
            entity.ToTable("SupplierAddress");

            entity.Property(e => e.SupplierAddressId).HasColumnName("SupplierAddressID");
            entity.Property(e => e.Address1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address4)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.Firstname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Telephone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");

            entity.HasOne(d => d.SupplierCodeNavigation).WithMany(p => p.SupplierAddresses)
                .HasForeignKey(d => d.SupplierCode)
                .HasConstraintName("FK_SupplierAddress_Supplier");
        });

        modelBuilder.Entity<SupplierCertificate>(entity =>
        {
            entity.ToTable("SupplierCertificate");

            entity.Property(e => e.SupplierCertificateId).HasColumnName("SupplierCertificateID");
            entity.Property(e => e.FileName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FileNamePrefix)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.UploadedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SupplierCertificateStock>(entity =>
        {
            entity.HasKey(e => new { e.SupplierCertificateId, e.StockCode });

            entity.ToTable("SupplierCertificateStock");

            entity.Property(e => e.SupplierCertificateId).HasColumnName("SupplierCertificateID");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempInvoiceForSync>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temp_Inv__3214EC27DE8D1A73");

            entity.ToTable("Temp_InvoiceForSync");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InvoiceReference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Synced).HasColumnType("datetime");
        });

        modelBuilder.Entity<TempSaleStock>(entity =>
        {
            entity.HasKey(e => e.StockCode).HasName("PK__Temp_Sal__28E08C96CBF1239A");

            entity.ToTable("Temp_SaleStock");

            entity.Property(e => e.StockCode)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice).HasColumnType("smallmoney");
            entity.Property(e => e.Rrp)
                .HasColumnType("smallmoney")
                .HasColumnName("RRP");
        });

        modelBuilder.Entity<TotalOutstanding>(entity =>
        {
            entity.HasKey(e => new { e.Year, e.Month });

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Outstanding).HasColumnType("money");
        });

        modelBuilder.Entity<UkmailBatch>(entity =>
        {
            entity.ToTable("UKMailBatch");

            entity.Property(e => e.UkmailBatchId).HasColumnName("UKMailBatchID");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CollectionJobNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EarliestTime).HasColumnType("datetime");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.LatestTime).HasColumnType("datetime");
            entity.Property(e => e.RequestedCollectionDate).HasColumnType("datetime");
            entity.Property(e => e.SpecialInstructions)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UkmailOrder>(entity =>
        {
            entity.HasKey(e => e.ImportedOrderId);

            entity.ToTable("UKMailOrder");

            entity.Property(e => e.ImportedOrderId)
                .ValueGeneratedNever()
                .HasColumnName("ImportedOrderID");
            entity.Property(e => e.Address1)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.AlternativeRef)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BusinessName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Codamount)
                .HasColumnType("money")
                .HasColumnName("CODAmount");
            entity.Property(e => e.ConfirmationEmail)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ConfirmationTelephone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ConsignmentNumber)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.County)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CustomersRef)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryMessage1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryMessage2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DespatchType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.PostalTown)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Postcode)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.PreDeliveryNotification)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SecureLocation1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SecureLocation2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SpecialInstructions1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SpecialInstructions2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Telephone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UkmailBatchId).HasColumnName("UKMailBatchID");

            entity.HasOne(d => d.ImportedOrder).WithOne(p => p.UkmailOrder)
                .HasForeignKey<UkmailOrder>(d => d.ImportedOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UKMailOrder_ImportedOrderID");

            entity.HasOne(d => d.UkmailBatch).WithMany(p => p.UkmailOrders)
                .HasForeignKey(d => d.UkmailBatchId)
                .HasConstraintName("FK_UKMailOrder_UKMailBatchID");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.ToTable("Unit");

            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
            entity.Property(e => e.Unit1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Unit");
        });

        modelBuilder.Entity<UnpaidOrder>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.Originator, e.OriginatorUnitId });

            entity.ToTable("UnpaidOrder");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OriginatorUnitId).HasColumnName("OriginatorUnitID");

            entity.HasOne(d => d.Order).WithOne(p => p.UnpaidOrder)
                .HasForeignKey<UnpaidOrder>(d => new { d.OrderId, d.Originator, d.OriginatorUnitId })
                .HasConstraintName("FK_UnpaidOrder_Order");
        });

        modelBuilder.Entity<UpdateDotcomgiftshopNow>(entity =>
        {
            entity.ToTable("UpdateDotcomgiftshopNow");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UploadStockImage>(entity =>
        {
            entity.ToTable("UploadStockImage");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ImageName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasMaxLength(32);
            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UpsexcludedPostCode>(entity =>
        {
            entity.ToTable("UPSExcludedPostCode");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.EndRange).HasMaxLength(50);
            entity.Property(e => e.StartRange).HasMaxLength(50);

            entity.HasOne(d => d.Country).WithMany(p => p.UpsexcludedPostCodes)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UPSExcludedPostCode_CountryID");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Pkid);

            entity.Property(e => e.Pkid)
                .ValueGeneratedNever()
                .HasColumnName("PKID");
            entity.Property(e => e.ApplicationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsShowUser)
                .HasDefaultValue(false)
                .HasColumnName("isShowUser");
            entity.Property(e => e.LastLockedOutDate).HasColumnType("smalldatetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PasswordAnswer)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PasswordQuestion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Theme)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("Original");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<UserCompany>(entity =>
        {
            entity.ToTable("UserCompany");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Company).WithMany(p => p.UserCompanies)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserCompany_Company");

            entity.HasOne(d => d.User).WithMany(p => p.UserCompanies)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserCompany_Users");
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("UserSetting");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.UserData).IsUnicode(false);
        });

        modelBuilder.Entity<UsersInRole>(entity =>
        {
            entity.HasKey(e => new { e.Username, e.Rolename });

            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Rolename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
        });

        modelBuilder.Entity<UsersRlapi>(entity =>
        {
            entity.ToTable("UsersRLAPI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientId).HasMaxLength(100);
            entity.Property(e => e.ClientSecret).HasMaxLength(500);
        });

        modelBuilder.Entity<VatexcludedStock>(entity =>
        {
            entity.HasKey(e => new { e.StockCode, e.CompanyId });

            entity.ToTable("VATExcludedStocks");

            entity.Property(e => e.StockCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
        });

        modelBuilder.Entity<VatexclusionInvoice>(entity =>
        {
            entity.HasKey(e => e.Invoice);

            entity.ToTable("VATExclusionInvoice");

            entity.Property(e => e.Invoice)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vathistory>(entity =>
        {
            entity.ToTable("VATHistory");

            entity.Property(e => e.VathistoryId).HasColumnName("VATHistoryID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Vatrate)
                .HasColumnType("money")
                .HasColumnName("VATRate");
        });

        modelBuilder.Entity<WebAccountType>(entity =>
        {
            entity.HasKey(e => e.WebAccountId);

            entity.ToTable("WebAccountType");

            entity.Property(e => e.WebAccountId).HasColumnName("WebAccountID");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TlsSynchronizationKeyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("tls_SynchronizationKeyID");
            entity.Property(e => e.TlsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("tls_VersionID");
        });

        modelBuilder.Entity<XfsChangedRow>(entity =>
        {
            entity.HasKey(e => e.XfsChangedRowsId);

            entity.ToTable("xfs_ChangedRows");

            entity.HasIndex(e => e.XfsSynchronizationKeyId, "NonClusteredIndex-20200719-192314").HasFillFactor(80);

            entity.Property(e => e.XfsChangedRowsId).HasColumnName("xfs_ChangedRowsID");
            entity.Property(e => e.XfsAction)
                .HasMaxLength(50)
                .HasColumnName("xfs_Action");
            entity.Property(e => e.XfsPrimaryKeys)
                .HasMaxLength(2000)
                .HasColumnName("xfs_PrimaryKeys");
            entity.Property(e => e.XfsSynchronizationKeyId).HasColumnName("xfs_SynchronizationKeyID");
            entity.Property(e => e.XfsTableName)
                .HasMaxLength(150)
                .HasColumnName("xfs_TableName");
            entity.Property(e => e.XfsVersionId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("xfs_VersionID");
        });

        modelBuilder.Entity<XmlfeedError>(entity =>
        {
            entity.ToTable("XMLFeedError");

            entity.Property(e => e.XmlfeedErrorId).HasColumnName("XMLFeedErrorID");
            entity.Property(e => e.ErrorDate).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

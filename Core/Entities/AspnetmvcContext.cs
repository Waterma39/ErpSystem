using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ErpSystem.Core.Entities;

public partial class AspnetmvcContext : DbContext
{
    public AspnetmvcContext()
    {
    }

    public AspnetmvcContext(DbContextOptions<AspnetmvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AboutU> AboutUs { get; set; }

    public virtual DbSet<AboutUsDetail> AboutUsDetails { get; set; }

    public virtual DbSet<AddressBook> AddressBooks { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<Calendar> Calendars { get; set; }

    public virtual DbSet<Carousel> Carousels { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Category> Categorys { get; set; }

    public virtual DbSet<City> Citys { get; set; }

    public virtual DbSet<CityArea> CityAreas { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<CloseDate> CloseDates { get; set; }

    public virtual DbSet<CodeBasis> CodeBases { get; set; }

    public virtual DbSet<CodeData> CodeDatas { get; set; }

    public virtual DbSet<Company> Companys { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeAgent> EmployeeAgents { get; set; }

    public virtual DbSet<EmployeeExperience> EmployeeExperiences { get; set; }

    public virtual DbSet<EmployeeSchool> EmployeeSchools { get; set; }

    public virtual DbSet<ExtensionTable> ExtensionTables { get; set; }

    public virtual DbSet<Featured> Featureds { get; set; }

    public virtual DbSet<FormDetail> FormDetails { get; set; }

    public virtual DbSet<FormMaster> FormMasters { get; set; }

    public virtual DbSet<Forum> Forums { get; set; }

    public virtual DbSet<ForumBoard> ForumBoards { get; set; }

    public virtual DbSet<InvDetail> InvDetails { get; set; }

    public virtual DbSet<InvMaster> InvMasters { get; set; }

    public virtual DbSet<Inventory> Inventorys { get; set; }

    public virtual DbSet<InventorysDetail> InventorysDetails { get; set; }

    public virtual DbSet<InventorysType> InventorysTypes { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<MapPosition> MapPositions { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<NewsLetter> NewsLetters { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrdersStatus> OrdersStatuses { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Photo> Photos { get; set; }

    public virtual DbSet<Pricing> Pricings { get; set; }

    public virtual DbSet<PricingDetail> PricingDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductFeatured> ProductFeatureds { get; set; }

    public virtual DbSet<ProductInventory> ProductInventorys { get; set; }

    public virtual DbSet<ProductProperty> ProductPropertys { get; set; }

    public virtual DbSet<ProductStatus> ProductStatuses { get; set; }

    public virtual DbSet<ProductTag> ProductTags { get; set; }

    public virtual DbSet<Program> Programs { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<Property> Propertys { get; set; }

    public virtual DbSet<PropertyName> PropertyNames { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Security> Securitys { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Shipping> Shippings { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<Title> Titles { get; set; }

    public virtual DbSet<TodoList> TodoLists { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vacation> Vacations { get; set; }

    public virtual DbSet<ViCodeAddressBook> ViCodeAddressBooks { get; set; }

    public virtual DbSet<ViCodeBrand> ViCodeBrands { get; set; }

    public virtual DbSet<ViCodeCalendar> ViCodeCalendars { get; set; }

    public virtual DbSet<ViCodeCloseDate> ViCodeCloseDates { get; set; }

    public virtual DbSet<ViCodeColor> ViCodeColors { get; set; }

    public virtual DbSet<ViCodeCompany> ViCodeCompanies { get; set; }

    public virtual DbSet<ViCodeCustomer> ViCodeCustomers { get; set; }

    public virtual DbSet<ViCodeFormStatus> ViCodeFormStatuses { get; set; }

    public virtual DbSet<ViCodeGender> ViCodeGenders { get; set; }

    public virtual DbSet<ViCodeLog> ViCodeLogs { get; set; }

    public virtual DbSet<ViCodeMaterial> ViCodeMaterials { get; set; }

    public virtual DbSet<ViCodeMember> ViCodeMembers { get; set; }

    public virtual DbSet<ViCodeMessage> ViCodeMessages { get; set; }

    public virtual DbSet<ViCodeNews> ViCodeNews { get; set; }

    public virtual DbSet<ViCodeNotification> ViCodeNotifications { get; set; }

    public virtual DbSet<ViCodePhoto> ViCodePhotos { get; set; }

    public virtual DbSet<ViCodeProgram> ViCodePrograms { get; set; }

    public virtual DbSet<ViCodeResignReason> ViCodeResignReasons { get; set; }

    public virtual DbSet<ViCodeSheet> ViCodeSheets { get; set; }

    public virtual DbSet<ViCodeSize> ViCodeSizes { get; set; }

    public virtual DbSet<ViCodeTarget> ViCodeTargets { get; set; }

    public virtual DbSet<ViCodeTax> ViCodeTaxes { get; set; }

    public virtual DbSet<ViCodeUser> ViCodeUsers { get; set; }

    public virtual DbSet<ViCodeVacation> ViCodeVacations { get; set; }

    public virtual DbSet<ViCodeVendor> ViCodeVendors { get; set; }

    public virtual DbSet<ViCompCompany> ViCompCompanies { get; set; }

    public virtual DbSet<ViCompCustomer> ViCompCustomers { get; set; }

    public virtual DbSet<ViCompVendor> ViCompVendors { get; set; }

    public virtual DbSet<ViTodoList> ViTodoLists { get; set; }

    public virtual DbSet<ViUserCustomer> ViUserCustomers { get; set; }

    public virtual DbSet<ViUserMi> ViUserMis { get; set; }

    public virtual DbSet<ViUserOperator> ViUserOperators { get; set; }

    public virtual DbSet<ViUserTarget> ViUserTargets { get; set; }

    public virtual DbSet<ViUserUser> ViUserUsers { get; set; }

    public virtual DbSet<ViUserVendor> ViUserVendors { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    public virtual DbSet<WorkflowDetail> WorkflowDetails { get; set; }

    public virtual DbSet<WorkflowMaster> WorkflowMasters { get; set; }

    public virtual DbSet<WorkflowRole> WorkflowRoles { get; set; }

    public virtual DbSet<WorkflowRoleUser> WorkflowRoleUsers { get; set; }

    public virtual DbSet<WorkflowRoute> WorkflowRoutes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AboutU>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.HeaderName, "IX_AboutUs_name").IsClustered();

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DetailText).HasMaxLength(500);
            entity.Property(e => e.HeaderName).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.TitleName).HasMaxLength(500);
        });

        modelBuilder.Entity<AboutUsDetail>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.SortNo, e.ItemName }, "IX_AboutUsDetails_sort_name").IsClustered();

            entity.Property(e => e.ItemName).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AddressBook>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.UserNo, e.CodeNo }, "IX_AddressBooks_uno_no").IsClustered();

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CompId)
                .HasMaxLength(50)
                .HasColumnName("CompID");
            entity.Property(e => e.CompName).HasMaxLength(250);
            entity.Property(e => e.CompTel).HasMaxLength(50);
            entity.Property(e => e.ContactAddress).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.DeptName).HasMaxLength(50);
            entity.Property(e => e.EngName).HasMaxLength(50);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(50)
                .HasColumnName("FacebookID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.InstagramId)
                .HasMaxLength(50)
                .HasColumnName("InstagramID");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LineId)
                .HasMaxLength(50)
                .HasColumnName("LineID");
            entity.Property(e => e.LinkedInId)
                .HasMaxLength(50)
                .HasColumnName("LinkedInID");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.TitleName).HasMaxLength(50);
            entity.Property(e => e.TwitterId)
                .HasMaxLength(50)
                .HasColumnName("TwitterID");
            entity.Property(e => e.UserNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.AppName, "IX_Applications_name").IsClustered();

            entity.Property(e => e.AdminName).HasMaxLength(50);
            entity.Property(e => e.AppName).HasMaxLength(50);
            entity.Property(e => e.AppVersion).HasMaxLength(50);
            entity.Property(e => e.GoogleMapKey).HasMaxLength(50);
            entity.Property(e => e.LanguageNo).HasMaxLength(50);
            entity.Property(e => e.MailAppPassword).HasMaxLength(50);
            entity.Property(e => e.MailHostUrl).HasMaxLength(250);
            entity.Property(e => e.MailReceiverEmail).HasMaxLength(50);
            entity.Property(e => e.MailReceiverName).HasMaxLength(50);
            entity.Property(e => e.MailSenderEmail).HasMaxLength(50);
            entity.Property(e => e.MailSenderName).HasMaxLength(50);
            entity.Property(e => e.MailUseSsl).HasColumnName("MailUseSSL");
            entity.Property(e => e.PowerBy).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.ShopName).HasMaxLength(50);
            entity.Property(e => e.WebSiteUrl).HasMaxLength(250);
        });

        modelBuilder.Entity<Calendar>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.TargetCode, e.TargetNo, e.StartDate }, "IX_Calendars_code_target_date").IsClustered();

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.ColorName).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndTime).HasMaxLength(50);
            entity.Property(e => e.PlaceAddress).HasMaxLength(250);
            entity.Property(e => e.PlaceName).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.ResourceText).HasMaxLength(500);
            entity.Property(e => e.RoomNo).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasMaxLength(50);
            entity.Property(e => e.SubjectName).HasMaxLength(50);
            entity.Property(e => e.TargetCode).HasMaxLength(50);
            entity.Property(e => e.TargetNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Carousel>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.SortNo, e.HeaderName }, "IX_Carousels_sort_name").IsClustered();

            entity.Property(e => e.HeaderName).HasMaxLength(50);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.MoreUrl).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.LotNo, e.ProdNo }, "IX_Carts_lno_pno").IsClustered();

            entity.Property(e => e.CategoryName).HasMaxLength(250);
            entity.Property(e => e.CategoryNo).HasMaxLength(50);
            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.LotNo).HasMaxLength(50);
            entity.Property(e => e.MemberNo).HasMaxLength(50);
            entity.Property(e => e.ProdName).HasMaxLength(250);
            entity.Property(e => e.ProdNo).HasMaxLength(50);
            entity.Property(e => e.ProdSpec).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.VendorNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable(tb => tb.HasTrigger("tr_Categorys"));

            entity.HasIndex(e => new { e.ParentNo, e.SortNo, e.CategoryNo }, "IX_Categorys_pno_sno_cno").IsClustered();

            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CategoryNo).HasMaxLength(50);
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RouteName).HasMaxLength(500);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.SortNo, e.CityName }, "IX_Citys_sort_name").IsClustered();

            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<CityArea>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.CityName, e.AreaName }, "IX_CityAreas_city_area").IsClustered();

            entity.Property(e => e.AreaName).HasMaxLength(50);
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.SortNo, e.ClientName }, "IX_Clients_sort_name").IsClustered();

            entity.Property(e => e.ClientName).HasMaxLength(50);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
            entity.Property(e => e.WebsiteUrl).HasMaxLength(250);
        });

        modelBuilder.Entity<CloseDate>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.CodeNo, e.StartDate }, "IX_CloseDates_code_start")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<CodeBasis>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.IsAdmin, e.BaseNo }, "IX_CodeBases_admin_no");

            entity.HasIndex(e => e.BaseNo, "IX_CodeBases_no").IsClustered();

            entity.Property(e => e.BaseName).HasMaxLength(50);
            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.DefaultValue).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<CodeData>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.BaseNo, e.ParentNo, e.SortNo, e.CodeNo }, "IX_BaseDatas_no_pno_sort_code").IsClustered();

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.CodeNo, e.CompNo }, "IX_Companys_code_no")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.BossName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CompAddress).HasMaxLength(250);
            entity.Property(e => e.CompFax).HasMaxLength(50);
            entity.Property(e => e.CompId)
                .HasMaxLength(50)
                .HasColumnName("CompID");
            entity.Property(e => e.CompName).HasMaxLength(250);
            entity.Property(e => e.CompNo).HasMaxLength(50);
            entity.Property(e => e.CompTel).HasMaxLength(50);
            entity.Property(e => e.CompUrl).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.EngName).HasMaxLength(250);
            entity.Property(e => e.EngShortName).HasMaxLength(50);
            entity.Property(e => e.FacebookUrl).HasMaxLength(250);
            entity.Property(e => e.InstagramUrl).HasMaxLength(250);
            entity.Property(e => e.Latitude).HasColumnType("decimal(20, 15)");
            entity.Property(e => e.LinkedinUrl).HasMaxLength(250);
            entity.Property(e => e.Longitude).HasColumnType("decimal(20, 15)");
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.SkypeUrl).HasMaxLength(250);
            entity.Property(e => e.TwitterUrl).HasMaxLength(250);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.DeptNo, "IX_Departments_no").IsClustered();

            entity.Property(e => e.DeptName).HasMaxLength(50);
            entity.Property(e => e.DeptNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.EmpNo, "IX_Employees_no").IsClustered();

            entity.Property(e => e.CityArea).HasMaxLength(50);
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.ContactAddress).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.DeptNo).HasMaxLength(50);
            entity.Property(e => e.EmpName).HasMaxLength(50);
            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.TitleNo).HasMaxLength(50);
        });

        modelBuilder.Entity<EmployeeAgent>(entity =>
        {
            entity.Property(e => e.AgentNo).HasMaxLength(50);
            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<EmployeeExperience>(entity =>
        {
            entity.Property(e => e.BossName).HasMaxLength(50);
            entity.Property(e => e.CompName).HasMaxLength(50);
            entity.Property(e => e.DeptName).HasMaxLength(50);
            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.QuitReason).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.TitleName).HasMaxLength(50);
        });

        modelBuilder.Entity<EmployeeSchool>(entity =>
        {
            entity.Property(e => e.EducationNo).HasMaxLength(50);
            entity.Property(e => e.EmpNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SchoolName).HasMaxLength(50);
            entity.Property(e => e.SubjectName).HasMaxLength(50);
        });

        modelBuilder.Entity<ExtensionTable>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.ParentId, e.SortNo, e.ExtName }, "IX_ExtensionTables_pid_sort_name").IsClustered();

            entity.Property(e => e.ExtName).HasMaxLength(50);
            entity.Property(e => e.ExtNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Featured>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.SortNo, e.ProdNo }, "IX_Featureds_sort_pno").IsClustered();

            entity.Property(e => e.ProdNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<FormDetail>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("FormDetail");

            entity.HasIndex(e => new { e.FormCode, e.FormNo }, "IX_FormDetail").IsClustered();

            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.DeptName).HasMaxLength(50);
            entity.Property(e => e.DeptNo).HasMaxLength(50);
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.FormCode).HasMaxLength(50);
            entity.Property(e => e.FormNo).HasMaxLength(50);
            entity.Property(e => e.GuidNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.TargetName).HasMaxLength(50);
            entity.Property(e => e.TargetNo).HasMaxLength(50);
            entity.Property(e => e.TitleName).HasMaxLength(50);
            entity.Property(e => e.TitleNo).HasMaxLength(50);
        });

        modelBuilder.Entity<FormMaster>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("FormMaster");

            entity.HasIndex(e => new { e.FormCode, e.UserNo, e.FormNo }, "IX_FormMaster_code_user_no")
                .IsDescending(false, false, true)
                .IsClustered();

            entity.Property(e => e.ApproveNo).HasMaxLength(50);
            entity.Property(e => e.ApproveTime).HasColumnType("datetime");
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.DeptName).HasMaxLength(50);
            entity.Property(e => e.DeptNo).HasMaxLength(50);
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.FormCode).HasMaxLength(50);
            entity.Property(e => e.FormNo).HasMaxLength(50);
            entity.Property(e => e.FormTime).HasColumnType("datetime");
            entity.Property(e => e.GuidNo).HasMaxLength(50);
            entity.Property(e => e.NextNo).HasMaxLength(50);
            entity.Property(e => e.NotifyKey).HasMaxLength(50);
            entity.Property(e => e.RejectNo).HasMaxLength(50);
            entity.Property(e => e.RejectTime).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SourceNo).HasMaxLength(50);
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.StatusCode).HasMaxLength(50);
            entity.Property(e => e.TargetName).HasMaxLength(50);
            entity.Property(e => e.TargetNo).HasMaxLength(50);
            entity.Property(e => e.TitleName).HasMaxLength(50);
            entity.Property(e => e.TitleNo).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Forum>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.BoardNo, e.ParentGuid, e.SubjectDate }, "IX_Forums_pid_sort_name").IsClustered();

            entity.Property(e => e.BoardNo).HasMaxLength(50);
            entity.Property(e => e.GuidNo)
                .HasMaxLength(50)
                .HasDefaultValueSql("(newid())", "DF_Forums_GuidNo");
            entity.Property(e => e.ParentGuid).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.ReplyGuid).HasMaxLength(50);
            entity.Property(e => e.SubjectDate).HasColumnType("datetime");
            entity.Property(e => e.SubjectName).HasMaxLength(250);
            entity.Property(e => e.UserNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ForumBoard>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.SortNo, e.BoardNo }, "IX_ForumBoards_pid_sort_no").IsClustered();

            entity.Property(e => e.BoardName).HasMaxLength(250);
            entity.Property(e => e.BoardNo).HasMaxLength(50);
            entity.Property(e => e.GuidNo)
                .HasMaxLength(50)
                .HasDefaultValueSql("(newid())", "DF_ForumBoards_GuidNo");
            entity.Property(e => e.IconName).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<InvDetail>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.WareHouseNo, e.ProductNo }, "IX_InvDetails_wno_pno").IsClustered();

            entity.Property(e => e.ProductNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.WareHouseNo).HasMaxLength(50);
        });

        modelBuilder.Entity<InvMaster>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.ProductNo, "IX_InvMasters_pno").IsClustered();

            entity.Property(e => e.ProductNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.TypeNo, e.SheetCode, e.SheetNo }, "IX_Inventorys_tno_scode_sno").IsClustered();

            entity.Property(e => e.HandleNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SheetCode).HasMaxLength(50);
            entity.Property(e => e.SheetNo).HasMaxLength(50);
            entity.Property(e => e.TargetName).HasMaxLength(50);
            entity.Property(e => e.TargetNo).HasMaxLength(50);
            entity.Property(e => e.TypeNo).HasMaxLength(50);
            entity.Property(e => e.WarehouseNo).HasMaxLength(50);
        });

        modelBuilder.Entity<InventorysDetail>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("InventorysDetail");

            entity.HasIndex(e => new { e.ParentId, e.ProductNo }, "IX_InventorysDetail_pid_pno").IsClustered();

            entity.Property(e => e.ProductNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<InventorysType>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("InventorysType");

            entity.HasIndex(e => e.TypeNo, "IX_InventorysType_tno").IsClustered();

            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.TypeName).HasMaxLength(50);
            entity.Property(e => e.TypeNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.LangNo, "IX_Languages_no").IsClustered();

            entity.Property(e => e.LangName).HasMaxLength(50);
            entity.Property(e => e.LangNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.LogDate, e.LogTime }, "IX_Logs_date_time")
                .IsDescending()
                .IsClustered();

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.LogNo).HasMaxLength(50);
            entity.Property(e => e.LogTime).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.TargetNo).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
        });

        modelBuilder.Entity<MapPosition>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.TargetCode, e.TargetNo }, "IX_MapPositions_code_no").IsClustered();

            entity.Property(e => e.ContactAddress).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.TargetCode).HasMaxLength(50);
            entity.Property(e => e.TargetNo).HasMaxLength(50);
            entity.Property(e => e.TitleName).HasMaxLength(50);
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.ReceiverNo, e.SendDate, e.SendTime }, "IX_Messages_rno_date_time")
                .IsDescending(false, true, true)
                .IsClustered();

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.HeaderText).HasMaxLength(250);
            entity.Property(e => e.ReceiverNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SenderNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.RoleNo, e.SortNo, e.ModuleNo }, "IX_Modules_role_sort_no").IsClustered();

            entity.Property(e => e.IconName).HasMaxLength(50);
            entity.Property(e => e.ModuleName).HasMaxLength(50);
            entity.Property(e => e.ModuleNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.PublishDate, "IX_News_date")
                .IsDescending()
                .IsClustered();

            entity.HasIndex(e => new { e.CodeNo, e.PublishDate }, "IX_News_type_date").IsDescending(false, true);

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.HeaderName).HasMaxLength(50);
            entity.Property(e => e.PublishDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<NewsLetter>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("NewsLetter");

            entity.HasIndex(e => e.UserEmail, "IX_NewsLetter_email").IsClustered();

            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SubscribeDate).HasColumnType("datetime");
            entity.Property(e => e.UserEmail).HasMaxLength(50);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.ReceiverNo, e.SendDate, e.SendTime }, "IX_Notifications_rno_date_time")
                .IsDescending(false, true, true)
                .IsClustered();

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.HeaderText).HasMaxLength(250);
            entity.Property(e => e.ReceiverNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SenderNo).HasMaxLength(50);
            entity.Property(e => e.SourceNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.SheetNo, "IX_Orders_sno").IsClustered();

            entity.Property(e => e.CustName).HasMaxLength(50);
            entity.Property(e => e.CustNo).HasMaxLength(50);
            entity.Property(e => e.GuidNo).HasMaxLength(50);
            entity.Property(e => e.PaymentNo).HasMaxLength(50);
            entity.Property(e => e.ReceiverAddress).HasMaxLength(250);
            entity.Property(e => e.ReceiverEmail).HasMaxLength(50);
            entity.Property(e => e.ReceiverName).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SheetDate).HasColumnType("datetime");
            entity.Property(e => e.SheetNo).HasMaxLength(50);
            entity.Property(e => e.ShippingNo).HasMaxLength(50);
            entity.Property(e => e.StatusCode).HasMaxLength(50);
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.ParentNo, e.ProdNo }, "IX_OrderDetails_sno").IsClustered();

            entity.Property(e => e.CategoryNo).HasMaxLength(50);
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.ProdName).HasMaxLength(250);
            entity.Property(e => e.ProdNo).HasMaxLength(50);
            entity.Property(e => e.ProdSpec).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.VendorNo).HasMaxLength(50);
        });

        modelBuilder.Entity<OrdersStatus>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("OrdersStatus");

            entity.HasIndex(e => e.StatusNo, "IX_OrdersStatus_sno").IsClustered();

            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.StatusName).HasMaxLength(50);
            entity.Property(e => e.StatusNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.PaymentNo, "IX_Payments_no").IsClustered();

            entity.Property(e => e.PaymentName).HasMaxLength(50);
            entity.Property(e => e.PaymentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<Photo>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.CodeNo, e.FolderName }, "IX_Photos_type_folder").IsClustered();

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.FolderName).HasMaxLength(50);
            entity.Property(e => e.PhotoName).HasMaxLength(250);
            entity.Property(e => e.PriceName).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<Pricing>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.SortNo, e.PricingNo }, "IX_Pricings_sort_no").IsClustered();

            entity.Property(e => e.CycleName).HasMaxLength(50);
            entity.Property(e => e.PricingName).HasMaxLength(50);
            entity.Property(e => e.PricingNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<PricingDetail>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.PricingNo, e.SortNo }, "IX_PricingDetails_pno_sort").IsClustered();

            entity.Property(e => e.ItemName).HasMaxLength(250);
            entity.Property(e => e.PricingNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.ProdNo, "IX_Products_no").IsClustered();

            entity.Property(e => e.BarcodeNo).HasMaxLength(50);
            entity.Property(e => e.BrandName).HasMaxLength(50);
            entity.Property(e => e.BrandSeriesName).HasMaxLength(50);
            entity.Property(e => e.CategoryNo).HasMaxLength(50);
            entity.Property(e => e.ProdName).HasMaxLength(250);
            entity.Property(e => e.ProdNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.StatusNo).HasMaxLength(50);
            entity.Property(e => e.VendorNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductFeatured>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.ProdNo, e.SortNo, e.FeaturedName }, "IX_ProductFeatureds_pno_sort_name").IsClustered();

            entity.Property(e => e.FeaturedName).HasMaxLength(50);
            entity.Property(e => e.ProdNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductInventory>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.ProdNo, e.PropertyNo }, "IX_ProductInventorys_pno_propno").IsClustered();

            entity.Property(e => e.ProdNo).HasMaxLength(50);
            entity.Property(e => e.PropertyNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<ProductProperty>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.ProdNo, e.PropertyNo }, "IX_ProductPropertys_pno_prodno").IsClustered();

            entity.Property(e => e.ProdNo).HasMaxLength(50);
            entity.Property(e => e.PropertyNo).HasMaxLength(50);
            entity.Property(e => e.PropertyValue).HasMaxLength(500);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<ProductStatus>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("ProductStatus");

            entity.HasIndex(e => e.StatusNo, "IX_ProductStatus_sno").IsClustered();

            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.StatusName).HasMaxLength(50);
            entity.Property(e => e.StatusNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.ProdNo, e.TagName }, "IX_ProductTags_pno_tname").IsClustered();

            entity.Property(e => e.ProdNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.TagName).HasMaxLength(50);
        });

        modelBuilder.Entity<Program>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.ModuleNo, e.SortNo, e.PrgNo }, "IX_Programs_mno_sort_pno").IsClustered();

            entity.Property(e => e.ActionName).HasMaxLength(50);
            entity.Property(e => e.AreaName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.ControllerName).HasMaxLength(50);
            entity.Property(e => e.ModuleNo).HasMaxLength(50);
            entity.Property(e => e.ParmValue).HasMaxLength(50);
            entity.Property(e => e.PrgName).HasMaxLength(50);
            entity.Property(e => e.PrgNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.StartTime, e.EndTime, e.ProdNo }, "IX_Promotions_stime_etime_pno")
                .IsDescending(true, true, false)
                .IsClustered();

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.ProdNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
            entity.Property(e => e.StartTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.PropertyNo, "IX_Propertys_no").IsClustered();

            entity.Property(e => e.PropertyName).HasMaxLength(50);
            entity.Property(e => e.PropertyNo).HasMaxLength(50);
            entity.Property(e => e.PropertyValue).HasMaxLength(500);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<PropertyName>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.PropName, "IX_PropertyNames_name").IsClustered();

            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.PropName).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.SortNo, "IX_Questions_sno").IsClustered();

            entity.Property(e => e.AnswerText).HasMaxLength(500);
            entity.Property(e => e.QuestionText).HasMaxLength(500);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.RoleNo, "IX_Roles_no").IsClustered();

            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Security>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.RoleNo, e.TargetNo, e.ModuleNo, e.PrgNo }, "IX_Securitys_rno_tno_mno_pno").IsClustered();

            entity.Property(e => e.ModuleNo).HasMaxLength(50);
            entity.Property(e => e.PrgNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.TargetNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.SortNo, e.HeaderName }, "IX_Services_sort_name").IsClustered();

            entity.Property(e => e.DetailName).HasMaxLength(250);
            entity.Property(e => e.HeaderName).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Shipping>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.ShippingNo, "IX_Shippings_no").IsClustered();

            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.ShippingName).HasMaxLength(50);
            entity.Property(e => e.ShippingNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.SortNo, e.TeamNo }, "IX_Teams_sort_no").IsClustered();

            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.DeptName).HasMaxLength(50);
            entity.Property(e => e.EngName).HasMaxLength(50);
            entity.Property(e => e.FacebookUrl).HasMaxLength(50);
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.InstagramUrl).HasMaxLength(50);
            entity.Property(e => e.LinkedinUrl).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SkypeUrl).HasMaxLength(50);
            entity.Property(e => e.SortNo).HasMaxLength(50);
            entity.Property(e => e.TeamName).HasMaxLength(50);
            entity.Property(e => e.TeamNo).HasMaxLength(50);
            entity.Property(e => e.TitleName).HasMaxLength(50);
            entity.Property(e => e.TwitterUrl).HasMaxLength(50);
        });

        modelBuilder.Entity<Title>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.TitleNo, "IX_Titles_no").IsClustered();

            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.TitleName).HasMaxLength(50);
            entity.Property(e => e.TitleNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TodoList>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.UserNo, e.DeadlineDate }, "IX_TodoLists_uno_date")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.DeadlineDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.TitleName).HasMaxLength(250);
            entity.Property(e => e.UserNo).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.UserNo, "IX_Users_no").IsClustered();

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.ContactAddress).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.DeptNo).HasMaxLength(50);
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.NotifyPassword).HasMaxLength(250);
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.TitleNo).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
            entity.Property(e => e.ValidateCode).HasMaxLength(250);
        });

        modelBuilder.Entity<Vacation>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.VacYear, e.StartDate }, "IX_Vacations_no")
                .IsDescending(true, false)
                .IsClustered();

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<ViCodeAddressBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeAddressBook");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeBrand>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeBrand");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeCalendar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeCalendar");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeCloseDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeCloseDate");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeColor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeColor");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeCompany");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeCustomer");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeFormStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeFormStatus");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeGender>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeGender");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeLog");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeMaterial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeMaterial");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeMember");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeMessage");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeNews>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeNews");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeNotification>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeNotification");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodePhoto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodePhoto");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeProgram>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeProgram");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeResignReason>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeResignReason");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeSheet");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeSize>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeSize");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeTarget>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeTarget");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeTax");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeUser");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeVacation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeVacation");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCodeVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CodeVendor");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViCompCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CompCompany");

            entity.Property(e => e.BossName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CompAddress).HasMaxLength(250);
            entity.Property(e => e.CompFax).HasMaxLength(50);
            entity.Property(e => e.CompId)
                .HasMaxLength(50)
                .HasColumnName("CompID");
            entity.Property(e => e.CompName).HasMaxLength(250);
            entity.Property(e => e.CompNo).HasMaxLength(50);
            entity.Property(e => e.CompTel).HasMaxLength(50);
            entity.Property(e => e.CompUrl).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.EngName).HasMaxLength(250);
            entity.Property(e => e.EngShortName).HasMaxLength(50);
            entity.Property(e => e.FacebookUrl).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InstagramUrl).HasMaxLength(250);
            entity.Property(e => e.Latitude).HasColumnType("decimal(20, 15)");
            entity.Property(e => e.LinkedinUrl).HasMaxLength(250);
            entity.Property(e => e.Longitude).HasColumnType("decimal(20, 15)");
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.SkypeUrl).HasMaxLength(250);
            entity.Property(e => e.TwitterUrl).HasMaxLength(250);
        });

        modelBuilder.Entity<ViCompCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CompCustomer");

            entity.Property(e => e.BossName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CompAddress).HasMaxLength(250);
            entity.Property(e => e.CompFax).HasMaxLength(50);
            entity.Property(e => e.CompId)
                .HasMaxLength(50)
                .HasColumnName("CompID");
            entity.Property(e => e.CompName).HasMaxLength(250);
            entity.Property(e => e.CompNo).HasMaxLength(50);
            entity.Property(e => e.CompTel).HasMaxLength(50);
            entity.Property(e => e.CompUrl).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.EngName).HasMaxLength(250);
            entity.Property(e => e.EngShortName).HasMaxLength(50);
            entity.Property(e => e.FacebookUrl).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InstagramUrl).HasMaxLength(250);
            entity.Property(e => e.Latitude).HasColumnType("decimal(20, 15)");
            entity.Property(e => e.LinkedinUrl).HasMaxLength(250);
            entity.Property(e => e.Longitude).HasColumnType("decimal(20, 15)");
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.SkypeUrl).HasMaxLength(250);
            entity.Property(e => e.TwitterUrl).HasMaxLength(250);
        });

        modelBuilder.Entity<ViCompVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_CompVendor");

            entity.Property(e => e.BossName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CompAddress).HasMaxLength(250);
            entity.Property(e => e.CompFax).HasMaxLength(50);
            entity.Property(e => e.CompId)
                .HasMaxLength(50)
                .HasColumnName("CompID");
            entity.Property(e => e.CompName).HasMaxLength(250);
            entity.Property(e => e.CompNo).HasMaxLength(50);
            entity.Property(e => e.CompTel).HasMaxLength(50);
            entity.Property(e => e.CompUrl).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.EngName).HasMaxLength(250);
            entity.Property(e => e.EngShortName).HasMaxLength(50);
            entity.Property(e => e.FacebookUrl).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InstagramUrl).HasMaxLength(250);
            entity.Property(e => e.Latitude).HasColumnType("decimal(20, 15)");
            entity.Property(e => e.LinkedinUrl).HasMaxLength(250);
            entity.Property(e => e.Longitude).HasColumnType("decimal(20, 15)");
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.SkypeUrl).HasMaxLength(250);
            entity.Property(e => e.TwitterUrl).HasMaxLength(250);
        });

        modelBuilder.Entity<ViTodoList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_TodoList");

            entity.Property(e => e.BaseNo).HasMaxLength(50);
            entity.Property(e => e.CodeName).HasMaxLength(50);
            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.CodeValue).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ParentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SortNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViUserCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_UserCustomer");

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.ContactAddress).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.DeptNo).HasMaxLength(50);
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.TitleNo).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
            entity.Property(e => e.ValidateCode).HasMaxLength(250);
        });

        modelBuilder.Entity<ViUserMi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_UserMis");

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.ContactAddress).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.DeptNo).HasMaxLength(50);
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.TitleNo).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
            entity.Property(e => e.ValidateCode).HasMaxLength(250);
        });

        modelBuilder.Entity<ViUserOperator>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_UserOperator");

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.ContactAddress).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.DeptNo).HasMaxLength(50);
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.TitleNo).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
            entity.Property(e => e.ValidateCode).HasMaxLength(250);
        });

        modelBuilder.Entity<ViUserTarget>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_UserTarget");

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.ContactAddress).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.DeptNo).HasMaxLength(50);
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.TitleNo).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
            entity.Property(e => e.ValidateCode).HasMaxLength(250);
        });

        modelBuilder.Entity<ViUserUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_UserUser");

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.ContactAddress).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.DeptNo).HasMaxLength(50);
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.TitleNo).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
            entity.Property(e => e.ValidateCode).HasMaxLength(250);
        });

        modelBuilder.Entity<ViUserVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vi_UserVendor");

            entity.Property(e => e.CodeNo).HasMaxLength(50);
            entity.Property(e => e.ContactAddress).HasMaxLength(250);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactTel).HasMaxLength(50);
            entity.Property(e => e.DeptNo).HasMaxLength(50);
            entity.Property(e => e.GenderCode).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.TitleNo).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
            entity.Property(e => e.ValidateCode).HasMaxLength(250);
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.WarehouseNo, "IX_Warehouses_wno").IsClustered();

            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.WarehouseName).HasMaxLength(50);
            entity.Property(e => e.WarehouseNo).HasMaxLength(50);
        });

        modelBuilder.Entity<WorkflowDetail>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.MasterGuidNo, e.RouteGuidNo, e.RouteOrder }, "IX_WorkflowDetails_mguid_rguid_rorder").IsClustered();

            entity.Property(e => e.AgentName).HasMaxLength(50);
            entity.Property(e => e.AgentNo).HasMaxLength(50);
            entity.Property(e => e.AgentReadTime).HasColumnType("datetime");
            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.GuidNo)
                .HasMaxLength(50)
                .HasDefaultValueSql("(newid())", "DF_WorkflowDetails_GuidNo");
            entity.Property(e => e.MasterGuidNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.RouteGuidNo).HasMaxLength(50);
            entity.Property(e => e.RouteOrder).HasMaxLength(50);
            entity.Property(e => e.SignComment).HasMaxLength(250);
            entity.Property(e => e.SignTime).HasColumnType("datetime");
            entity.Property(e => e.SignUserName).HasMaxLength(50);
            entity.Property(e => e.SignUserNo).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
            entity.Property(e => e.UserReadTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<WorkflowMaster>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.FlowGuidNo, e.SheetNo, e.StartTime }, "IX_WorkflowMasters_fguid_fno_stime").IsClustered();

            entity.Property(e => e.DeadlineTime).HasColumnType("datetime");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.FlowGuidNo).HasMaxLength(50);
            entity.Property(e => e.GuidNo)
                .HasMaxLength(50)
                .HasDefaultValueSql("(newid())", "DF_WorkflowMasters_GuidNo");
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SheetName).HasMaxLength(50);
            entity.Property(e => e.SheetNo).HasMaxLength(50);
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
        });

        modelBuilder.Entity<WorkflowRole>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.RoleNo, "IX_WorkflowRoles_no").IsClustered();

            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
        });

        modelBuilder.Entity<WorkflowRoleUser>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_RoleUsers")
                .IsClustered(false);

            entity.HasIndex(e => new { e.RoleNo, e.UserNo }, "IX_WorkflowRoleUsers_rno_uno").IsClustered();

            entity.Property(e => e.AgentNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.UserNo).HasMaxLength(50);
        });

        modelBuilder.Entity<WorkflowRoute>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => new { e.PrgNo, e.RouteOrder }, "IX_WorkflowRoutes_pno_rorder").IsClustered();

            entity.Property(e => e.PrgNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.RoleNo).HasMaxLength(50);
            entity.Property(e => e.RouteOrder).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

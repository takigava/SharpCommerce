using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication.Models
{
    public partial class ShopDbContext : DbContext
    {
        public static string ConnectionString{get;set;}
        public virtual DbSet<Block> Block { get; set; }
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<BlogCategory> BlogCategory { get; set; }
        public virtual DbSet<BlogComment> BlogComment { get; set; }
        public virtual DbSet<BlogTags> BlogTags { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CustomerContact> CustomerContact { get; set; }
        public virtual DbSet<Faq> Faq { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<LogType> LogType { get; set; }
        public virtual DbSet<MailFormat> MailFormat { get; set; }
        public virtual DbSet<MailFormatType> MailFormatType { get; set; }
        public virtual DbSet<MainMenu> MainMenu { get; set; }
        public virtual DbSet<MainPageProduct> MainPageProduct { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsCategory> NewsCategory { get; set; }
        public virtual DbSet<NewsComment> NewsComment { get; set; }
        public virtual DbSet<NewsTags> NewsTags { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderContact> OrderContact { get; set; }
        public virtual DbSet<OrderCurrency> OrderCurrency { get; set; }
        public virtual DbSet<OrderPriceDiscount> OrderPriceDiscount { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<OrderedCart> OrderedCart { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<PaymentParam> PaymentParam { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<PricingPeriod> PricingPeriod { get; set; }
        public virtual DbSet<PricingTable> PricingTable { get; set; }
        public virtual DbSet<PricingTableOptions> PricingTableOptions { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductBadge> ProductBadge { get; set; }
        public virtual DbSet<ProductCategories> ProductCategories { get; set; }
        public virtual DbSet<ProductDiscussion> ProductDiscussion { get; set; }
        public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
        public virtual DbSet<ProductPropertyValue> ProductPropertyValue { get; set; }
        public virtual DbSet<ProductTax> ProductTax { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyValue> PropertyValue { get; set; }
        public virtual DbSet<RecentlyViews> RecentlyViews { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RelatedProduct> RelatedProduct { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<ShippingContact> ShippingContact { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethod { get; set; }
        public virtual DbSet<ShippingParam> ShippingParam { get; set; }
        public virtual DbSet<ShippingType> ShippingType { get; set; }
        public virtual DbSet<SocialWidgets> SocialWidgets { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<Testimonials> Testimonials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Block>(entity =>
            {
                entity.ToTable("Block", "Static");

                entity.Property(e => e.BlockId).HasColumnName("BlockID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.BlockContent).HasColumnType("varchar(max)");

                entity.Property(e => e.BlockKey).HasColumnType("varchar(50)");

                entity.Property(e => e.Enabled).HasDefaultValueSql("0");

                entity.Property(e => e.InnerName).HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("Blog", "Blog");

                entity.Property(e => e.BlogId).HasColumnName("BlogID");

                entity.Property(e => e.BlogCategoryId).HasColumnName("BlogCategoryID");

                entity.Property(e => e.IsCommentEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.Picture).HasColumnType("varchar(255)");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Text).HasColumnType("varchar(max)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.BlogCategory)
                    .WithMany(p => p.Blog)
                    .HasForeignKey(d => d.BlogCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Blog_Blog");
            });

            modelBuilder.Entity<BlogCategory>(entity =>
            {
                entity.ToTable("BlogCategory", "Blog");

                entity.Property(e => e.BlogCategoryId).HasColumnName("BlogCategoryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BlogComment>(entity =>
            {
                entity.ToTable("BlogComment", "Blog");

                entity.Property(e => e.BlogCommentId).HasColumnName("BlogCommentID");

                entity.Property(e => e.BlogId).HasColumnName("BlogID");

                entity.Property(e => e.Comment).HasColumnType("varchar(max)");

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(100)");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("1");

                entity.Property(e => e.IsDelated).HasDefaultValueSql("0");

                entity.Property(e => e.IsSpam).HasDefaultValueSql("0");

                entity.Property(e => e.LastName).HasColumnType("varchar(100)");

                entity.Property(e => e.ParentCommentId).HasColumnName("ParentCommentID");

                entity.Property(e => e.WebSite).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.BlogComment)
                    .HasForeignKey(d => d.BlogId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BlogComment_Blog");
            });

            modelBuilder.Entity<BlogTags>(entity =>
            {
                entity.ToTable("BlogTags", "Blog");

                entity.Property(e => e.BlogTagsId).HasColumnName("BlogTagsID");

                entity.Property(e => e.BlogId).HasColumnName("BlogID");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.BlogTags)
                    .HasForeignKey(d => d.BlogId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BlogTags_Blog");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.BlogTags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BlogTags_Tags");
            });

            modelBuilder.Entity<Brands>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK_Brands");

                entity.ToTable("Brands", "Addon");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Picture)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.WebSiteUrl).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category", "Catalog");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.DisplayChildProducts).HasDefaultValueSql("0");

                entity.Property(e => e.DisplayFilter).HasDefaultValueSql("0");

                entity.Property(e => e.DisplayStyle).HasColumnType("varchar(50)");

                entity.Property(e => e.DisplayThematicTabs).HasDefaultValueSql("0");

                entity.Property(e => e.Enabled).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ParentCategoryId).HasColumnName("ParentCategoryID");

                entity.Property(e => e.Picture).HasColumnType("varchar(255)");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.Property(e => e.WebUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City", "Geo");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_City_Country");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_City_Region");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "Geo");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Iso2).HasColumnType("char(2)");

                entity.Property(e => e.Iso3).HasColumnType("char(3)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency", "Global");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Code).HasMaxLength(7);

                entity.Property(e => e.CurrencyIso).HasColumnType("nchar(3)");

                entity.Property(e => e.IsMainCurrency).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK_Customer.Contact");

                entity.ToTable("CustomerContact", "Customer");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Fax).HasColumnType("varchar(50)");

                entity.Property(e => e.Main).HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Zip).HasColumnType("varchar(25)");

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.CustomerContact)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_CustomerContact_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CustomerContact)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CustomerContact_Country");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.CustomerContact)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_CustomerContact_Region");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("Faq", "Addon");

                entity.Property(e => e.FaqId).HasColumnName("FaqID");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log", "Settings");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Log)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Log_LogType");
            });

            modelBuilder.Entity<LogType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK_LogType");

                entity.ToTable("LogType", "Settings");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<MailFormat>(entity =>
            {
                entity.ToTable("MailFormat", "Settings");

                entity.Property(e => e.MailFormatId).HasColumnName("MailFormatID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Enabled).HasDefaultValueSql("0");

                entity.Property(e => e.FormatName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FormatText).HasColumnType("varchar(max)");

                entity.Property(e => e.FormatTypeId)
                    .HasColumnName("FormatTypeID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.HasOne(d => d.FormatType)
                    .WithMany(p => p.MailFormat)
                    .HasForeignKey(d => d.FormatTypeId)
                    .HasConstraintName("FK_MailFormat_MailFormatType");
            });

            modelBuilder.Entity<MailFormatType>(entity =>
            {
                entity.ToTable("MailFormatType", "Settings");

                entity.Property(e => e.MailFormatTypeId).HasColumnName("MailFormatTypeID");

                entity.Property(e => e.Comment).HasColumnType("varchar(max)");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<MainMenu>(entity =>
            {
                entity.HasKey(e => e.MenuItemId)
                    .HasName("PK_MainMenu");

                entity.ToTable("MainMenu", "Static");

                entity.Property(e => e.MenuItemId).HasColumnName("MenuItemID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("0");

                entity.Property(e => e.Icon).HasColumnType("varchar(100)");

                entity.Property(e => e.IsIconEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.MenuItemParentId).HasColumnName("MenuItemParentID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.Property(e => e.WebUrl)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'/'");
            });

            modelBuilder.Entity<MainPageProduct>(entity =>
            {
                entity.ToTable("MainPageProduct", "Catalog");

                entity.Property(e => e.MainPageProductId).HasColumnName("MainPageProductID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("0");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MainPageProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MainPageProduct_Product");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("News", "News");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.IsCommentEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.NewsCategoryId).HasColumnName("NewsCategoryID");

                entity.Property(e => e.Picture).HasColumnType("varchar(255)");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Text).HasColumnType("varchar(max)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.NewsCategory)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.NewsCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_News_NewsCategory");
            });

            modelBuilder.Entity<NewsCategory>(entity =>
            {
                entity.ToTable("NewsCategory", "News");

                entity.Property(e => e.NewsCategoryId).HasColumnName("NewsCategoryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NewsComment>(entity =>
            {
                entity.ToTable("NewsComment", "News");

                entity.Property(e => e.NewsCommentId).HasColumnName("NewsCommentID");

                entity.Property(e => e.Comment).HasColumnType("varchar(max)");

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(100)");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("1");

                entity.Property(e => e.IsDelated).HasDefaultValueSql("0");

                entity.Property(e => e.IsSpam).HasDefaultValueSql("0");

                entity.Property(e => e.LastName).HasColumnType("varchar(100)");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.ParentCommentId).HasColumnName("ParentCommentID");

                entity.Property(e => e.WebSite).HasColumnType("varchar(255)");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.NewsComment)
                    .HasForeignKey(d => d.NewsId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NewsComment_News");
            });

            modelBuilder.Entity<NewsTags>(entity =>
            {
                entity.ToTable("NewsTags", "News");

                entity.Property(e => e.NewsTagsId).HasColumnName("NewsTagsID");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.NewsTags)
                    .HasForeignKey(d => d.NewsId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NewsTags_News");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.NewsTags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NewsTags_Tags");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order", "Order");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.AdminComment).HasColumnType("varchar(max)");

                entity.Property(e => e.CustomerComment).HasColumnType("varchar(max)");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderContactId).HasColumnName("OrderContactID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDiscount).HasDefaultValueSql("0");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PaymentMethodName).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingContactId).HasColumnName("ShippingContactID");

                entity.Property(e => e.ShippingCost)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");

                entity.Property(e => e.ShippingMethodName).HasColumnType("varchar(255)");

                entity.Property(e => e.StatusComment).HasColumnType("varchar(max)");

                entity.Property(e => e.Sum)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SupplyTotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaxCost)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.OrderContact)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.OrderContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Order_OrderContact");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Order_OrderStatus");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Order_PaymentMethod");

                entity.HasOne(d => d.ShippingContact)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ShippingContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Order_ShippingContact");

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ShippingMethodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Order_ShippingMethod");
            });

            modelBuilder.Entity<OrderContact>(entity =>
            {
                entity.ToTable("OrderContact", "Order");

                entity.Property(e => e.OrderContactId).HasColumnName("OrderContactID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Fax).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Zip).HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<OrderCurrency>(entity =>
            {
                entity.ToTable("OrderCurrency", "Order");

                entity.Property(e => e.OrderCurrencyId).HasColumnName("OrderCurrencyID");

                entity.Property(e => e.CurrencyCode).HasMaxLength(7);

                entity.Property(e => e.CurrencyValue).HasDefaultValueSql("0");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderCurrency)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderCurrency_Order");
            });

            modelBuilder.Entity<OrderPriceDiscount>(entity =>
            {
                entity.ToTable("OrderPriceDiscount", "Order");

                entity.Property(e => e.OrderPriceDiscountId).HasColumnName("OrderPriceDiscountID");

                entity.Property(e => e.PriceDiscount).HasDefaultValueSql("0");

                entity.Property(e => e.PriceEndRange).HasColumnType("money");

                entity.Property(e => e.PriceStartRange).HasColumnType("money");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus", "Order");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<OrderedCart>(entity =>
            {
                entity.ToTable("OrderedCart", "Order");

                entity.Property(e => e.OrderedCartId).HasColumnName("OrderedCartID");

                entity.Property(e => e.ArtNo).HasColumnType("varchar(50)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Quantity).HasDefaultValueSql("0");

                entity.Property(e => e.SupplyPrice).HasColumnType("money");

                entity.Property(e => e.Weight).HasDefaultValueSql("0");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderedCart)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderedCart_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderedCart)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderedCart_Product");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.ToTable("Page", "Static");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Enabled).HasDefaultValueSql("0");

                entity.Property(e => e.IsCommentEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PageText).HasColumnType("varchar(max)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("PaymentMethod", "Order");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Enabled).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.PaymentMethod)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_PaymentMethod_PaymentType");
            });

            modelBuilder.Entity<PaymentParam>(entity =>
            {
                entity.ToTable("PaymentParam", "Order");

                entity.Property(e => e.PaymentParamId).HasColumnName("PaymentParamID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.PaymentParam)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PaymentParam_PaymentMethod");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("PaymentType", "Order");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<PricingPeriod>(entity =>
            {
                entity.ToTable("PricingPeriod", "Addon");

                entity.Property(e => e.PricingPeriodId).HasColumnName("PricingPeriodID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<PricingTable>(entity =>
            {
                entity.ToTable("PricingTable", "Addon");

                entity.Property(e => e.PricingTableId).HasColumnName("PricingTableID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PricingPeriodId).HasColumnName("PricingPeriodID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.PricingTable)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PricingTable_Currency");

                entity.HasOne(d => d.PricingPeriod)
                    .WithMany(p => p.PricingTable)
                    .HasForeignKey(d => d.PricingPeriodId)
                    .HasConstraintName("FK_PricingTable_PricingPeriod");
            });

            modelBuilder.Entity<PricingTableOptions>(entity =>
            {
                entity.HasKey(e => e.PricingTableOptionId)
                    .HasName("PK_PricingTableOptions");

                entity.ToTable("PricingTableOptions", "Addon");

                entity.Property(e => e.PricingTableOptionId).HasColumnName("PricingTableOptionID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PricingTableId).HasColumnName("PricingTableID");

                entity.Property(e => e.Value).HasColumnType("varchar(255)");

                entity.HasOne(d => d.PricingTable)
                    .WithMany(p => p.PricingTableOptions)
                    .HasForeignKey(d => d.PricingTableId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PricingTableOptions_PricingTable");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "Catalog");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ArtNo).HasColumnType("varchar(50)");

                entity.Property(e => e.BadgeId).HasColumnName("BadgeID");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Discount).HasDefaultValueSql("0");

                entity.Property(e => e.Enabled).HasDefaultValueSql("0");

                entity.Property(e => e.EnabledRatio).HasDefaultValueSql("0");

                entity.Property(e => e.IsFreeShipping).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Ratio).HasDefaultValueSql("0");

                entity.Property(e => e.RelatedProductId).HasColumnName("RelatedProductID");

                entity.Property(e => e.ShortDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.ShowRatio).HasDefaultValueSql("0");

                entity.Property(e => e.Size)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("(0)|(0))|(0");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Weight).HasDefaultValueSql("0");

                entity.HasOne(d => d.Badge)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.BadgeId)
                    .HasConstraintName("FK_Product_ProductBadge");

                entity.HasOne(d => d.RelatedProduct)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.RelatedProductId)
                    .HasConstraintName("FK_Product_RelatedProduct");
            });

            modelBuilder.Entity<ProductBadge>(entity =>
            {
                entity.HasKey(e => e.BadgeId)
                    .HasName("PK_Catalog.ProductBadge");

                entity.ToTable("ProductBadge", "Catalog");

                entity.Property(e => e.BadgeId).HasColumnName("BadgeID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ProductCategories>(entity =>
            {
                entity.ToTable("ProductCategories", "Catalog");

                entity.Property(e => e.ProductCategoriesId).HasColumnName("ProductCategoriesID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.IsMainCategory).HasDefaultValueSql("0");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductCategories_Category");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductCategories_Product");
            });

            modelBuilder.Entity<ProductDiscussion>(entity =>
            {
                entity.ToTable("ProductDiscussion", "Catalog");

                entity.Property(e => e.ProductDiscussionId).HasColumnName("ProductDiscussionID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Moderated).HasDefaultValueSql("0");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductDiscussion)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductDiscussion_Product");
            });

            modelBuilder.Entity<ProductPhoto>(entity =>
            {
                entity.ToTable("ProductPhoto", "Catalog");

                entity.Property(e => e.ProductPhotoId).HasColumnName("ProductPhotoID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.IsMainPhoto).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.Property(e => e.WebUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPhoto)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductPhoto_Product");
            });

            modelBuilder.Entity<ProductPropertyValue>(entity =>
            {
                entity.HasKey(e => e.ProductPropertyId)
                    .HasName("PK_Catalog.ProductPropertyValue");

                entity.ToTable("ProductPropertyValue", "Catalog");

                entity.Property(e => e.ProductPropertyId).HasColumnName("ProductPropertyID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PropertyValueId).HasColumnName("PropertyValueID");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPropertyValue)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductPropertyValue_Product");

                entity.HasOne(d => d.PropertyValue)
                    .WithMany(p => p.ProductPropertyValue)
                    .HasForeignKey(d => d.PropertyValueId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductPropertyValue_PropertyValue");
            });

            modelBuilder.Entity<ProductTax>(entity =>
            {
                entity.ToTable("ProductTax", "Catalog");

                entity.Property(e => e.ProductTaxId).HasColumnName("ProductTaxID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductTax)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductTax_Product");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.ProductTax)
                    .HasForeignKey(d => d.TaxId)
                    .HasConstraintName("FK_ProductTax_Tax");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.ToTable("Profile", "Membership");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.Avatar).HasColumnType("varchar(255)");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.SurName).HasColumnType("varchar(255)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Profile_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Profile_Country");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.ToTable("Property", "Catalog");

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.Property(e => e.UseInFilter).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PropertyValue>(entity =>
            {
                entity.ToTable("PropertyValue", "Catalog");

                entity.Property(e => e.PropertyValueId).HasColumnName("PropertyValueID");

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.Property(e => e.UseInFilter).HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyValue)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PropertyValue_Property");
            });

            modelBuilder.Entity<RecentlyViews>(entity =>
            {
                entity.ToTable("RecentlyViews", "Customer");

                entity.Property(e => e.RecentlyViewsId).HasColumnName("RecentlyViewsID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ViewDate).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.RecentlyViews)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RecentlyViews_Product");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region", "Geo");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Code).HasColumnType("varchar(50)");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<RelatedProduct>(entity =>
            {
                entity.ToTable("RelatedProduct", "Catalog");

                entity.Property(e => e.RelatedProductId).HasColumnName("RelatedProductID");

                entity.Property(e => e.ChildProductId).HasColumnName("ChildProductID");

                entity.Property(e => e.MainProductId).HasColumnName("MainProductID");

                entity.HasOne(d => d.ChildProduct)
                    .WithMany(p => p.RelatedProductChildProduct)
                    .HasForeignKey(d => d.ChildProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RelatedProduct_ChildProduct");

                entity.HasOne(d => d.MainProduct)
                    .WithMany(p => p.RelatedProductMainProduct)
                    .HasForeignKey(d => d.MainProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RelatedProduct_MainProduct");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK_Services");

                entity.ToTable("Services", "Addon");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasKey(e => e.SettindId)
                    .HasName("PK_Settings");

                entity.ToTable("Settings", "Settings");

                entity.Property(e => e.SettindId).HasColumnName("SettindID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Value).HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<ShippingContact>(entity =>
            {
                entity.HasKey(e => e.OrderShippingContactId)
                    .HasName("PK_Order.ShippingContact");

                entity.ToTable("ShippingContact", "Order");

                entity.Property(e => e.OrderShippingContactId).HasColumnName("OrderShippingContactID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Fax).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Zip).HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<ShippingMethod>(entity =>
            {
                entity.ToTable("ShippingMethod", "Order");

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.Enabled).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");

                entity.HasOne(d => d.ShippingTypeNavigation)
                    .WithMany(p => p.ShippingMethod)
                    .HasForeignKey(d => d.ShippingType)
                    .HasConstraintName("FK_ShippingMethod_ShippingType");
            });

            modelBuilder.Entity<ShippingParam>(entity =>
            {
                entity.ToTable("ShippingParam", "Order");

                entity.Property(e => e.ShippingParamId).HasColumnName("ShippingParamID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.ShippingParam)
                    .HasForeignKey(d => d.ShippingMethodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ShippingParam_ShippingMethod");
            });

            modelBuilder.Entity<ShippingType>(entity =>
            {
                entity.ToTable("ShippingType", "Order");

                entity.Property(e => e.ShippingTypeId).HasColumnName("ShippingTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<SocialWidgets>(entity =>
            {
                entity.HasKey(e => e.WidgetId)
                    .HasName("PK_Static.SocialWidgets");

                entity.ToTable("SocialWidgets", "Static");

                entity.Property(e => e.WidgetId).HasColumnName("WidgetID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ScriptText).HasColumnType("varchar(max)");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK_Tags");

                entity.ToTable("Tags", "Global");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.ToTable("Tax", "Global");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Value)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Testimonials>(entity =>
            {
                entity.ToTable("Testimonials", "Addon");

                entity.Property(e => e.TestimonialsId).HasColumnName("TestimonialsID");

                entity.Property(e => e.Author).HasColumnType("varchar(255)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.WebSite).HasColumnType("varchar(255)");
            });
        }
    }
}
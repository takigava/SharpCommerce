using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Product
    {
        public Product()
        {
            MainPageProduct = new HashSet<MainPageProduct>();
            OrderedCart = new HashSet<OrderedCart>();
            ProductCategories = new HashSet<ProductCategories>();
            ProductDiscussion = new HashSet<ProductDiscussion>();
            ProductPhoto = new HashSet<ProductPhoto>();
            ProductPropertyValue = new HashSet<ProductPropertyValue>();
            ProductTax = new HashSet<ProductTax>();
            RecentlyViews = new HashSet<RecentlyViews>();
            RelatedProductChildProduct = new HashSet<RelatedProduct>();
            RelatedProductMainProduct = new HashSet<RelatedProduct>();
        }

        public int ProductId { get; set; }
        public string ArtNo { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public bool? Enabled { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? EnabledRatio { get; set; }
        public bool? ShowRatio { get; set; }
        public double? Ratio { get; set; }
        public double? Weight { get; set; }
        public string Size { get; set; }
        public string Slug { get; set; }
        public int? BadgeId { get; set; }
        public double? Discount { get; set; }
        public bool? IsFreeShipping { get; set; }
        public decimal? Price { get; set; }
        public int? RelatedProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual ICollection<MainPageProduct> MainPageProduct { get; set; }
        public virtual ICollection<OrderedCart> OrderedCart { get; set; }
        public virtual ICollection<ProductCategories> ProductCategories { get; set; }
        public virtual ICollection<ProductDiscussion> ProductDiscussion { get; set; }
        public virtual ICollection<ProductPhoto> ProductPhoto { get; set; }
        public virtual ICollection<ProductPropertyValue> ProductPropertyValue { get; set; }
        public virtual ICollection<ProductTax> ProductTax { get; set; }
        public virtual ICollection<RecentlyViews> RecentlyViews { get; set; }
        public virtual ICollection<RelatedProduct> RelatedProductChildProduct { get; set; }
        public virtual ICollection<RelatedProduct> RelatedProductMainProduct { get; set; }
        public virtual ProductBadge Badge { get; set; }
        public virtual RelatedProduct RelatedProduct { get; set; }
    }
}

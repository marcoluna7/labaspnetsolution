//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoeEcommers.LogicLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public Products()
        {
            this.Skus = new HashSet<Skus>();
            this.Campaigns = new HashSet<Campaigns>();
        }
    
        public int Id { get; set; }
        public int IdBrand { get; set; }
        public int IdSubcategory { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public bool Active { get; set; }
        public Nullable<int> IdRef { get; set; }
    
        public virtual Brands Brands { get; set; }
        public virtual SubCategories SubCategories { get; set; }
        public virtual ICollection<Skus> Skus { get; set; }
        public virtual ICollection<Campaigns> Campaigns { get; set; }
    }
}

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
    
    public partial class UserProfile
    {
        public UserProfile()
        {
            this.Customers = new HashSet<Customers>();
            this.webpages_Roles = new HashSet<webpages_Roles>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
    
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<webpages_Roles> webpages_Roles { get; set; }
    }
}

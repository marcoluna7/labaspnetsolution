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
    
    public partial class Department
    {
        public Department()
        {
            this.Categories = new HashSet<Categories>();
        }
    
        public int Id { get; set; }
        public string Department1 { get; set; }
    
        public virtual ICollection<Categories> Categories { get; set; }
    }
}

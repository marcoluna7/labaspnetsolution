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
    
    public partial class GroupsAttributes
    {
        public GroupsAttributes()
        {
            this.AttributeSkus = new HashSet<AttributeSkus>();
        }
    
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string TypeGroup { get; set; }
        public string ValueGroup { get; set; }
    
        public virtual ICollection<AttributeSkus> AttributeSkus { get; set; }
    }
}

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
    
    public partial class ImagesSkus
    {
        public int Id { get; set; }
        public int IdSku { get; set; }
        public string UrlImage { get; set; }
        public string TypeImage { get; set; }
    
        public virtual Skus Skus { get; set; }
    }
}

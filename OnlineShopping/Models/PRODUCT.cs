//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShopping.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.PRODUCT_IN_ORDER = new HashSet<PRODUCT_IN_ORDER>();
        }
    
        public int ID { get; set; }
        public int CATEGORY_ID { get; set; }
        public string NAME { get; set; }
        public double PRICE { get; set; }
        public string DESCRIPTION { get; set; }
        public string IMG_LINK { get; set; }
    
        public virtual CATEGORy CATEGORy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_IN_ORDER> PRODUCT_IN_ORDER { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryTask
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_PurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PurchaseOrder()
        {
            this.tbl_PurchaseOrderDetail = new HashSet<tbl_PurchaseOrderDetail>();
        }
    
        public int POID { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> Amount { get; set; }
    
        public virtual tbl_Customer tbl_Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PurchaseOrderDetail> tbl_PurchaseOrderDetail { get; set; }
    }
}

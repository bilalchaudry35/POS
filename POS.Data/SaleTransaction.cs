//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaleTransaction()
        {
            this.SaleTransactionItems = new HashSet<SaleTransactionItem>();
        }
    
        public int SaleTransactionId { get; set; }
        public int CustomerId { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<int> TellerUserId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaymentMade { get; set; }
        public decimal ChangeGiven { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleTransactionItem> SaleTransactionItems { get; set; }
    }
}

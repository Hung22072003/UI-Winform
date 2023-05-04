//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI_Winform.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.Storages = new HashSet<Storage>();
        }
    
        public string IDItem { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal InitialPrice { get; set; }
        public double Discount { get; set; }
        public string ItemDetail { get; set; }
        public byte[] Picture { get; set; }
        public int Warranty { get; set; }
        public string ID_Category { get; set; }
        public string ID_Brand { get; set; }
        public Nullable<decimal> SellPrice { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Storage> Storages { get; set; }

        public static bool CompareQuantity(object o1, object o2)
        {
            return ((Item)o1).Quantity > ((Item)o2).Quantity;
        }

        public static bool CompareID(object o1, object o2)
        {
            return String.Compare(((Item)o1).IDItem, ((Item)o2).IDItem) > 0;
        }
    }
}

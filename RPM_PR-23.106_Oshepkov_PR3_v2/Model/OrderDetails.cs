//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPM_PR_23._106_Oshepkov_PR3_v2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetails
    {
        public int order_details_id { get; set; }
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int product_quantity { get; set; }
        public decimal order_details_cost { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Product Product { get; set; }
    }
}

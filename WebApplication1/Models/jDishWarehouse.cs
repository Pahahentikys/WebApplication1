//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class jDishWarehouse
    {
        public int DishId { get; set; }
        public int DishAmount { get; set; }
        public int DishWarehouseId { get; set; }
        public Nullable<System.DateTime> DishDate { get; set; }
        public bool Exist { get; set; }
    
        public virtual hDish hDish { get; set; }
    }
}
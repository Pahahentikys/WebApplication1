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
    
    public partial class jDish
    {
        public int DishId { get; set; }
        public int PersonId { get; set; }
        public System.DateTime DishCreateDate { get; set; }
        public float HumanHoursAmount { get; set; }
        public int jDishId { get; set; }
        public Nullable<decimal> DishCost { get; set; }
        public bool Exist { get; set; }
    
        public virtual hDish hDish { get; set; }
        public virtual hPersonal hPersonal { get; set; }
    }
}

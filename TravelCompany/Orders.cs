//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelCompany
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Code_order { get; set; }
        public int Code_worker { get; set; }
        public int Code_client { get; set; }
        public int Code_tour { get; set; }
        public System.DateTime Registration_date { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual Worker Worker { get; set; }
        public override string ToString() => Worker.Familia_worker + " " + Worker.Name_worker + " " + Worker.Patronymic_worker;
    }
}
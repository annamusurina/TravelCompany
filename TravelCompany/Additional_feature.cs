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
    
    public partial class Additional_feature
    {
        public int Code_feature { get; set; }
        public int Code_service { get; set; }
        public int Code_hotel { get; set; }
    
        public virtual Servic Servic { get; set; }
        public virtual Hotel Hotel { get; set; }
        public override string ToString() => Servic.Title_service;
    }
}
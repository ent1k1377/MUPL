//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mupl
{
    using System;
    using System.Collections.Generic;
    
    public partial class track_genre
    {
        public int id { get; set; }
        public int id_track { get; set; }
        public int id_genre { get; set; }
    
        public virtual genre genre { get; set; }
        public virtual track track { get; set; }
    }
}
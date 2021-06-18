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
    using System.Linq;

    public partial class track
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public track()
        {
            this.track_genre = new HashSet<track_genre>();
            this.user_track = new HashSet<user_track>();
        }

        public int id { get; set; }
        public int id_performer { get; set; }
        public int id_album { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string performerName
        {
            get
            {
                try
                {
                    return muplEntities.GetContext().performer.Where(p => p.id == id_performer).ToList()[0].name.ToString();
                }
                catch (Exception)
                {
                    return "";
                }
                
            }
            set { }
        }
        public string almumName
        {
            get
            {
                try
                {
                    return muplEntities.GetContext().album.Where(p => p.id == id_album).ToList()[0].name.ToString();
                }
                catch (Exception)
                {
                    return "";
                }
                
            }
            set { }
        }
        public System.DateTime date { get; set; }
    
        public virtual album album { get; set; }
        public virtual performer performer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<track_genre> track_genre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_track> user_track { get; set; }
    }
}

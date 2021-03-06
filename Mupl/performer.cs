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
    using System.IO;
    using System.Linq;

    public partial class performer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public performer()
        {
            this.track = new HashSet<track>();
        }
    
        public int id { get; set; }
        public int id_label { get; set; }
        public string labelName
        {
            get
            {
                try
                {
                    return muplEntities.GetContext().label.Where(p => p.id == id_label).ToList()[0].name.ToString();
                }
                catch (Exception)
                {
                    return "";
                }
            }
            set { }
        }
        public string name { get; set; }
        public string description { get; set; }
        public string photo { get; set; }
        public string picture
        {
            get
            {
                string path = $"{Directory.GetCurrentDirectory()}\\Images\\{photo}";
                if (File.Exists(path))
                    return path;

                return $"{Directory.GetCurrentDirectory()}\\Images\\photo0.png";
            }
            set { }
        }

        public virtual label label { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<track> track { get; set; }
    }
}

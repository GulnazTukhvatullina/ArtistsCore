//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtistsCore
{
    using System;
    using System.Collections.Generic;
    
    public partial class Information_artist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Information_artist()
        {
            this.Users = new HashSet<Users>();
        }
    
        public int ID_info { get; set; }
        public Nullable<System.DateTime> Birth_date { get; set; }
        public byte[] Image { get; set; }
        public bool Deleted { get; set; }
        public string Biography { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users { get; set; }
    }
}

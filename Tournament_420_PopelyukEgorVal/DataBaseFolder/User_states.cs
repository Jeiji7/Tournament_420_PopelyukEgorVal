//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_420_PopelyukEgorVal.DataBaseFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_states
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_states()
        {
            this.User = new HashSet<User>();
        }
    
        public int ID_states { get; set; }
        public Nullable<int> CountGame { get; set; }
        public Nullable<int> CountWin { get; set; }
        public Nullable<int> CountLose { get; set; }
        public string Achievements { get; set; }
        public Nullable<int> Rang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }
    }
}

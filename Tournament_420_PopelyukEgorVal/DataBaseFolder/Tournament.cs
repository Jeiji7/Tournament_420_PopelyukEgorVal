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
    
    public partial class Tournament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tournament()
        {
            this.Registration = new HashSet<Registration>();
        }
    
        public int ID_tournament { get; set; }
        public Nullable<System.DateTime> Date_start { get; set; }
        public Nullable<int> Count_user { get; set; }
        public string Prize { get; set; }
        public Nullable<int> ID_format { get; set; }
        public Nullable<int> ID_status { get; set; }
        public Nullable<int> ID_user { get; set; }
        public string NameTournament { get; set; }
    
        public virtual Format Format { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registration { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}

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
    
    public partial class Teams_users
    {
        public int ID_teams_users { get; set; }
        public Nullable<int> ID_user { get; set; }
        public Nullable<int> ID_teams { get; set; }
    
        public virtual Teams Teams { get; set; }
        public virtual User User { get; set; }
    }
}
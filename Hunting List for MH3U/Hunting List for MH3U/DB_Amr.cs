//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hunting_List_for_MH3U
{
    using System;
    using System.Collections.Generic;
    
    public partial class DB_Amr
    {
        public DB_Amr()
        {
            this.DB_Itm_Amr = new HashSet<DB_Itm_Amr>();
        }
    
        public int Amr_ID { get; set; }
        public Nullable<int> Amr_BG { get; set; }
        public Nullable<int> Amr_MF { get; set; }
        public Nullable<int> Amr_Rare { get; set; }
        public Nullable<int> Amr_Part { get; set; }
        public Nullable<int> Amr_Slot { get; set; }
        public Nullable<int> Def { get; set; }
        public Nullable<int> Def_Max { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Res_Fire { get; set; }
        public Nullable<int> Res_Water { get; set; }
        public Nullable<int> Res_Ice { get; set; }
        public Nullable<int> Res_Thunder { get; set; }
        public Nullable<int> Res_Dragon { get; set; }
    
        public virtual ICollection<DB_Itm_Amr> DB_Itm_Amr { get; set; }
        public virtual ID_Amr_Name ID_Amr_Name { get; set; }
    }
}

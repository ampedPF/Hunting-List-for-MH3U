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
    
    public partial class DB_Wpn
    {
        public DB_Wpn()
        {
            this.DB_Itm_Wpn = new HashSet<DB_Itm_Wpn>();
        }
    
        public int Wpn_ID { get; set; }
        public Nullable<int> Wpn_Type_ID { get; set; }
        public Nullable<int> Wpn_Sub_ID { get; set; }
        public Nullable<int> Wpn_Rare { get; set; }
        public Nullable<int> Wpn_Atk { get; set; }
        public Nullable<int> Wpn_SpAtk1_ID { get; set; }
        public Nullable<int> Wpn_SpAtk1_Num { get; set; }
        public Nullable<int> Wpn_SpAtk2_ID { get; set; }
        public Nullable<int> Wpn_SpAtk2_Num { get; set; }
        public Nullable<int> Wpn_SpAtk_H { get; set; }
        public Nullable<double> Wpn_Crit { get; set; }
        public Nullable<int> Wpn_Def { get; set; }
        public Nullable<int> Wpn_Slot { get; set; }
        public Nullable<int> Wpn_ProPx { get; set; }
        public Nullable<int> Wpn_LvUpPx { get; set; }
        public Nullable<int> Wpn_Sharp0_1 { get; set; }
        public Nullable<int> Wpn_Sharp0_2 { get; set; }
        public Nullable<int> Wpn_Sharp0_3 { get; set; }
        public Nullable<int> Wpn_Sharp0_4 { get; set; }
        public Nullable<int> Wpn_Sharp0_5 { get; set; }
        public Nullable<int> Wpn_Sharp0_6 { get; set; }
        public Nullable<int> Wpn_Sharp0_7 { get; set; }
        public Nullable<int> Wpn_Sharp0 { get; set; }
        public Nullable<int> Wpn_Sharp1_1 { get; set; }
        public Nullable<int> Wpn_Sharp1_2 { get; set; }
        public Nullable<int> Wpn_Sharp1_3 { get; set; }
        public Nullable<int> Wpn_Sharp1_4 { get; set; }
        public Nullable<int> Wpn_Sharp1_5 { get; set; }
        public Nullable<int> Wpn_Sharp1_6 { get; set; }
        public Nullable<int> Wpn_Sharp1_7 { get; set; }
        public Nullable<int> Wpn_Sharp1 { get; set; }
        public Nullable<int> Wpn_GLShotType_ID { get; set; }
        public Nullable<int> Wpn_SAPhial_ID { get; set; }
        public Nullable<int> Wpn_HHNote1_ID { get; set; }
        public Nullable<int> Wpn_HHNote2_ID { get; set; }
        public Nullable<int> Wpn_HHNote3_ID { get; set; }
        public Nullable<int> Wpn_GunReloadSpd_ID { get; set; }
        public Nullable<int> Wpn_GunSteadiness_ID { get; set; }
        public Nullable<int> Wpn_GunRecoil_ID { get; set; }
        public Nullable<int> Wpn_BowArcShot_ID { get; set; }
        public Nullable<int> Wpn_BowShotType1_ID { get; set; }
        public Nullable<int> Wpn_BowShotType2_ID { get; set; }
        public Nullable<int> Wpn_BowShotType3_ID { get; set; }
        public Nullable<int> Wpn_BowShotType4_ID { get; set; }
    
        public virtual ICollection<DB_Itm_Wpn> DB_Itm_Wpn { get; set; }
        public virtual ID_Wpn_Name ID_Wpn_Name { get; set; }
    }
}

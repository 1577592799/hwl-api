//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HWL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_group
    {
        public int id { get; set; }
        public string group_guid { get; set; }
        public string group_name { get; set; }
        public int group_user_count { get; set; }
        public string group_note { get; set; }
        public int build_user_id { get; set; }
        public System.DateTime build_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HWL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_user
    {
        public int id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string head_image { get; set; }
        public string life_notes { get; set; }
        public HWL.Entity.UserSex sex { get; set; }
        public HWL.Entity.UserStatus status { get; set; }
        public string circle_back_image { get; set; }
        public int register_country { get; set; }
        public int register_province { get; set; }
        public int register_city { get; set; }
        public int register_district { get; set; }
        public System.DateTime register_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
    }
}

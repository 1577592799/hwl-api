﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HWLEntities : DbContext
    {
        public HWLEntities()
            : base("name=HWLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<t_admin> t_admin { get; set; }
        public virtual DbSet<t_user> t_user { get; set; }
        public virtual DbSet<t_user_code> t_user_code { get; set; }
        public virtual DbSet<t_city> t_city { get; set; }
        public virtual DbSet<t_country> t_country { get; set; }
        public virtual DbSet<t_district> t_district { get; set; }
        public virtual DbSet<t_province> t_province { get; set; }
        public virtual DbSet<t_user_pos> t_user_pos { get; set; }
        public virtual DbSet<t_user_friend> t_user_friend { get; set; }
        public virtual DbSet<t_near_circle_comment> t_near_circle_comment { get; set; }
        public virtual DbSet<t_near_circle_like> t_near_circle_like { get; set; }
        public virtual DbSet<t_circle> t_circle { get; set; }
        public virtual DbSet<t_circle_comment> t_circle_comment { get; set; }
        public virtual DbSet<t_circle_image> t_circle_image { get; set; }
        public virtual DbSet<t_circle_like> t_circle_like { get; set; }
        public virtual DbSet<t_near_circle> t_near_circle { get; set; }
        public virtual DbSet<t_near_circle_image> t_near_circle_image { get; set; }
        public virtual DbSet<t_group> t_group { get; set; }
        public virtual DbSet<t_group_user> t_group_user { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASM.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Training_managementEntities : DbContext
    {
        public Training_managementEntities()
            : base("name=Training_managementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category_Course> Category_Course { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Profile_User> Profile_User { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<User_Account> User_Account { get; set; }
    }
}

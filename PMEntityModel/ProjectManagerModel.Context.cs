﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMEntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjectManagementEntities : DbContext
    {
        public ProjectManagementEntities()
            : base("name=ProjectManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ResourceCategory> ResourceCategories { get; set; }
        public virtual DbSet<TaskResource> TaskResources { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Work> Works { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}

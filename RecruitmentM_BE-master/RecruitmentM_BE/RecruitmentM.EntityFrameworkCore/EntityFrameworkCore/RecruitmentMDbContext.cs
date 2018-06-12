using Microsoft.EntityFrameworkCore;
using RecruitmentM.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentM.EntityFrameworkCore
{
    public class RecruitmentMDbContext : DbContext
    {
        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<BillInfo> BillInfo { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }

        public virtual DbSet<Bowsers> Bowsers { get; set; }

        public RecruitmentMDbContext(DbContextOptions<RecruitmentMDbContext> options)
            : base(options)
        {

        }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupB01_BCIC.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupB01_BCIC.Database
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<GroupB01_BCIC.Models.Users> Users { get; set; }
        public DbSet<GroupB01_BCIC.Models.Actor> Actor { get; set; }
        public DbSet<GroupB01_BCIC.Models.Admin> Admin { get; set; }
        public DbSet<GroupB01_BCIC.Models.Register> Register { get; set; }
        public DbSet<GroupB01_BCIC.Models.PermanentTeacher> PermanentTeacher { get; set; }
        public DbSet<GroupB01_BCIC.Models.PartTimeTeacher> PartTimeTeacher { get; set; }
        public DbSet<GroupB01_BCIC.Models.TeacherAccount> TeacherAccount { get; set; }
        public DbSet<GroupB01_BCIC.Models.BanArtStudent> BanArtStudent { get; set; }
        public DbSet<GroupB01_BCIC.Models.BanComStudent> BanComStudent { get; set; }
        public DbSet<GroupB01_BCIC.Models.BanSciStudent> BanSciStudent { get; set; }
        public DbSet<GroupB01_BCIC.Models.EngArtStudent> EngArtStudent { get; set; }
        public DbSet<GroupB01_BCIC.Models.EngComStudent> EngComStudent { get; set; }
        public DbSet<GroupB01_BCIC.Models.EngSciStudent> EngSciStudent { get; set; }
        public DbSet<GroupB01_BCIC.Models.Student> Student { get; set; }
        public DbSet<GroupB01_BCIC.Models.StudentAccount> StudentAccount { get; set; }
        public DbSet<GroupB01_BCIC.Models.Admission> Admission { get; set; }
        public DbSet<GroupB01_BCIC.Models.StudentPayment> StudentPayment { get; set; }
        public DbSet<GroupB01_BCIC.Models.IncomeSource> IncomeSource { get; set; }
        public DbSet<GroupB01_BCIC.Models.InstituteCost> InstituteCost { get; set; }
        
    }
}

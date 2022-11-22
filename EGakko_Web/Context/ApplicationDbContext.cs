using EGakko_Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGakko_DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }


        public DbSet<StudyField> StudyFields { get; set; }
        public DbSet<FieldSubject> FieldSubjects { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<StudentAttendance> StudentAttendances { get; set; }


        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
       
        public DbSet<ClassRoomLocation> Locations { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<ActivityEvaluation> ActivityEvaluations { get; set; }



       


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           

            builder.Entity<Teacher>()
                .Property(x => x.Salary).HasColumnType("decimal(18,4)");
            
            builder.Entity<Result>()
                .Property(x => x.TotalScore).HasColumnType("decimal(18,4)");
        }
       //private async Task CreateRoles(IServiceProvider serviceProvider)
       // {
       //     RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
       //     ApplicationDbContext context = serviceProvider.GetRequiredService<ApplicationDbContext>();

       //     IdentityResult result;

       //     bool rolecheck = await roleManager.RoleExistsAsync("admin");
       //     if (!rolecheck)
       //         result = await roleManager.CreateAsync(new IdentityRole("admin"));

       //     rolecheck = await roleManager.RoleExistsAsync("teacher");
       //     if (!rolecheck)
       //         result = await roleManager.CreateAsync(new IdentityRole("teacher"));

       //     rolecheck = await roleManager.RoleExistsAsync("student");
       //     if (!rolecheck)
       //         result = await roleManager.CreateAsync(new IdentityRole("student"));

       //     context.SaveChanges();
       // }
    }
}

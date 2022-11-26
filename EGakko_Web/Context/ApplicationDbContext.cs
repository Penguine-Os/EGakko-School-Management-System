using EGakko_Models;
using EGakko_Web.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis;
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
        public ApplicationDbContext()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }


        public DbSet<StudyField> StudyFields { get; set; }
        public DbSet<FieldSubject> FieldSubjects { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        

        public DbSet<Attendance> Attendances { get; set; }
      


        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
       
        public DbSet<ClassRoomLocation> Locations { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<ActivityEvaluation> ActivityEvaluations { get; set; }



       


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Seed();

            builder.Entity<Teacher>()
                .Property(x => x.Salary).HasColumnType("decimal(18,4)");
            builder.Entity<Result>()
                .Property(x => x.TotalScore).HasColumnType("decimal(18,4)");


            #region Student + Result + ActivityEvaluation
            builder.Entity<Result>()
                 .HasKey(fk => new { fk.StudentId, fk.EvaluationId });

            builder.Entity<Result>()
                .HasOne(s => s.Student)
                .WithMany(ss => ss.Results)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Result>()
                .HasOne(a => a.ActivityEvaluation)
                .WithMany(aa => aa.Results)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Student + StudyField
            builder.Entity<Student>()
                .HasOne(sf => sf.Field)
                .WithMany(ff => ff.Students)
                .HasForeignKey(sf => sf.FieldId);
            #endregion

            #region StudyField + FieldSubject + Subject 
            //builder.Entity<FieldSubject>()
            //    .HasKey(fk => new { fk.FieldId, fk.SubjectId });

            //builder.Entity<FieldSubject>()
            //    .HasOne(f => f.Field)
            //    .WithMany(fs => fs.FieldSubjects);
            //builder.Entity<FieldSubject>()
            //    .HasOne(ss => ss.Subject)
            //    .WithMany(fs => fs.FieldSubjects);
            #endregion

            #region ActivityEvaluation + Teacher
            builder.Entity<ActivityEvaluation>()
                .HasOne(c => c.Teacher)
                .WithMany(x => x.ActivityEvaluations);
            #endregion

            #region Teacher + TeacherSubject + Subject
            builder.Entity<TeacherSubject>()
                .HasKey(fk => new { fk.SubjectId, fk.TeacherId });

            builder.Entity<TeacherSubject>()
                .HasOne(ss => ss.Subject)
                .WithMany(ts => ts.TeacherSubjects);
            
            builder.Entity<TeacherSubject>()
                .HasOne(tt => tt.Teacher)
                .WithMany(ts => ts.Subjects);
            #endregion

            #region FieldSubject + ClassSchedule + Class
            builder.Entity<ClassRoomLocation>()
                .HasMany(l => l.ClassSchedules)
                .WithOne(lc => lc.Location);

            builder.Entity<ClassSchedule>()
                .HasKey(fk => new { fk.FieldSubjectId, fk.ClassId });

            builder.Entity<ClassSchedule>()
                .HasOne(c => c.Class)
                .WithMany(ts => ts.ClassSchedules);
            builder.Entity<ClassSchedule>()
                .HasOne(fs => fs.FieldSubject)
                .WithMany(fc => fc.ClassSchedules);
            #endregion
        }


    }
}

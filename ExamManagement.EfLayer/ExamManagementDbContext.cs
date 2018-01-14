using ExamManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManagement.EfLayer
{
    public class ExamManagementDbContext:DbContext
    {
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Option> Option { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonsExam> PersonsExam { get; set; }
        public DbSet<Answer> Answer { get; set; }

        public ExamManagementDbContext() : base("Data Source = UCHIHA; Initial Catalog = Deneme; Integrated Security = True")
        {
            Database.SetInitializer<ExamManagementDbContext>(new DropCreateDatabaseAlways<ExamManagementDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasMany(p => p.personExam).WithRequired(pe => pe.Person);
            modelBuilder.Entity<Exam>().HasMany(e => e.PersonsExam).WithRequired(pe => pe.Exam);
            modelBuilder.Entity<Exam>().HasMany(e => e.Questions).WithRequired(q => q.Exam);
            modelBuilder.Entity<Question>().HasMany(q => q.Options).WithRequired(o => o.question);
            modelBuilder.Entity<PersonsExam>().HasMany(pe => pe.Answers).WithRequired(a => a.PersonsExam);

            modelBuilder.Entity<Person>().Property(p => p.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.Surname).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.UserName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.Password).HasMaxLength(50).IsRequired();


            modelBuilder.Entity<Exam>().Property(p => p.Description).HasMaxLength(500).IsOptional();
            modelBuilder.Entity<Exam>().Property(p => p.Title).HasMaxLength(200).IsRequired();

            modelBuilder.Entity<Option>().Property(op => op.text).HasMaxLength(200).IsRequired();

            //how to keep correct answer in database? !!Unsolved!!
            modelBuilder.Entity<Question>().Property(q => q.CorrectAnswer).IsRequired();
            modelBuilder.Entity<Question>().Property(q => q.Text).HasMaxLength(500).IsRequired();

            //How to keep Enum type in database ? !!Unsolved!!
            //modelBuilder.Entity<PersonsExam>().Property(pe => pe.Status);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            base.OnModelCreating(modelBuilder);
        }

    }
}

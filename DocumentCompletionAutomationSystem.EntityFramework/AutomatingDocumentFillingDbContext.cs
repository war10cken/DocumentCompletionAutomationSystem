using AutomatingDocumentFilling.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AutomatingDocumentFilling.EntityFramework
{
    public class AutomatingDocumentFillingDbContext : DbContext
    {
        public DbSet<AcademicDiscipline> AcademicDisciplines { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<FormOfEducation> FormOfEducations { get; set; }
        public DbSet<GeneralCompetence> GeneralCompetences { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<ProfessionalCompetence> ProfessionalCompetences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Speciality> Specialities { get; set; }

        public AutomatingDocumentFillingDbContext(DbContextOptions options) : base(options) { }
    }
}
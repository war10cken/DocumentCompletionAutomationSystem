using DocumentCompletionAutomationSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DocumentCompletionAutomationSystem.EntityFramework
{
    public class DocumentCompletionAutomationSystemDbContext : DbContext
    {
        public DbSet<AcademicDiscipline> AcademicDisciplines { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<FormOfEducation> FormOfEducations { get; set; }
        public DbSet<GeneralCompetence> GeneralCompetences { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<ProfessionalCompetence> ProfessionalCompetences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Speciality> Specialities { get; set; }

        public DocumentCompletionAutomationSystemDbContext(DbContextOptions options) : base(options) { }
    }
}
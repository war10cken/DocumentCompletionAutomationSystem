using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AutomatingDocumentFilling.EntityFramework
{
    public class AutomatingDocumentFillingDbContextFactory :
        IDesignTimeDbContextFactory<AutomatingDocumentFillingDbContext>
    {
        public AutomatingDocumentFillingDbContext CreateDbContext(string[] args = null!)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AutomatingDocumentFillingDbContext>();
            optionsBuilder
               .UseSqlServer(@"Server=DESKTOP-PON2VF7\SQLEXPRESS;Database=DocumentCompletionAutomationSystem;Trusted_Connection=True;");

            return new AutomatingDocumentFillingDbContext(optionsBuilder.Options);
        }
    }
}
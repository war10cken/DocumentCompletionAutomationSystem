using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DocumentCompletionAutomationSystem.EntityFramework
{
    public class DocumentCompletionAutomationSystemDbContextFactory :
        IDesignTimeDbContextFactory<DocumentCompletionAutomationSystemDbContext>
    {
        public DocumentCompletionAutomationSystemDbContext CreateDbContext(string[] args = null!)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DocumentCompletionAutomationSystemDbContext>();
            optionsBuilder
               .UseSqlServer(@"Server=DESKTOP-PON2VF7\SQLEXPRESS;Database=DocumentCompletionAutomationSystem;Trusted_Connection=True;");

            return new DocumentCompletionAutomationSystemDbContext(optionsBuilder.Options);
        }
    }
}
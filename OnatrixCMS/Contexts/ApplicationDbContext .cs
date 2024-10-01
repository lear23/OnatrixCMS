

using Microsoft.EntityFrameworkCore;
using OnatrixCMS.ViewModels;

namespace OnatrixCMS.Contexts;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<ContactFormViewModel> ContactForms { get; set; }
    public DbSet<RiskFormViewModel> RiskForms { get; set; }
    public DbSet<EmailViewModel> EmailForms { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<ContactFormViewModel>()
            .HasKey(cf => cf.Id); 

        modelBuilder.Entity<RiskFormViewModel>()
            .HasKey(rf => rf.Id); 

       
        modelBuilder.Entity<EmailViewModel>()
            .HasKey(ef => ef.Id);

       
    }
}

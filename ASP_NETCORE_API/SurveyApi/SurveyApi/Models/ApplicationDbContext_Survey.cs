using Microsoft.EntityFrameworkCore;

namespace SurveyApi.Models
{
    public class ApplicationDbContext_Survey:DbContext
    {
        public ApplicationDbContext_Survey(DbContextOptions<ApplicationDbContext_Survey> options) : base(options)
        {
        }


        public DbSet<Lembaga_survey> lembaga_survey { get; set; }

        //public DbSet<Food> Foods { get; set; }

        //public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Lembaga_survey>()
                .HasKey(c => c.ID_LEMBAGA);

        }





    }
}

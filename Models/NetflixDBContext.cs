using Microsoft.EntityFrameworkCore;

namespace Netflix_Api.Models
{
    public class NetflixDBContext : DbContext
    {
        public NetflixDBContext(DbContextOptions<NetflixDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlanModel>().HasData(
                new PlanModel(1, "Básico", 25.90, "Boa", "480p"), 
                new PlanModel(2, "Padrão", 39.90, "Melhor", "1080p"),
                new PlanModel(3, "Premium", 55.90, "Superior", "4K+HDR") 
            );
        }

        public DbSet<PlanModel>? Plans { get; set; }
        public DbSet<AccountModel>? Accounts { get; set; }
        public DbSet<PaymentModel>? Payments { get; set; }
    }
}

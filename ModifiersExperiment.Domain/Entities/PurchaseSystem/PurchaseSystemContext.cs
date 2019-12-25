using Microsoft.EntityFrameworkCore;

namespace ModifiersExperiment.Domain.Entities.PurchaseSystem
{
	public class PurchaseSystemContext : DbContext
	{
		public DbSet<ClaimAppeal> ClaimAppeals { get; set; }
		public DbSet<RefundAppeal> RefundAppeals { get; set; }
		public DbSet<DuplicatePurchaseAppeal> DuplicatePurchaseAppeals { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Purchase> Purchase { get; set; }
	}
}

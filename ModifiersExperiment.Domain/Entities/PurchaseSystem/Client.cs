using System.Collections.Generic;

namespace ModifiersExperiment.Domain.Entities.PurchaseSystem
{
	public class Client
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IEnumerable<Appeal> Appeals { get; set; }
		public IEnumerable<Purchase> Purchases { get; set; }
	}
}

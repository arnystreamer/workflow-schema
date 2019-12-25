namespace ModifiersExperiment.Domain.Entities.PurchaseSystem
{
	public class DuplicatePurchaseAppeal : Appeal
	{
		public int PurchaseId { get; set; }
		public Purchase Purchase { get; set; }
	}
}

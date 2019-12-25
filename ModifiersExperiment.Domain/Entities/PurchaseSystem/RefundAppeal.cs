namespace ModifiersExperiment.Domain.Entities.PurchaseSystem
{
	public class RefundAppeal : Appeal
	{
		public decimal RequestedAmount { get; set; }
		public RefundReason RefundReason { get; set; }
	}
}

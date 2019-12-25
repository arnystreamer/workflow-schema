namespace ModifiersExperiment.Domain.Entities.PurchaseSystem
{
	public class ClaimAppeal : Appeal
	{
		public string EmployeeName { get; set; }
		public int? PurchaseId { get; set; }
		public Purchase Purchase { get; set; }
	}
}

namespace ModifiersExperiment.Domain.Entities.PurchaseSystem
{
	public abstract class Appeal
	{
		public int Id { get; set; }
		public int ClientId { get; set; }
		public Client Client { get; set; }
	}
}

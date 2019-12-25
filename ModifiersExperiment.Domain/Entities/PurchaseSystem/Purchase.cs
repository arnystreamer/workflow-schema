using System;
using System.Collections.Generic;
using System.Text;

namespace ModifiersExperiment.Domain.Entities.PurchaseSystem
{
	public class Purchase
	{
		public decimal Amount { get; set; }
		public int ItemNumber { get; set; }
		public int ClientId { get; set; }
		public Client Client { get; set; }
	}
}

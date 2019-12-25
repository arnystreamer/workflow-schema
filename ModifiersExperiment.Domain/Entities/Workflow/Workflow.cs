using ModifiersExperiment.Domain.Entities.PurchaseSystem;
using System.Collections.Generic;
using System.Linq;

namespace ModifiersExperiment.Domain.Entities.Workflow
{
	public class Workflow
	{
		public IEnumerable<Step> Steps { get; set; }
	}
}

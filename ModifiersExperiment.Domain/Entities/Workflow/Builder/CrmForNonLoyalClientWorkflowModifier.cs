using System.Linq;
using ModifiersExperiment.Domain.Entities.PurchaseSystem;

namespace ModifiersExperiment.Domain.Entities.Workflow.Builder
{
	public class CrmForNonLoyalClientWorkflowModifier : AddStepWorkflowModifier
	{
		public override Step GetStep(Appeal appeal)
		{
			var clientAppealsCount = appeal.Client.Appeals?.Count() ?? 0;
			var clientPurchasesCount = appeal.Client.Purchases?.Count() ?? 0;

			var isLoyalClient = clientPurchasesCount > clientAppealsCount;

			return !isLoyalClient ? new Step(Step.Role.Crm, false) : null;
		}
	}
}

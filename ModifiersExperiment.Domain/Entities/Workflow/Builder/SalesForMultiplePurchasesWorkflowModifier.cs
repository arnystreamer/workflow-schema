using ModifiersExperiment.Domain.Entities.PurchaseSystem;
using System.Linq;

namespace ModifiersExperiment.Domain.Entities.Workflow.Builder
{
	public class SalesForMultiplePurchasesWorkflowModifier : AddStepWorkflowModifier
	{
		public override Step GetStep(Appeal appeal)
		{
			var duplicatePurchaseAppeal = appeal as DuplicatePurchaseAppeal;

			if (duplicatePurchaseAppeal == null)
				return null;

			var purchasesCount = appeal.Client.Purchases?.Count(p => p.ItemNumber == duplicatePurchaseAppeal.Purchase.ItemNumber) ?? 0;

			var isMultiplePurchases = purchasesCount > 3;

			if (isMultiplePurchases)
				return new Step(Step.Role.Sales, false);
			else
				return null;
		}
	}
}

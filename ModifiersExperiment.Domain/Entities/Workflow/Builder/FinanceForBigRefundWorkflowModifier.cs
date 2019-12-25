using ModifiersExperiment.Domain.Entities.PurchaseSystem;

namespace ModifiersExperiment.Domain.Entities.Workflow.Builder
{
	public class FinanceForBigRefundWorkflowModifier : AddStepWorkflowModifier
	{
		public override Step GetStep(Appeal appeal)
		{
			var refundAppeal = appeal as RefundAppeal;

			if (refundAppeal == null)
				return null;

			if (refundAppeal.RequestedAmount > 100)
				return new Step(Step.Role.Finance, true);
			else
				return null;
		}
	}
}

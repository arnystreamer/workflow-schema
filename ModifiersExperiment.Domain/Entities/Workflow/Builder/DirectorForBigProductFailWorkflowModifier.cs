using System;
using System.Collections.Generic;
using System.Text;
using ModifiersExperiment.Domain.Entities.PurchaseSystem;

namespace ModifiersExperiment.Domain.Entities.Workflow.Builder
{
	public class DirectorForBigProductFailWorkflowModifier : AddStepWorkflowModifier
	{
		public override Step GetStep(Appeal appeal)
		{
			var refundAppeal = appeal as RefundAppeal;

			if (refundAppeal == null)
				return null;

			if (refundAppeal.RefundReason == RefundReason.ReceivedBroken && refundAppeal.RequestedAmount > 100)
				return new Step(Step.Role.Director, true);
			else
				return null;
		}
	}
}

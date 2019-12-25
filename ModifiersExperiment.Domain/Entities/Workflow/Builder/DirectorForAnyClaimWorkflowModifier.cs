using System;
using ModifiersExperiment.Domain.Entities.PurchaseSystem;

namespace ModifiersExperiment.Domain.Entities.Workflow.Builder
{
	public class DirectorForAnyClaimWorkflowModifier : GeneralConditionAddStepWorkflowModifier<ClaimAppeal>
	{
		public DirectorForAnyClaimWorkflowModifier()
			: base(new Step(Step.Role.Director, true))
		{

		}
	}
}

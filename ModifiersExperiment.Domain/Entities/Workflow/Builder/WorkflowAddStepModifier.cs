using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModifiersExperiment.Domain.Entities.PurchaseSystem;

namespace ModifiersExperiment.Domain.Entities.Workflow.Builder
{
	public abstract class AddStepWorkflowModifier : IWorkflowModifier
	{
		public abstract Step GetStep(Appeal appeal);

		public IEnumerable<Step> Modify(IEnumerable<Step> steps, Appeal appeal)
		{
			var step = GetStep(appeal);

			if (step == null)
				return steps;

			var alreadyExistingStep = steps.SingleOrDefault(s => s.EmployeeRole == step.EmployeeRole);
			if (alreadyExistingStep == null)
				return steps.Union(new[] { step });

			alreadyExistingStep.CanReject = alreadyExistingStep.CanReject || step.CanReject;
			return steps;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using ModifiersExperiment.Domain.Entities.PurchaseSystem;

namespace ModifiersExperiment.Domain.Entities.Workflow.Builder
{
	public class GeneralConditionAddStepWorkflowModifier<TAppeal> : AddStepWorkflowModifier
		where TAppeal: Appeal
	{
		private readonly Func<TAppeal, bool> predicate;
		private readonly Step step;

		public GeneralConditionAddStepWorkflowModifier(
				Func<TAppeal, bool> predicate,
				Step step)
		{
			this.predicate = predicate;
			this.step = step;
		}

		public GeneralConditionAddStepWorkflowModifier(Step step)
			:this(a => true, step)
		{

		}

		public override Step GetStep(Appeal appeal)
		{
			var typedAppeal = appeal as TAppeal;

			if (typedAppeal == null)
				return null;

			if (predicate(typedAppeal))
				return step;
			else
				return null;
		}
	}
}

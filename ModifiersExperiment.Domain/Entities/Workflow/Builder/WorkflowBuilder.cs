using ModifiersExperiment.Domain.Entities.PurchaseSystem;
using System.Collections.Generic;
using System.Linq;

namespace ModifiersExperiment.Domain.Entities.Workflow.Builder
{
	public class WorkflowBuilder : IWorkflowBuilder
	{
		private readonly IList<IWorkflowModifier> modifiers = new List<IWorkflowModifier>();

		public void Add(IWorkflowModifier modifier)
		{
			modifiers.Add(modifier);
		}

		public Workflow BuildWorkflow(Appeal appeal)
		{
			IEnumerable<Step> steps = Enumerable.Empty<Step>();

			foreach (IWorkflowModifier modifier in modifiers)
			{
				steps = modifier.Modify(steps, appeal);
			}

			return new Workflow()
			{
				Steps = steps
			};
		}
	}
}

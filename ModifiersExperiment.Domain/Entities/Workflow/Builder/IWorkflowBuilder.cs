using ModifiersExperiment.Domain.Entities.PurchaseSystem;

namespace ModifiersExperiment.Domain.Entities.Workflow.Builder
{
	public interface IWorkflowBuilder
	{
		void Add(IWorkflowModifier modifier);
		Workflow BuildWorkflow(Appeal appeal);
	}
}

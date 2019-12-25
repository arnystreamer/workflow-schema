using ModifiersExperiment.Domain.Entities.PurchaseSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModifiersExperiment.Domain.Entities.Workflow.Builder
{
	public interface IWorkflowModifier
	{
		IEnumerable<Step> Modify(IEnumerable<Step> steps, Appeal appeal);
	}
}

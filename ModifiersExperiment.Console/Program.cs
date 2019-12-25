using ModifiersExperiment.Domain.Entities.PurchaseSystem;
using ModifiersExperiment.Domain.Entities.Workflow.Builder;
using System;

namespace ModifiersExperiment.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			var builder = new WorkflowBuilder();

			builder.Add(new CrmForNonLoyalClientWorkflowModifier());
			builder.Add(new DirectorForAnyClaimWorkflowModifier());
			builder.Add(new DirectorForBigProductFailWorkflowModifier());
			builder.Add(new FinanceForBigRefundWorkflowModifier());
			builder.Add(new ProductManagerRefundWorkflowModifier());
			builder.Add(new SalesForMultiplePurchasesWorkflowModifier());

			var workflow = builder.BuildWorkflow(new ClaimAppeal()
			{
				Id = 1,
				EmployeeName = "Sales",
				ClientId = 3,
				Client = new Client()
				{
					Purchases = new[] 
					{
						new Purchase() { Amount = 2 }
					},
					Appeals = new Appeal[]
					{
						new ClaimAppeal() { Id = 1 },
						new RefundAppeal() { Id = 2 }
					}
				}
			});

			foreach (var step in workflow.Steps)
				System.Console.WriteLine(step.EmployeeRole.ToString() + " " + step.CanReject.ToString());
		}
	}
}

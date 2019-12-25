using System;
using System.Collections.Generic;
using System.Text;

namespace ModifiersExperiment.Domain.Entities.Workflow
{
	public class Step
	{
		public Role EmployeeRole { get; set; }
		public bool CanReject { get; set; }
		public enum Role
		{
			Crm = 1,
			ProductionManager = 2,
			Sales = 3,
			Finance = 4,
			Director = 100
		}

		public Step(Role employeeRole, bool canReject)
		{
			EmployeeRole = employeeRole;
			CanReject = canReject;
		}
	}
}

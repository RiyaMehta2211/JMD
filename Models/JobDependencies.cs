using System;

namespace JMD.Models
{
	public class JobDependencies
	{
		public JobDependencies()
		{

		}

		public int JobDependencyID { get; set; }
		public int DependentJobID { get; set; }
		public int DependencyDirection { get; set; }
		public string Dependency { get; set; }
		public int JobID { get; set; }
		public Jobs job { get; set; }
	}
}
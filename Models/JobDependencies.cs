using System;

namespace JMD.Models
{
	public class JobDependencies
	{
		public JobDependencies()
		{

		}
		public int DependentJobID { get; set; }
        public int JobDependencyID { get; set; }
        public int DependencyDirection { get; set; }
		public string Dependency { get; set; }
	}
}
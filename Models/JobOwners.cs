using System;

namespace JMD
{
	public class JobOwners
	{
		public JobOwners()
		{

		}

		public int JobOwnerID { get; set; }
		public string JobOwnerName { get; set; }
		public int JobID { get; set; }
		public Job job { get; set; }
	}
}
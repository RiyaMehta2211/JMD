using System;

namespace JMD.Models
{
	public class Jobs
	{
		public Jobs()
		{

		}

		public int JobId { get; set; }
		public string JobType { get; set; }
		public string JobName { get; set; }
		public string JobFrequency { get; set; }
	}
}
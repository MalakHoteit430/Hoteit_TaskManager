using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
	public class Task
	{
		public string Name { get; set; }
		public bool IsDone { get; set; }

		public Task(string name) {
			Name = name;
			IsDone = false;

		}

	}
}

using System;
using System.Collections.Generic;

namespace ClassTracker.Models
{
	public class Assignment
	{
		public virtual Guid ID {
			get;
			set;
		}
		public virtual string Title {
			get;
			set;
		}
		public virtual string Description {
			get;
			set;
		}
		public virtual int Weight {
			get;
			set;
		}
		public virtual int PossiblePoints {
			get;
			set;
		}
		public virtual ICollection<File> AssignmentFiles {
			get;
			set;
		}
	}
}


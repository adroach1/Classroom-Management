using System;
using System.Collections.Generic;

namespace ClassTracker
{
	public class Exam
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
		public virtual int PointsPossible {
			get;
			set;
		}
		public virtual ICollection<File> ExamFiles {
			get;
			set;
		}
	}
}


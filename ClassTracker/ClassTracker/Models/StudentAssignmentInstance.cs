using System;
using System.Collections.Generic;

namespace ClassTracker.Models
{
	public class StudentAssignmentInstance
	{
		public virtual Guid ID {
			get;
			set;
		}
		public virtual int PointsAwarded {
			get;
			set;
		}
		public virtual string StudentNotes {
			get;
			set;
		}
		public virtual string InstructorNotes {
			get;
			set;
		}
		public virtual Assignment Assignment {
			get;
			set;
		}
		public virtual ICollection<File> AssignmentSubmission {
			get;
			set;
		}
	}
}


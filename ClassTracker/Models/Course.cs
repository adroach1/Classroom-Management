using System;
namespace ClassTracker
{
	public class Course
	{
		public virtual Guid ID {
			get;
			set;
		}
		public virtual string Department {
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
		public virtual string CourseNumber {
			get;
			set;
		}
	}
}


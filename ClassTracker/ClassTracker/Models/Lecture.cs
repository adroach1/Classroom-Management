using System;
using System.Collections.Generic;
namespace ClassTracker.Models
{
	public class Lecture
	{
		public virtual Guid ID {
			get;
			set;
		}
		public virtual DateTime LectureDate {
			get;
			set;
		}
		public virtual string News {
			get;
			set;
		}
		public virtual ICollection<File> Slides {
			get;
			set;
		}
		public virtual ICollection<File> Notes {
			get;
			set;
		}
	}
}


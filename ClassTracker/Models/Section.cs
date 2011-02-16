using System;
using System.Collections.Generic;
namespace ClassTracker
{
	public class Section
	{
		public virtual Guid ID {
			get;
			set;
		}
		public virtual string SectionCode {
			get;
			set;
		}
		public virtual string InstructorName {
			get;
			set;
		}
		public virtual string Room {
			get;
			set;
		}
		public virtual DateTime MeetingTime {
			get;
			set;
		}
		public virtual Course Course {
			get;
			set;
		}
		public virtual DateTime SemesterBegin {
			get;
			set;
		}
		public virtual DateTime SemesterEnd {
			get;
			set;
		}
		public virtual ICollection<Student> Students {
			get;
			set;
		}
		public virtual ICollection<Assignment> Assignments {
			get;
			set;
		}
		public virtual ICollection<Exam> Exams {
			get;
			set;
		}
		public virtual ICollection<Lecture> Lectures {
			get;
			set;
		}
		public virtual ICollection<File> CourseFiles {
			get;
			set;
		}
	}
}


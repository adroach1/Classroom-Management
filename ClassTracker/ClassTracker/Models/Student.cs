using System;
using System.Collections.Generic;
namespace ClassTracker.Models
{
	public class Student
	{
		public virtual Guid ID {
			get;
			set;
		}
		public virtual string FirstName {
			get;
			set;
		}
		public virtual string LastName {
			get;
			set;
		}
		public virtual string NetworkID {
			get;
			set;
		}
		public virtual string Email {
			get;
			set;
		}
		public virtual string Phone {
			get;
			set;
		}
		public virtual ICollection<Section> Sections {
			get;
			set;
		}
	}
}


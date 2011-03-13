using System;
namespace ClassTracker.Models
{
	public class File
	{	
		public virtual Guid ID {
			get;
			set;
		}
		public virtual string Version {
			get;
			set;
		}
		public virtual DateTime Added {
			get;
			set;
		}
	}
}


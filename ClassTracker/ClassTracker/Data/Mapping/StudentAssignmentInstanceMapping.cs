using System;
using FluentNHibernate.Mapping;
using ClassTracker.Models;

namespace ClassTracker.Data
{
	public class StudentAssignmentInstanceMapping : ClassMap<StudentAssignmentInstance>
	{
		public StudentAssignmentInstanceMapping ()
		{
			Id(x => x.ID).GeneratedBy.GuidComb();
			Map(x =>x.PointsAwarded);
			Map(x => x.StudentNotes);
			Map(x => x.InstructorNotes);
			
			References(x => x.Assignment);
			
			HasMany(x => x.AssignmentSubmission);
		}
	}
}


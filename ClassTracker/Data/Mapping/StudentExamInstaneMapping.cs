using System;
using FluentNHibernate.Mapping;

namespace ClassTracker
{
	public class StudentExamInstanceMapping : ClassMap<StudentExamInstance>
	{
		public StudentExamInstanceMapping ()
		{
			Id(x => x.ID).GeneratedBy.GuidComb();
			Map(x => x.PointsAwarded);
			Map(x => x.StudentNotes);
			Map(x => x.InstructorNotes);
			
			References(x => x.Exam);
			
			HasMany(x => x.ExamSubmission);
		}
	}
}


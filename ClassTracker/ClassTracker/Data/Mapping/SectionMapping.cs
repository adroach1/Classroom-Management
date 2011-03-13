using System;
using FluentNHibernate.Mapping;
using ClassTracker.Models;

namespace ClassTracker.Data
{
	public class SectionMapping : ClassMap<Section>
	{
		public SectionMapping ()
		{
			Id(x => x.ID).GeneratedBy.GuidComb();
			Map(x => x.InstructorName);
			Map(x => x.SectionCode);
			Map(x => x.MeetingTime);
			Map(x => x.Room);
			Map(x => x.SemesterBegin);
			Map(x => x.SemesterEnd);
			
			References(x => x.Course);
			
			HasMany(x => x.Students);
			HasMany(x => x.Assignments);
			HasMany(x => x.Exams);
			HasMany(x => x.Lectures);
			HasMany(x => x.CourseFiles);
		}
	}
}


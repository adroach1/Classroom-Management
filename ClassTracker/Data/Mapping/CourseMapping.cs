using System;
using FluentNHibernate.Mapping;

namespace ClassTracker
{
	public class CourseMapping : ClassMap<Course>
	{
		public CourseMapping ()
		{
			Id(x => x.ID).GeneratedBy.GuidComb();
			Map(x => x.Title).Not.Nullable();
			Map(x => x.Description);
			Map(x => x.Department).Not.Nullable();
			Map(x => x.CourseNumber).Not.Nullable();
		}
	}
}


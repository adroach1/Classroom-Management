using System;
using FluentNHibernate.Mapping;

namespace ClassTracker
{
	public class ExamMapping : ClassMap<Exam>
	{
		public ExamMapping ()
		{
			Id(x => x.ID).GeneratedBy.GuidComb();
			Map(x => x.Title).Not.Nullable();
			Map(x => x.Description);
			Map(x => x.Weight);
			Map(x => x.PointsPossible).Not.Nullable();
			
			HasMany(x => x.ExamFiles);
		}
	}
}


using System;
using FluentNHibernate.Mapping;
using ClassTracker.Models;

namespace ClassTracker.Data
{
	public class LectureMapping : ClassMap<Lecture>
	{
		public LectureMapping ()
		{
			Id(x => x.ID).GeneratedBy.GuidComb();
			Map(x => x.News);
			Map(x => x.LectureDate).Not.Nullable();
			
			HasMany(x => x.Notes);
			HasMany(x => x.Slides);
		}
	}
}


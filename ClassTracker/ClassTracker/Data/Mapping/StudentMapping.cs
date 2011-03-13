using System;
using FluentNHibernate.Mapping;
using ClassTracker.Models;

namespace ClassTracker.Data
{
	public class StudentMapping : ClassMap<Student>
	{
		public StudentMapping ()
		{
			Id(x => x.ID).GeneratedBy.GuidComb();
			Map(x => x.FirstName).Not.Nullable();
			Map(x => x.LastName).Not.Nullable();
			Map(x => x.NetworkID);
			Map(x => x.Phone);
			Map(x => x.Email);
			
			HasMany(x => x.Sections);
		}
	}
}


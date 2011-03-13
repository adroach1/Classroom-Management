using System;
using FluentNHibernate.Mapping;
using ClassTracker.Models;

namespace ClassTracker.Data
{
	public class AssignmentMapping : ClassMap<Assignment>
	{
		public AssignmentMapping ()
		{
			Id(x => x.ID).GeneratedBy.GuidComb();
			Map(x => x.Title).Not.Nullable();
			Map(x => x.Description);
			Map(x => x.Weight);
			Map(x => x.PossiblePoints).Not.Nullable();
			
			HasMany(x => x.AssignmentFiles);
		}
	}
}


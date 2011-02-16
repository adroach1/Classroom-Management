using System;
using FluentNHibernate.Mapping;

namespace ClassTracker
{
	public class FileMapping : ClassMap<File>
	{
		public FileMapping ()
		{
			Id(x => x.ID).GeneratedBy.GuidComb();
			Map(x => x.Version);
			Map(x => x.Added);
		}
	}
}


using System;
using System.Runtime.CompilerServices;
using Ardalis.GuardClauses;

namespace Cinema.Common.Entities.CinemaService
{
	public class Hall : BaseEntity
	{
		public string Name { get; set; }
		public HallStatus Status { get; set; }
		public Hall()
		{
		}

		public Hall(string name, HallStatus status)
		{
			this.Name = name;
			this.Status = status;
		}

		public void UpdateHall(string name, HallStatus status)
		{
			this.Name = GuardClauseExtensions.NullOrEmpty(Guard.Against, name, "name", null, null);
			this.Status = (HallStatus)GuardClauseExtensions.OutOfRange<int>(Guard.Against, (int)status, "status", 0, 1, null, null);
		}
	}
}

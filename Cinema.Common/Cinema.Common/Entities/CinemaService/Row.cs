using System;
using Ardalis.GuardClauses;

namespace Cinema.Common.Entities.CinemaService
{
	public class Row : BaseEntity
	{
		public new Guid Id { get; set; }

		public int Number { get; set; }

		public Guid HallId { get; set; }

		public Row()
		{
		}

		public Row(int number, Guid hallId)
		{
			this.Number = number;
			this.HallId = hallId;
		}
		public void UpdateRow(int number, Guid hallId)
		{
			this.Number = GuardClauseExtensions.NegativeOrZero(Guard.Against, number, "number", null, null);
			this.HallId = GuardClauseExtensions.NullOrEmpty(Guard.Against, new Guid?(hallId), "hallId", null, null);
		}
	}
}

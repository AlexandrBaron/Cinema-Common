using System;
using Ardalis.GuardClauses;

namespace Cinema.Common.Entities.CinemaService
{
	public class Seat : BaseEntity
	{
		public new Guid Id { get; set; }
		public int Number { get; set; }
		public Guid RowId { get; set; }

		public Seat()
		{
		}

		public Seat(int number, Guid rowId)
		{
			this.Number = number;
			this.RowId = rowId;
		}

		public void UpdateSeat(int number, Guid rowId)
		{
			this.Number = GuardClauseExtensions.NegativeOrZero(Guard.Against, number, "number", null, null);
			this.RowId = GuardClauseExtensions.NullOrEmpty(Guard.Against, new Guid?(rowId), "rowId", null, null);
		}
	}
}

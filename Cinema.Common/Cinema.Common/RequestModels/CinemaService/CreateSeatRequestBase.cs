using System;

namespace Cinema.Common.RequestModels.CinemaService
{
	public class CreateSeatRequestBase
	{
		public int Number { get; set; }
		public Guid RowId { get; set; }
	}
}

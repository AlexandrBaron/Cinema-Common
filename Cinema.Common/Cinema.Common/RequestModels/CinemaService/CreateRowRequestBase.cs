using System;

namespace Cinema.Common.RequestModels.CinemaService
{
	public class CreateRowRequestBase
	{
		public int Number { get; set; }
		public Guid HallId { get; set; }
	}
}

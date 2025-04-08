using System;
using Cinema.Common.Entities.CinemaService;

namespace Cinema.Common.RequestModels.CinemaService
{
	public class UpdateHallRequestBase
	{
		public Guid Id { get; set; }

		public HallStatus Status { get; set; }
	}
}

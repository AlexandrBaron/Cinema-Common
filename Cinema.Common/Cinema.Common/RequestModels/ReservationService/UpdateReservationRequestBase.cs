using System;
using Cinema.Common.Entities.ReservationService;

namespace Cinema.Common.RequestModels.ReservationService
{
	public class UpdateReservationRequestBase
	{
		public ReservationStatus Rs { get; set; }
		public Guid Id { get; set; }
	}
}

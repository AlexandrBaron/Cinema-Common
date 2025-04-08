using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cinema.Common.RequestModels.ReservationService
{
	public class CreateReservationRequestBase
	{
		public Guid UserId { get; set; }
		public List<Guid> SeatId { get; set; } = new List<Guid>();
		public Guid ProjectionId { get; set; }
	}
}

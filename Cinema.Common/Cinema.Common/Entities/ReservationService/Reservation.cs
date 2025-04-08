using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ardalis.GuardClauses;

namespace Cinema.Common.Entities.ReservationService
{
	public class Reservation : BaseEntity
	{
		public new Guid Id { get; set; }
		public Guid UserId { get; set; }
		public List<Guid> SeatId { get; set; } = new List<Guid>();
		public Guid ProjectionId { get; set; }
		public ReservationStatus ReservationStatus { get; set; }
		public DateTime TimeOfCreation { get; set; }

		public Reservation()
		{
		}

		public Reservation(Guid userId, List<Guid> seatId, Guid projectionId, ReservationStatus reservationStatus)
		{
			this.UserId = userId;
			this.SeatId = seatId;
			this.ProjectionId = projectionId;
			this.ReservationStatus = reservationStatus;
			this.TimeOfCreation = DateTime.Now;
		}

		public void UpdateReservation(Guid userId, List<Guid> seatId, Guid porjectionId, ReservationStatus reservationStatus)
		{
			this.UserId = GuardClauseExtensions.NullOrEmpty(Guard.Against, new Guid?(userId), "userId", null, null);
			this.SeatId = GuardClauseExtensions.Null<List<Guid>>(Guard.Against, seatId, "seatId", null, null);
			this.ProjectionId = GuardClauseExtensions.NullOrEmpty(Guard.Against, new Guid?(porjectionId), "porjectionId", null, null);
			this.ReservationStatus = (ReservationStatus)GuardClauseExtensions.OutOfRange<int>(Guard.Against, (int)reservationStatus, "reservationStatus", 0, 1, "Invalid", null);
		}
	}
}

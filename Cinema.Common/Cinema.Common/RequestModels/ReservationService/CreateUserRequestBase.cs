using System;
using System.Runtime.CompilerServices;

namespace Cinema.Common.RequestModels.ReservationService
{
	public class CreateUserRequestBase
	{
		public string Email { get; set; }
		public int PhoneNumber { get; set; }
	}
}

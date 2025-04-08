using System;
using System.Runtime.CompilerServices;
using Ardalis.GuardClauses;

namespace Cinema.Common.Entities.ReservationService
{
	public class User : BaseEntity
	{
		public new Guid Id { get; set; }
		public string Email { get; set; }
		public int PhoneNumber { get; set; }

		public User()
		{
		}

		public User(string email, int phoneNumber)
		{
			this.Email = email;
			this.PhoneNumber = phoneNumber;
		}

		public void UpdateUser(string email, int phoneNumber)
		{
			this.Email = GuardClauseExtensions.Null<string>(Guard.Against, email, "email", null, null);
		}
	}
}

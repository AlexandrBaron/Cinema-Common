using System;
using Ardalis.SharedKernel;

namespace Cinema.Common.Entities
{
	public class BaseEntity : IAggregateRoot
	{
		public Guid Id { get; set; }
	}
}

using System;

namespace Cinema.Common.RequestModels.MovieService
{
	public class CreateProjectionRequestBase
	{
		public DateTime StartTime { get; set; }
		public Guid MovieId { get; set; }
		public Guid HallId { get; set; }
	}
}

using System;

namespace Cinema.Common.RequestModels.MovieService
{
	public class UpdateProjectionRequest
	{
		public Guid ProjectionId { get; set; }
		public DateTime StartTime { get; set; }
		public Guid MovieId { get; set; }
		public Guid HallId { get; set; }
	}
}

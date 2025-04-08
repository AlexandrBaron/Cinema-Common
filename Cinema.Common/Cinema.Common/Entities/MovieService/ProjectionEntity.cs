using System;

namespace Cinema.Common.Entities.MovieService
{
	public class ProjectionEntity : BaseEntity
	{
		public DateTime StartTime { get; set; }
		public Guid MovieId { get; set; }
		public Guid HallId { get; set; }

		public ProjectionEntity()
		{
		}

		public ProjectionEntity(DateTime startTime, Guid movieId, Guid hallId)
		{
			this.StartTime = startTime;
			this.MovieId = movieId;
			this.HallId = hallId;
		}

		public ProjectionEntity(Guid id, DateTime startTime, Guid movieId, Guid hallId) : this(startTime, movieId, hallId)
		{
			base.Id = id;
		}
	}
}

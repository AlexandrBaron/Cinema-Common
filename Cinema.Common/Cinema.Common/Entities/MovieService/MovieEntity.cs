using System;
using System.Runtime.CompilerServices;

namespace Cinema.Common.Entities.MovieService
{
	public class MovieEntity : BaseEntity
	{
		public required string Title { get; set; }
		public required string Description { get; set; }
		public required string Director { get; set; }
		public required string Cast { get; set; }
		public required long DurationInMinutes { get; set; }
		public bool IsPlaying { get; set; }

		public MovieEntity(string title, string description, string director, string cast, long durationInMinutes, bool isPlaying)
		{
			this.Title = title;
			this.Description = description;
			this.Director = director;
			this.Cast = cast;
			this.DurationInMinutes = durationInMinutes;
			this.IsPlaying = isPlaying;
		}

		public MovieEntity()
		{
		}

		public void UpdateMovie(string title, string description, string director, string cast, long durationInMinutes, bool isPlaying)
		{
			this.Title = title;
			this.Description = description;
			this.Director = director;
			this.Cast = cast;
			this.DurationInMinutes = durationInMinutes;
			this.IsPlaying = isPlaying;
		}
	}
}

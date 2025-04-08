using System;
using System.Runtime.CompilerServices;

namespace Cinema.Common.RequestModels.MovieService
{
	public class UpdateMovieRequestBase
	{
		public Guid MovieId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Director { get; set; }
		public string Cast { get; set; }
		public long DurationInMinutes { get; set; }
		public bool IsPlaying { get; set; }
		public UpdateMovieRequestBase()
		{
		}
	}
}

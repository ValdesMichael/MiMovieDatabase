namespace MiMovieDatabase.Models
{
    public class Show : Movie
    {
        public bool HasEnded { get; set; }
        public bool WasCancelled { get; set; }
        public int EndYear { get; set; }
        public int Seasons { get; set; }
    }
}


using System.ComponentModel.DataAnnotations;
namespace MiMovieDatabase.Models
{

    public enum MovieType
    {
        
        Action, Adventure, Comedy, Crime, Disaster, Drama, Dramedy, Documentary, Dystopian, Fantasy, Historical, Horror, Romance,
        [Display(Name = "Science Fiction")]
        ScienceFiction,
        Sitcom,Thriller, Western
    }

    public enum RatingNum
    {
        [Display(Name = "1")]
        One = 1,
        [Display(Name = "2")]
        Two = 2,
        [Display(Name = "3")]
        Three = 3,
        [Display(Name = "4")]
        Four = 4,
        [Display(Name = "5")]
        Five = 5,
        [Display(Name = "6")]
        Six = 6,
        [Display(Name = "7")]
        Seven = 7,
        [Display(Name = "8")]
        Eight = 8,
        [Display(Name = "9")]
        Nine = 9,
        [Display(Name = "10")]
        Ten = 10
    }
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Release { get; set; }
        public MovieType Genre { get; set; }
        public RatingNum Rating { get; set; }
        public string Description { get; set; }

        /*public Movie(int id, string title, int release, GenreList genre, int rating)
        {
            ID = id;
            Title = title;
            Release = release;
            Genre = new List<GenreList>();
            Rating = rating;
        }*/
    }
}

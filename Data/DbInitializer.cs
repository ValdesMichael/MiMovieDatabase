using MiMovieDatabase.Models;
    
    namespace MiMovieDatabase.Data
{
    public class DbInitializer
    {
        public static void Initialize(MovieContext context)
        {
            // Look for any students.
            if (context.Movies.Any())
            {
                return;   // database is already present.
            }

            var movies = new Movie[] //initialize a new database if one doesnt already exists yet
            {
                new Movie{Title="Midsommar",Release=2019,Genre=MovieType.Horror,Rating=RatingNum.Eight,Description="A couple travel to Sweden to visit their friend's rural hometown for its fabled midsummer festival, but what begins as an idyllic retreat quickly devolves into an increasingly violent and bizarre competition at the hands of a pagan cult."},
                new Movie{Title="The Green Knight",Release=2021,Genre=MovieType.Fantasy,Rating=RatingNum.Ten,Description="King Arthur's headstrong nephew embarks on a daring quest to confront the Green Knight, a mysterious giant who appears at Camelot. Risking his head, he sets off on an epic adventure to prove himself before his family and court."},
                new Movie{Title="Uncut Gems",Release=2019,Genre=MovieType.Thriller,Rating=RatingNum.Nine,Description="A charismatic jeweller makes a high-stakes bet that could lead to the windfall of a lifetime. In a precarious high-wire act, he must balance business, family and adversaries on all sides in pursuit of the ultimate win."},
                new Movie{Title="Mid 90s",Release=2018,Genre=MovieType.Drama,Rating=RatingNum.Seven,Description="In 1990s Los Angeles, a 13-year-old spends his summer navigating between a troubled home life and a crew of new friends he meets at a skate shop." },
                new Movie{Title="Swiss Army Man",Release=2016,Genre=MovieType.Adventure,Rating=RatingNum.Six,Description="Being stranded on a deserted island leaves young Hank bored, lonely and without hope. As a rope hangs around his neck, Hank prepares to end it all, until he suddenly spots a man laying by the shore. Unfortunately, he is dead and quite flatulent. Using the gassy body to his advantage, Hank miraculously makes it back to the mainland. However, he now finds himself lost in the wilderness, and dragging the talking corpse named Manny along for the adventure." },
                new Movie{Title="Hereditary",Release=2018,Genre=MovieType.Horror,Rating=RatingNum.Nine,Description="When the matriarch of the Graham family passes away, her daughter and grandchildren begin to unravel cryptic and increasingly terrifying secrets about their ancestry, trying to outrun the sinister fate they have inherited." },
                new Movie{Title="The Lobster",Release=2015,Genre=MovieType.Dystopian,Rating=RatingNum.Six,Description="In a dystopian society, single people must enter into a romantic relationship within a strict time limit of 45 days or be transformed into an animal of their choice." },
                new Movie{Title="Lamb",Release=2021,Genre=MovieType.Horror,Rating=RatingNum.Four,Description="In rural Iceland, a childless couple discover a strange and unnatural newborn in their sheep barn. They decide to raise her as their own, but sinister forces are determined to return the creature to the wilderness that birthed her." },
                new Movie{Title="The Disaster Artist",Release=2017,Genre=MovieType.Dramedy,Rating=RatingNum.Five,Description="The incredible true story of aspiring filmmaker and Hollywood outsider Tommy Wiseau as he and his best friend defiantly pursue their dreams and embark on the hilarious odyssey of making the now-infamous, cult classic The Room." },
                new Movie{Title="The Lighthouse",Release=2018,Genre=MovieType.Thriller,Rating=RatingNum.Eight,Description="Two lighthouse keepers try to maintain their sanity while living on a remote and mysterious New England island in the 1890s." },
            };

            context.Movies.AddRange(movies);
            context.SaveChanges();
        }
    }
}

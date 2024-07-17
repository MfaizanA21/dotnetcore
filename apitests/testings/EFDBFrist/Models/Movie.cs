using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class Movie
    {
        public Movie()
        {
            MovieActors = new HashSet<MovieActor>();
            Reviews = new HashSet<Review>();
        }

        public int MovieId { get; set; }
        public string Title { get; set; } = null!;
        public int ReleaseYear { get; set; }
        public int? GenreId { get; set; }
        public int? DirectorId { get; set; }

        public virtual Director? Director { get; set; }
        public virtual Genre? Genre { get; set; }
        public virtual ICollection<MovieActor> MovieActors { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}

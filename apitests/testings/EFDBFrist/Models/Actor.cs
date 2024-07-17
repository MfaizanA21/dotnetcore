using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class Actor
    {
        public Actor()
        {
            MovieActors = new HashSet<MovieActor>();
        }

        public int ActorId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime Birthdate { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}

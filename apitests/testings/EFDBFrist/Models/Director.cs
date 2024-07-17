using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EFDBFrist.Models
{
    public partial class Director
    {
        public Director()
        {
            Movies = new HashSet<Movie>();
        }

        public int DirectorId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        [JsonIgnore]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EFDBFrist.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int? MovieId { get; set; }
        public string? ReviewerName { get; set; }
        public decimal? Rating { get; set; }
        public string? ReviewText { get; set; }
        public DateTime? ReviewDate { get; set; }
        [JsonIgnore]
        public virtual Movie? Movie { get; set; }
    }
}

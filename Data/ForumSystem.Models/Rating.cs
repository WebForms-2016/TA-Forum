namespace ForumSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 5)]
        public double Rate { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
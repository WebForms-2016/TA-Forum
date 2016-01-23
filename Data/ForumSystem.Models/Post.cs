namespace ForumSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(2000)]
        public string Text { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int TreadId { get; set; }

        public Thread Thread { get; set; }
    }
}
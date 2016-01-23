namespace ForumSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Thread
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public Visibility Visibility { get; set; }
        
        public int UserId { get; set; }

        public User User { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
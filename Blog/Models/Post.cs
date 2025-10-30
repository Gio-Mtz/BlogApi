using System;
using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [MaxLength(200)]
        public required string Title { get; set; }

        [Required]
        public required string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public string? ImageBase64 { get; set; }

        public string[]? Tags { get; set; }

        public string Slug { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class CommentDto
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Title must be five characters.")]
        [MaxLength(280, ErrorMessage = "Title cannot be longer than 280 chacters")]
        public string Title {get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "Content must be five characters.")]
        [MaxLength(280, ErrorMessage = "Content cannot be longer than 280 chacters")]
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId  {get; set; }
        //navigate property
    }
}
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Blog
    {

        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

    }
}
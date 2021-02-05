using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFour.Data
{
    class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public int MyProperty { get; set; }
        public Guid Author { get; set; }

        [ForeignKey(nameof(Post))]
        public string Reply { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

    }
}

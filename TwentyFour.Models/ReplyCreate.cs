using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFour.Models
{
    public class ReplyCreate : CommentCreate
    {
        //Note this inherits from CommentCreate
        [Required]
        public int ReplyCommentID { get; set; }

    }
}

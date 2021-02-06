using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFour.Data;
using TwentyFour.Models;

namespace TwentyFour.Services
{
    public class CommentService
    {
        private readonly Guid _userId;

        public CommentService(Guid userid)
        {
            _userId = userid;
        }
        public bool CreateComment(CommentCreate model)
        {
            var entity =
                new Comment()
                {
                    Author = _userId,
                    Text = model.Text,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comment.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<CommentListItem> GetNotes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Comment
                        .Where(e => e.Author == _userId)
                        .Select(
                            e =>
                                new CommentListItem
                                {
                                    Author = e.Author,
                                    Text = e.Text,
                                }
                        );

                return query.ToArray();
            }
        }
    }
}

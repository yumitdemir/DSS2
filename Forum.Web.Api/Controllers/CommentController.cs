using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Forum.Application.Services;
using Forum.Domain.Models;

namespace Forum.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly CommentService _commentService;

        public CommentController(CommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<IEnumerable<Comment>> Get()
        {
            return await _commentService.GetAllCommentsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Comment>> Get(long id)
        {
            var comment = await _commentService.GetCommentByIdAsync(id);

            if (comment == null)
            {
                return NotFound();
            }

            return comment;
        }

        [HttpPost]
        public async Task<ActionResult<Comment>> Post([FromBody] Comment comment)
        {
            var createdComment = await _commentService.AddCommentAsync(comment);

            return CreatedAtAction(nameof(Get), new { id = createdComment.Id }, createdComment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] Comment comment)
        {
            if (id != comment.Id)
            {
                return BadRequest();
            }

            await _commentService.UpdateCommentAsync(comment);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _commentService.DeleteCommentAsync(id);

            return NoContent();
        }
    }
}
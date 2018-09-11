using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.api
{
    [Route("api/posts/{postKey}/comments")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly BlogDataContext _db;

        public CommentsController(BlogDataContext db)
        {
            _db = db;
        }
        // GET: api/Comments
        [HttpGet]
        public IQueryable<Comment> Get(string postKey)
        {
            return _db.Comments.Where(x=>x.Post.Key == postKey);
        }

        // GET: api/Comments/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Comments
        [HttpPost]
        public Comment Post(string postKey, [FromBody] Comment comment)
        {
            var post = _db.Posts.FirstOrDefault(x => x.Key == postKey);
            if (post == null)
                return null;

            comment.Post = post;
            comment.Posted = DateTime.Now;
            comment.Author = User.Identity.Name;

            _db.Comments.Add(comment);
            _db.SaveChanges();

            return comment;
        }

        // PUT: api/Comments/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

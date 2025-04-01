using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        // Sample user data (in-memory, should be replaced with a database)
        private static readonly List<string> users = new() { "Alice", "Bob", "Charlie" };

        // GET: api/users
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(users);
        }

        // GET: api/users/{id}
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // // POST: api/users
        // [HttpPost]
        // public IActionResult CreateUser([FromBody] string username)
        // {
        //     if (string.IsNullOrWhiteSpace(username))
        //         return BadRequest("Invalid username");

        //     users.Add(username);
        //     return CreatedAtAction(nameof(GetUserById), new { id = users.Count - 1 }, username);
        // }

        // DELETE: api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            if (id < 0 || id >= users.Count)
                return NotFound("User not found");

            users.RemoveAt(id);
            return NoContent();
        }
    }
}




using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using whatDo.Server.Data.Contexts;
using whatDo.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace WhatDo.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoItemsController : Controller
    {
        private readonly WhatDoDbContext _context;

        public ToDoItemsController(WhatDoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ToDoItem>>> GetToDoItems()
        {
            var toDoItems = await _context.ToDoItems.ToListAsync();
            if (toDoItems == null) return NotFound();
            return Ok(toDoItems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoItem>> GetToDoItem(int id)
        {
            var toDoItem = await _context.ToDoItems.FindAsync(id);
            if (toDoItem == null) return NotFound();
            return Ok(toDoItem);
        }

        [HttpPost]
        public async Task<ActionResult<ToDoItem>> PostToDoItem(ToDoItem toDoItem)
        {
            _context.ToDoItems.Add(toDoItem);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetToDoItem), new { id = toDoItem.Id }, toDoItem);
        }


    }
}

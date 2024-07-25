using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoService.Data;
using TodoService.Models;

namespace TodoService.Controller
{
    [Route("api/todo")]
    [ApiController]
    [Authorize]
    public class TodoItemsController:ControllerBase
    {
        
        private readonly TodoContext _context;
        private readonly IHttpClientFactory _clientFactory;
        public TodoItemsController(TodoContext context,IHttpClientFactory clientFactory){
            _context = context;
            _clientFactory=clientFactory;
        }
        private async Task<bool> ValidateTokenAsync(string token)
        {
            var client = _clientFactory.CreateClient("UserService");
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/user/validate");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            
            var response = await client.SendAsync(request);
            return response.IsSuccessStatusCode;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems(){

            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            if (!await ValidateTokenAsync(token))
            {
                return Unauthorized();
            }

            return await _context.TodoItems.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(int id){
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            if (!await ValidateTokenAsync(token))
            {
                return Unauthorized();
            }

            
            var todoItem =await _context.TodoItems.FindAsync(id);
            if(todoItem==null){
                return NotFound();
            }
            return todoItem;
        }

        [HttpPost]

        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem){
             var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            if (!await ValidateTokenAsync(token))
            {
                return Unauthorized();
            }
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTodoItem),new {id=todoItem.Id},todoItem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(int id,TodoItem todoItem){
             var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            if (!await ValidateTokenAsync(token))
            {
                return Unauthorized();
            }
            if(id!=todoItem.Id){
                return BadRequest();
            }
            _context.Entry(todoItem).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!TodoItemExists(id)){
                    return NotFound();
                }else{
                    throw;
                }  
            }
            return NoContent();
        }
        private bool TodoItemExists(int id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id){
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            if (!await ValidateTokenAsync(token))
            {
                return Unauthorized();
            }
            var todoItem = await _context.TodoItems.FindAsync(id);
            if(todoItem ==null){
                return NotFound();
            }
            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
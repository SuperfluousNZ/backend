using AutoMapper;
using DigraphyApi.Dto;
using DigraphyApi.Models;
using DigraphyApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DigraphyApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoController(ITodoRepository todoRepository, IMapper mapper) : Controller
{
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Todo>))]
    public async Task<IActionResult> GetTodos()
    {
        var todos = mapper.Map<List<TodoDto>>(await todoRepository.GetTodosAsync());

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(todos);
    }
    
    [HttpGet("{todoId}")]
    [ProducesResponseType(200, Type = typeof(Todo))]
    [ProducesResponseType(400)]
    public async Task<IActionResult> GetTodo(int todoId)
    {
        if (!(await todoRepository.TodoExistsAsync(todoId)))
            return NotFound();
        
        var todo = mapper.Map<TodoDto>(await todoRepository.GetTodoAsync(todoId));
    
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
    
        return Ok(todo);
    }
    
    [HttpPut("{todoId}")]
    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> UpdateTodo(int todoId,
        [FromBody] PutTodoDto updatedTodo)
    {
        if (!(await todoRepository.TodoExistsAsync(todoId)))
            return NotFound();

        if (!ModelState.IsValid)
            return BadRequest();
        
        var existingTodo = await todoRepository.GetTodoAsync(todoId);
        
        if (!string.IsNullOrEmpty(updatedTodo.Name))
        {
            if (existingTodo != null) existingTodo.Name = updatedTodo.Name;
        }

        if (existingTodo == null || await todoRepository.UpdateTodoAsync(existingTodo)) return NoContent();
        ModelState.AddModelError("", "Something went wrong updating todo");
        return StatusCode(500, ModelState);

    }
    
    [HttpPost("/todo")]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> CreateTodo([FromBody] TodoDto todoCreate)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var todo = mapper.Map<Todo>(todoCreate);

        if (await todoRepository.CreateTodoAsync(todo)) return NoContent();
        
        ModelState.AddModelError("", "Something went wrong while saving");
        return StatusCode(500, ModelState);

    }
    
    [HttpDelete("{todoId}")]
    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> DeleteTodo(int todoId)
    {
        var todoToDelete = await todoRepository.GetTodoAsync(todoId);
        
        if (todoToDelete == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (!await todoRepository.DeleteTodoAsync(todoToDelete))
        {
            ModelState.AddModelError("", "Something went wrong deleting the todo");
        }

        return NoContent();
    }
}
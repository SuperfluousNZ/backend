using AutoMapper;
using Digraphy.Dto;
using Digraphy.Models;
using Digraphy.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Digraphy.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoController : Controller
{
    private readonly ITodoRepository _todoRepository;
    private readonly IMapper _dtoMapper;

    public TodoController(ITodoRepository todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _dtoMapper = mapper;
    }
    
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Todo>))]
    public IActionResult GetTodos()
    {
        var todos = _dtoMapper.Map<List<TodoDto>>(_todoRepository.GetTodos());

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(todos);
    }
    
    [HttpGet("{todoId}")]
    [ProducesResponseType(200, Type = typeof(Todo))]
    [ProducesResponseType(400)]
    public IActionResult GetTodo(int todoId)
    {
        if (!_todoRepository.TodoExists(todoId))
            return NotFound();
        
        var todo = _dtoMapper.Map<TodoDto>(_todoRepository.GetTodo(todoId));
    
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
    
        return Ok(todo);
    }
    
    [HttpPut("{todoId}")]
    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public IActionResult UpdateTodo(int todoId,
        [FromBody] PutTodoDto updatedTodo)
    {
        if (updatedTodo == null)
            return BadRequest(ModelState);

        if (!_todoRepository.TodoExists(todoId))
            return NotFound();

        if (!ModelState.IsValid)
            return BadRequest();
        
        var existingTodo = _todoRepository.GetTodo(todoId);
        
        if (!string.IsNullOrEmpty(updatedTodo.Name))
        {
            existingTodo.Name = updatedTodo.Name;
        }

        if (!_todoRepository.UpdateTodo(existingTodo))
        {
            ModelState.AddModelError("", "Something went wrong updating todo");
            return StatusCode(500, ModelState);
        }

        return NoContent();
    }
    
    [HttpPost("/todo")]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public IActionResult CreateTodo([FromBody] TodoDto todoCreate)
    {
        if (todoCreate == null)
            return BadRequest(ModelState);

        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        var todoMap = _dtoMapper.Map<Todo>(todoCreate);

        if (_todoRepository.CreateTodo(todoMap)) return Ok("Successfully created");
        
        ModelState.AddModelError("", "Something went wrong while saving");
        return StatusCode(500, ModelState);

    }
    
    [HttpDelete("{todoId}")]
    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public IActionResult DeleteTodo(int todoId)
    {
        if (!_todoRepository.TodoExists(todoId))
        {
            return NotFound();
        }

        var todoToDelete = _todoRepository.GetTodo(todoId);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (!_todoRepository.DeleteTodo(todoToDelete))
        {
            ModelState.AddModelError("", "Something went wrong deleting the todo");
        }

        return NoContent();
    }
}
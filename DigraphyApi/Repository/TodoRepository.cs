using Digraphy.Data;
using Digraphy.Models;
using Digraphy.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Digraphy.Repository;

public class TodoRepository : ITodoRepository
{
    private readonly AppDbContext _context;
    
    public TodoRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public ICollection<Todo> GetTodosAsync()
    {
        return _context.Todos.OrderBy(t => t.Id).ToList();
    }

    public Todo? GetTodoAsync(int todoId)
    {
        return _context.Todos.FirstOrDefault(t => t.Id == todoId);
    }

    public bool UpdateTodoAsync(Todo todo)
    {
        _context.Update(todo);
        return SaveAsync();
    }

    public bool CreateTodoAsync(Todo todo)
    {
        _context.Add(todo);
        return SaveAsync();
    }

    public bool DeleteTodoAsync(Todo todo)
    {
        _context.Remove(todo);
        return SaveAsync();
    }

    public bool TodoExistsAsync(int todoId)
    {
        return _context.Todos.Any(t => t.Id == todoId);
    }

    public bool SaveAsync()
    {
        var saved = _context.SaveChanges();
        return saved > 0;
    }
}
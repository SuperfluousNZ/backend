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
    
    public ICollection<Todo> GetTodos()
    {
        return _context.Todos.OrderBy(t => t.Id).ToList();
    }

    public Todo GetTodo(int todoId)
    {
        return _context.Todos.FirstOrDefault(t => t.Id == todoId);
    }

    public bool UpdateTodo(Todo todo)
    {
        _context.Update(todo);
        return Save();
    }

    public bool CreateTodo(Todo todo)
    {
        _context.Add(todo);
        return Save();
    }

    public bool DeleteTodo(Todo todo)
    {
        _context.Remove(todo);
        return Save();
    }

    public bool TodoExists(int todoId)
    {
        return _context.Todos.Any(t => t.Id == todoId);
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0;
    }
}
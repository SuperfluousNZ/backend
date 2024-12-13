using DigraphyApi.Data;
using DigraphyApi.Models;
using DigraphyApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DigraphyApi.Repository;

public class TodoRepository(AppDbContext context) : ITodoRepository
{
    public async Task<ICollection<Todo>> GetTodosAsync()
    {
        return await context.Todos.OrderBy(t => t.Id).ToListAsync();
    }

    public async Task<Todo?> GetTodoAsync(int todoId)
    {
        return await context.Todos.FirstOrDefaultAsync(t => t.Id == todoId);
    }

    public async Task<bool> UpdateTodoAsync(Todo todo)
    {
        context.Update(todo);
        return await SaveAsync();
    }

    public async Task<bool> CreateTodoAsync(Todo todo)
    {
        context.Add(todo);
        return await SaveAsync();
    }

    public async Task<bool> DeleteTodoAsync(Todo todo)
    {
        context.Remove(todo);
        return await SaveAsync();
    }

    public async Task<bool> TodoExistsAsync(int todoId)
    {
        return await context.Todos.AnyAsync(t => t.Id == todoId);
    }

    public async Task<bool> SaveAsync()
    {
        var saved = await context.SaveChangesAsync();
        return saved > 0;
    }
}
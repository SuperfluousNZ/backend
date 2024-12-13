using DigraphyApi.Models;

namespace DigraphyApi.Interfaces;

public interface ITodoRepository
{
    Task<ICollection<Todo>> GetTodosAsync();
    Task<Todo?> GetTodoAsync(int todoId);
    Task<bool> UpdateTodoAsync(Todo todo);
    Task<bool> CreateTodoAsync(Todo todo);
    Task<bool> DeleteTodoAsync(Todo todo);
    Task<bool> TodoExistsAsync(int todoId);
    Task<bool> SaveAsync();
    
}
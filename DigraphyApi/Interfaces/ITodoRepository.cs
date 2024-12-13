using Digraphy.Models;

namespace Digraphy.Interfaces;

public interface ITodoRepository
{
    ICollection<Todo> GetTodosAsync();
    Todo? GetTodoAsync(int TodoId);
    bool UpdateTodoAsync(Todo todo);
    bool CreateTodoAsync(Todo todo);
    bool DeleteTodoAsync(Todo todo);
    bool TodoExistsAsync(int todoId);
    bool SaveAsync();
    
}
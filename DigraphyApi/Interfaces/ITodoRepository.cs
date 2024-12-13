using Digraphy.Models;

namespace Digraphy.Interfaces;

public interface ITodoRepository
{
    ICollection<Todo> GetTodos();
    Todo GetTodo(int TodoId);
    bool UpdateTodo(Todo todo);
    bool CreateTodo(Todo todo);
    bool DeleteTodo(Todo todo);
    bool TodoExists(int todoId);
    bool Save();
    
}
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
    
    // TODO
}
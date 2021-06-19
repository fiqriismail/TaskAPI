using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.DataAccess;

namespace TaskAPI.Services.Todos
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllTodos(int authorId)
        {
            return _context.Todos.Where(t => t.AuthorId == authorId).ToList();
        }

        public Todo GetTodo(int authoId, int id)
        {
            return _context.Todos.FirstOrDefault(t => t.Id == id && t.AuthorId == authoId);
        }
    }
}

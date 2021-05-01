using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoService _todoService;

        public TodosController()
        {
            _todoService = new TodoService();
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _todoService.AllTodos();

            if (id is null) return Ok(myTodos);

            myTodos = myTodos.Where(t => t.Id == id).ToList();

            return Ok(myTodos);
        }

        
    }
}

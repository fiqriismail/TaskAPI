using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPI.Services.Models
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }
        public string Status { get; set; } // New , Inprogress, Completed
        public int AuthorId { get; set; }
     
    }
}

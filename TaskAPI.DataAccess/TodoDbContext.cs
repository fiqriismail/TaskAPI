using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost; Database=MyTodoDb; User Id=sa; Password=omega_35o2";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[] {
                new Author { Id = 1, FullName = "Fiqri Ismail", AddressNo = "45", Street = "Street 1", City = "Colombo 1", JobRole = "Developer"},
                new Author { Id = 2, FullName = "Prabhashwara Bandara", AddressNo = "35", Street = "Street 2", City = "Colombo 2", JobRole = "Systems Engineer"},
                new Author { Id = 3, FullName = "Chaminda Sooriyapperuma", AddressNo = "25", Street = "Street 3", City = "Colombo 3", JobRole = "Developer"},
                new Author { Id = 4, FullName = "Hansamali Gamage", AddressNo = "15", Street = "Street 4", City = "Colombo 4", JobRole = "QA"}
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
                {
                    Id = 1,
                    Title = "Get books for school - DB",
                    Description = "Get some text books for school",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                },
                new Todo
                {
                    Id = 2,
                    Title = "Need some grocceries",
                    Description = "Go to supermarket and by some stuff",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                },
                new Todo
                {
                    Id = 3,
                    Title = "Purchase Camera",
                    Description = "Buy new camera",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 2
                },
            });
        }
    }
}

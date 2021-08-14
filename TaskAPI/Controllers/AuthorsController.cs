using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Models;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors(string job, string search)
        {
            var authors = _service.GetAllAuthors(job, search);

            var mappedAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);

            return Ok(mappedAuthors);
        }

        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult GetAuthor(int id)
        {
            var author = _service.GetAuthor(id);

            if (author is null)
            {
                return NotFound();
            }

            var mappedAuthor = _mapper.Map<AuthorDto>(author);

            return Ok(mappedAuthor);
        }

        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor(CreateAuthorDto author)
        {
            var authorEntity = _mapper.Map<Author>(author);
            var newAuthor = _service.AddAuthor(authorEntity);

            var authorForReturn = _mapper.Map<AuthorDto>(newAuthor);

            return CreatedAtRoute("GetAuthor", new {id = authorForReturn.Id},
                authorForReturn);
        }
    }
}

using AutoMapper;
using DomainModels.DTOs;
using DomainModels.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

   
    public class StudentsController : ControllerBase
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public StudentsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet("List")]

        public async Task<IActionResult> Get()
        {
            var students = await _context.Students.ToListAsync();
            return Ok(_mapper.Map<List<Student>>(students));

        }
        //public IActionResult Get()
        //{
        //    ICollection<Student> students = new List<Student>
        //   {
        //       new Student { Id = 1,Name = "Vahid",Surname = "Rashidli"},
        //       new Student { Id = 2, Name = "Nurlan", Surname = "Mammadov"}

        //   };


        //   return Ok(students);

        //}
    }
}

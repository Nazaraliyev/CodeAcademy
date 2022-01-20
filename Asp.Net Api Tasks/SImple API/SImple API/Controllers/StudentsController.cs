using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simple_API.Data;
using Simple_API.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Simple_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            List<StudentDTO> model = _context.students
                                                      .Include(s => s.Level)
                                                      .Include(s => s.Class)
                                                      .Select(s => new StudentDTO
                                                      {
                                                          Id = s.Id,
                                                          Name = s.Name,
                                                          Lastname = s.Lastname,
                                                          Email = s.Email,
                                                          Phone = s.Phone,
                                                          Photo = s.Photo,
                                                          Class = new ClassDTO
                                                          {
                                                              Id = s.Class.Id,
                                                              Name = s.Class.ClassNo,
                                                              Capacity = s.Class.Capacity,
                                                              Qualification = new QualificationDTO
                                                              {
                                                                  Id = s.Class.Qualification.Id,
                                                                  Name = s.Class.Qualification.Name,
                                                                  FreeScore = s.Class.Qualification.FreeScore,
                                                                  PaidScore = s.Class.Qualification.PaidScore,
                                                              },
                                                              Degre = new DegreDTO
                                                              {
                                                                  Id = s.Class.Degre.Id,
                                                                  Name = s.Class.Degre.Name,
                                                              },
                                                          },
                                                          Level = new LevelDTO
                                                          {
                                                              Id = s.Level.Id,
                                                              Name = s.Level.Name
                                                          },
                                                      })                                                      
                                                      .ToList();
            return Ok(model);
        }
    }
}

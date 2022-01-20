using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simple_API.Data;
using Simple_API.DTOs;
using Simple_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetStudent()
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
                                                              Score = Convert.ToDecimal(s.Score),
                                                              ClassId = s.ClassId,
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
                                                              LevelId = s.LevelId,
                                                              Level = new LevelDTO
                                                              {
                                                                  Id = s.Level.Id,
                                                                  Name = s.Level.Name
                                                              },
                                                          })
                                                          .ToList();
            return Ok(model);
        }




        [HttpGet("{id}")]
        public IActionResult FindStudent(int? Id)
        {
            if(Id == null)
            {
                return BadRequest();
            }

            if(!_context.students.Any(s => s.Id == Id))
            {
                return StatusCode(StatusCodes.Status201Created);
            }


            StudentDTO model = _context.students.Include(s => s.Level)
                                                           .Include(s => s.Class)
                                                           .Select(s => new StudentDTO
                                                           {
                                                               Id = s.Id,
                                                               Name = s.Name,
                                                               Lastname = s.Lastname,
                                                               Email = s.Email,
                                                               Phone = s.Phone,
                                                               Photo = s.Photo,
                                                               Score = Convert.ToDecimal(s.Score),
                                                               ClassId = s.ClassId,
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
                                                               LevelId = s.LevelId,
                                                               Level = new LevelDTO
                                                               {
                                                                   Id = s.Level.Id,
                                                                   Name = s.Level.Name
                                                               },
                                                           })
                                                           .FirstOrDefault(si => si.Id == Id);
            return Ok(model);
        }






        [HttpPost]
        public async Task<IActionResult> CreatStudent(StudentDTO model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Olmadi");
                return StatusCode(StatusCodes.Status401Unauthorized, model);
            }

            Student student = new Student()
            {
                Name = model.Name,
                Lastname = model.Lastname,
                Email = model.Email,
                Phone = model.Phone,
                Photo = model.Photo,
                ClassId = model.ClassId,
                LevelId = model.LevelId,
                Score = model.Score
            };

            try
            {
                await _context.students.AddAsync(student);
                await _context.SaveChangesAsync();
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch
            {

                return StatusCode(StatusCodes.Status302Found, model);
            }
        }


        [HttpPatch("{id}")]
        public IActionResult UpdateStudent(int? Id, [FromBody] StudentDTO model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Model is not valid");
                return BadRequest(model);
            }

            if (Id == null)
            {
                ModelState.AddModelError("", "Student not found");
                return StatusCode(StatusCodes.Status400BadRequest, model);
            }

            if (!_context.students.Any(s => s.Id == Id))
            {
                ModelState.AddModelError("", "Student not found");
                return StatusCode(StatusCodes.Status404NotFound, model);
            }

            try
            {
                Student UpdateStudent = new Student()
                {
                    Id = (int)Id,
                    Name = model.Name,
                    Lastname = model.Lastname,
                    Email = model.Email,
                    Phone = model.Phone,
                    Photo = model.Photo,
                    Score = model.Score,
                    ClassId = model.ClassId,
                    LevelId = model.LevelId
                };

                _context.students.Update(UpdateStudent);
                _context.SaveChanges();


                //Student UpdateStudent = _context.students.Find((int)Id);

                //UpdateStudent.Name = model.Name;
                //UpdateStudent.Lastname = model.Lastname;
                //UpdateStudent.Email = model.Email;
                //UpdateStudent.Photo = "photo.jpeg";
                //UpdateStudent.Phone = model.Phone;
                //UpdateStudent.Score = model.Score;
                //UpdateStudent.ClassId = model.ClassId;
                //UpdateStudent.LevelId = model.LevelId;

                return StatusCode(StatusCodes.Status200OK, UpdateStudent);
            }
            catch
            {
                return StatusCode(StatusCodes.Status405MethodNotAllowed);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int? Id)
        {

            if (Id == null)
            {
                ModelState.AddModelError("", "Student not found");
                return StatusCode(StatusCodes.Status400BadRequest, Id);
            }

            if (!_context.students.Any(s => s.Id == Id))
            {
                ModelState.AddModelError("", "Student not found");
                return StatusCode(StatusCodes.Status404NotFound, Id);
            }



            _context.students.Remove(_context.students.Find(Id));
            _context.SaveChanges();
            return Ok();
        }

    }
}

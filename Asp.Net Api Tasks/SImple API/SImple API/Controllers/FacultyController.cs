using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simple_API.Data;
using Simple_API.DTOs;
using Simple_API.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class FacultyController : Controller
    {
        private readonly AppDbContext _context;

        public FacultyController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetFaculty()
        {
            List<QualificationDTO> list = new List<QualificationDTO>();
            List<FacultyDTO> model = _context.faculties.Include(f => f.qualifications)
                                                        .Select(f => new FacultyDTO
                                                        {
                                                            Id = f.Id,
                                                            Name = f.Name,
                                                            SmallName = f.SmallName,
                                                            qualification = new List<QualificationDTO>()
                                                        })
                                                        .ToList();


            foreach (var item in _context.faculties.Include(f => f.qualifications))
            {
                foreach (var modelItem in model)
                {
                    if (modelItem.Id == item.Id)
                    {
                        foreach (var i in item.qualifications)
                        {
                            QualificationDTO q = new QualificationDTO()
                            {
                                Id = i.Id,
                                Name = i.Name,
                            };
                            modelItem.qualification.Add(q);
                        }
                        break;
                    }
                }
            }
            return Ok(model);
        }




        [HttpGet("{id}")]
        public async Task<IActionResult> Faculty(int? Id)
        {
            if(Id == null)
            {
                return BadRequest();
            }
            if(await _context.faculties.FindAsync(Id) == null)
            {
                ModelState.AddModelError("", "Id not Fount Database");
                return StatusCode(StatusCodes.Status404NotFound, Id);
            }

            FacultyDTO model = await _context.faculties.Include(f => f.qualifications)
                                               .Where(f => f.Id == Id)
                                               .Select(f => new FacultyDTO
                                               {
                                                   Id = f.Id,
                                                   Name = f.Name,
                                                   SmallName = f.SmallName,
                                                   qualification = new List<QualificationDTO>()
                                               }).FirstOrDefaultAsync();


            Faculty FacultyItem = await _context.faculties.Include(f => f.qualifications).FirstOrDefaultAsync(f => f.Id == model.Id);
            foreach (var item in FacultyItem.qualifications)
            {
                QualificationDTO newQualification = new QualificationDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    FreeScore = item.FreeScore,
                    PaidScore = item.PaidScore,
                };
                model.qualification.Add(newQualification);
            }

            return Ok(model);

        }

        [HttpPost]
        public async Task<IActionResult> CreateFaculty(FacultyDTO model)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status405MethodNotAllowed, model);
            }

            Faculty newFaculty = new Faculty()
            {
                Name = model.Name,
                SmallName = model.SmallName,
            };
            try
            {
                await _context.faculties.AddAsync(newFaculty);
                await _context.SaveChangesAsync();
                return Ok(newFaculty);
            }
            catch
            {
                return StatusCode(StatusCodes.Status405MethodNotAllowed, model);
            }
        }



        [HttpPatch("{Id}")]
        public async Task<IActionResult> UpdateFaculty(int? Id, FacultyDTO model)
        {
            if(Id == null)
            {
                return BadRequest();
            }

            if(await _context.faculties.FindAsync(Id) == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, Id);
            }

            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status405MethodNotAllowed, model);
            }



            try
            {
                Faculty UpdatedFaculty = await _context.faculties.FindAsync(Id);
                UpdatedFaculty.Name = model.Name;
                UpdatedFaculty.SmallName = model.SmallName;

                await _context.SaveChangesAsync();
                return Ok(model);

            }
            catch
            {
                return StatusCode(StatusCodes.Status405MethodNotAllowed, model);
            }
        }



        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteFaculty(int? Id)
        {
            if (Id == null)
            {
                return BadRequest();
            }

            if (await _context.faculties.FindAsync(Id) == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, Id);
            }

            _context.faculties.Remove(await _context.faculties.FindAsync(Id));
            await _context.SaveChangesAsync();
            return Ok(Id);
        }
    }
}

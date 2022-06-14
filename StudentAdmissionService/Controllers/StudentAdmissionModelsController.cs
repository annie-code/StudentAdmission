using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAdmissionService.Data;
using StudentAdmissionService.Models;

namespace StudentAdmissionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionModelsController : ControllerBase
    {
        private readonly StudentAdmissionServiceContext _context;

        public StudentAdmissionModelsController(StudentAdmissionServiceContext context)
        {
            _context = context;
        }

        // GET: api/StudentAdmissionModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentAdmissionModel>>> GetStudentAdmissionModel()
        {
            return await _context.StudentAdmissionModel.ToListAsync();
        }

        // GET: api/StudentAdmissionModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentAdmissionModel>> GetStudentAdmissionModel(int id)
        {
            var studentAdmissionModel = await _context.StudentAdmissionModel.FindAsync(id);

            if (studentAdmissionModel == null)
            {
                return NotFound();
            }

            return studentAdmissionModel;
        }

        // PUT: api/StudentAdmissionModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentAdmissionModel(int id, StudentAdmissionModel studentAdmissionModel)
        {
            if (id != studentAdmissionModel.StudentID)
            {
                return BadRequest();
            }

            _context.Entry(studentAdmissionModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentAdmissionModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StudentAdmissionModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentAdmissionModel>> PostStudentAdmissionModel(StudentAdmissionModel studentAdmissionModel)
        {
            _context.StudentAdmissionModel.Add(studentAdmissionModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentAdmissionModel", new { id = studentAdmissionModel.StudentID }, studentAdmissionModel);
        }

        // DELETE: api/StudentAdmissionModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentAdmissionModel(int id)
        {
            var studentAdmissionModel = await _context.StudentAdmissionModel.FindAsync(id);
            if (studentAdmissionModel == null)
            {
                return NotFound();
            }

            _context.StudentAdmissionModel.Remove(studentAdmissionModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentAdmissionModelExists(int id)
        {
            return _context.StudentAdmissionModel.Any(e => e.StudentID == id);
        }
    }
}

using ERP.Application.StudentApp.Interfaces;
using ERP.Domain.Core.Entity;
using ERP.Repository.SQLite.Migrations;
using Microsoft.EntityFrameworkCore;

namespace ERP.Repository.SQLite
{
    public class StudentRepositorySQLite : IStudentRepository
    {
        private readonly BaseDbContext _context;

        public StudentRepositorySQLite(BaseDbContext context)
        {
            _context = context;
        }

        public Task AddStudentAsync(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task EditStudentAsync(Student std)
        {
            var student = _context.Students.FirstOrDefault(x => x.StudentId == std.StudentId);

            if (student != null)
            {
                student.FirstName = std.FirstName;
                student.LastName = std.LastName;
                student.Email = std.Email;
                student.Phone = std.Phone;
                student.Address = std.Address;
            }

            return Task.CompletedTask;
        }

        public async Task<bool> ExistAsync(Student student)
        {
            return await Task.FromResult(_context.Students.Any(x => x.StudentId == student.StudentId));
        }
    

        public async Task<IEnumerable<Student>> GetAllStudentsAsync(string name)
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            return await _context.Students.FirstOrDefaultAsync(x => x.StudentId == studentId);

        }
    }
}

using ERP.Application.StudentApp.Interfaces;
using ERP.Domain.Core.Entity;

namespace ERP.Repository.SQLite
{
    public class StudentRepositorySQLite : IStudentRepository
    {
        public Task AddStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public Task EditStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAllStudentsAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentById(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}

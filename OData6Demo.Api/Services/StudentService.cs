using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OData6Demo.Api.Models;

namespace OData6Demo.Api.Services
{
    public class StudentService : IStudentService
    {
        public IQueryable<Student> RetrieveAllStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Chaitra",
                    Score = 200
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Seema",
                    Score = 160
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Reema",
                    Score = 170
                }
            }.AsQueryable(); ;
        }
    }
}

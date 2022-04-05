using RazorProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.Services
{
    public interface IRepository
    {
        void Add(Student item);
        void Delete(int id);
        void Update(Student item);
        Student Get(int id);
        IEnumerable<Student> GetAll();

    }
}

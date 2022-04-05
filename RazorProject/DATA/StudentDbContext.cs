using Microsoft.EntityFrameworkCore;
using RazorProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.DATA
{
    public class StudentDbContext :DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext>options)
            :base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using RazorProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.Models
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public IFormFile File { get; set; }
        public bool HasSaved { get; set; }
    }
}

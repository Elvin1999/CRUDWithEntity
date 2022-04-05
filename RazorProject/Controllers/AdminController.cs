using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("save")]
        public string Save()
        {
            return "Saved";
        }
        [Route("delete")]
        public string Delete()
        {
            return "Delete";
        }
        [Route("add")]
        public string Add()
        {
            return "Add";
        }
    }
}

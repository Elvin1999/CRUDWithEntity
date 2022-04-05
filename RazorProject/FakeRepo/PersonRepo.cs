using RazorProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.FakeRepo
{
    public class PersonRepo
    {
        public static List<Person> Persons { get; set; } = new List<Person>
        {
          new Person{Name="Elxan",Surname="Atayev",ImageUrl="1.png"},
          new Person{Name="Kamran",Surname="Eliyev",ImageUrl="2.jpg"},
          new Person{Name="Omer",Surname="Haciyev",ImageUrl="3.png"},
        };
    }
}

using Microsoft.AspNetCore.Razor.TagHelpers;
using RazorProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorProject.TagHelpers
{
    [HtmlTargetElement("person-list")]
    public class PersonListTagHelper : TagHelper
    {
        private List<Person> _persons;
        public PersonListTagHelper()
        {
            _persons = new List<Person>
        {
          new Person{Name="Elxan",Surname="Atayev",ImageUrl="1.png"},
          new Person{Name="Kamran",Surname="Eliyev",ImageUrl="2.jpg"},
          new Person{Name="Omer",Surname="Haciyev",ImageUrl="3.png"},
        };
        }

        private const string ListCountAttributeName = "count";
        [HtmlAttributeName(ListCountAttributeName)]
        public int ListCount { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var query = _persons.Take(ListCount);
            var sb = new StringBuilder();
            foreach (var item in query)
            {
                sb.AppendFormat("<h2><a href='person/detail/{0}'>{1}</a></h2>", item.Name, item.Name);
            }
            output.Content.SetHtmlContent(sb.ToString());
        }

    }
}

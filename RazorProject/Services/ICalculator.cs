using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.Services
{
    public interface ICalculator
    {
        decimal Calculate(decimal amount);
    }
}

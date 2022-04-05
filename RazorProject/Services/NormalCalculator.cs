using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.Services
{
    public class NormalCalculator : ICalculator
    {
        public decimal Calculate(decimal amount)
        {
            return amount - amount * 0.1m;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Services
{
    public class SampleService
    {
        public string[] GetNames()
        {
            return new string[] { "Jim", "Tim", "Vim" };
        }
    }
}

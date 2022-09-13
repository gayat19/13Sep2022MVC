using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Services
{
    public class NameRepo : IRepo
    {
        List<String> names = new List<string>();
        public void Add(string name)
        {
            names.Add(name);
        }

        public List<string> Get()
        {
            return names;
        }
    }
}

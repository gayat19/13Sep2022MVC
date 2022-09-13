using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Services
{
    public interface IRepo
    {
        void Add(string name);
        List<string> Get();
    }
}

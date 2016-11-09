using ServiceInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterface.Services
{
    class MeVitae : IMeVitae
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}

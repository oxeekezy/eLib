using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary
{
    internal interface DataWorker
    {
        void Save();
        void Read();
        void Delete();
    }
}

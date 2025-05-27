using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_ZPO.LibraryManager;

namespace Projekt_ZPO.Interfaces
{
    internal interface ILibraryStorage
    {
        void SaveLibrary(Library library);
        Library LoadLibrary();

    }
}

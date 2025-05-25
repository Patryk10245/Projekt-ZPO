using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ZPO
{
    public class GameAlreadyExistsException : Exception
    {
        public GameAlreadyExistsException(string title) : base($"Gra {title} już jest w bibliotece.") { }
    }
    public class GameNotFoundException : Exception
    {
        public GameNotFoundException(string title) : base($"Gra {title} nie została znaleziona w bibliotece.") { }
    }
}

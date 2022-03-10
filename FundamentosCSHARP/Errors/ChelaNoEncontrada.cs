using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FundamentosCSHARP.Errors
{
    public class ChelaNoEncontrada : Exception
    {
        public ChelaNoEncontrada() : base() { }
        public ChelaNoEncontrada(string msg) : base(msg) { }
        public ChelaNoEncontrada(string message, Exception innerException) : base(message, innerException) { }
    }
}

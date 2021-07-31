using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Resto.NET
{
    public class Mozo
    {
        public string NombreYApellido { get; set; }

        public Mozo(string mozo)
        {
            this.NombreYApellido = mozo;
        }

        public Mozo()
        {

        }
    }
}

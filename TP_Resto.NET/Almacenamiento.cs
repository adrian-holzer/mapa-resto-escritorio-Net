using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Resto.NET
{
    [Serializable]
    public class Almacenamiento
    {
        public List<Mesa> Mesas { get; set; } = new List<Mesa>();
        public List<Mesa> MesasV { get; set; } = new List<Mesa>();
        public List<Mesa> taburetes { get; set; } = new List<Mesa>();
        public List<Decoracion> decoracionP { get; set; } = new List<Decoracion>();
        public List<Decoracion> puerta { get; set; } = new List<Decoracion>();
        public List<Decoracion> puertaH { get; set; } = new List<Decoracion>();
        public List<Decoracion> paredCortaH { get; set; } = new List<Decoracion>();
        public List<Decoracion> paredLargaH { get; set; } = new List<Decoracion>();
        public List<Decoracion> paredCortaV { get; set; } = new List<Decoracion>();
        public List<Decoracion> paredLargaV { get; set; } = new List<Decoracion>();
        public List<Decoracion> barra { get; set; } = new List<Decoracion>();
        public List<Decoracion> barraV { get; set; } = new List<Decoracion>();
        public List<Mozo> mozos { get; set; } = new List<Mozo>();       

        public Almacenamiento()
        {

        }
    }
}

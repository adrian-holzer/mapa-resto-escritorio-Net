using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace TP_Resto.NET
{
    public enum Estado{
        DISPONIBLE,
        OCUPADO,
        RESERVADO
    }

    [Serializable]
    public class Mesa : INotifyPropertyChanged
    {
        public Cliente cliente { get; set; }
        public Mozo mozo { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fecha2 { get; set; }
        public Estado Estado { get; set; }

        private int numeroMesa;
        private Point location;
        private string ruta;

        public int NumeroMesa { get { return numeroMesa; } set { numeroMesa = value; InvokePropertyChanged(new PropertyChangedEventArgs("NumeroMesa")); } }
        public Point Location { get { return location; } set { location = value; InvokePropertyChanged(new PropertyChangedEventArgs("Location")); } }
        public string Ruta { get { return ruta; } set { ruta = value; InvokePropertyChanged(new PropertyChangedEventArgs("Ruta")); } }

        public Mesa()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }

    }
}

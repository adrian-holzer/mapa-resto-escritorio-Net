using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Resto.NET
{
    [Serializable]
    public class Decoracion : INotifyPropertyChanged
    {

        private Point location;
        private string ruta;
        private string nombre;

        public Point Location { get { return location; } set { location = value; InvokePropertyChanged(new PropertyChangedEventArgs("Location")); } }
        public string Ruta { get { return ruta; } set { ruta = value; InvokePropertyChanged(new PropertyChangedEventArgs("Ruta")); } }
        public string Nombre { get { return nombre; } set { nombre = value; InvokePropertyChanged(new PropertyChangedEventArgs("Nombre")); } }

        public Decoracion()
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

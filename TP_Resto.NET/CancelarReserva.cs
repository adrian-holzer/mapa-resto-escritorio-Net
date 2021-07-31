using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Resto.NET
{
    public partial class CancelarReserva : Form
    {
        Previsualizacion p;
        Dictionary<MesaPictureBox, Mesa> diccionario;
        MesaPictureBox m;
        private bool btnGuardarPressed;

        public bool BtnGuardarPressed { get { return btnGuardarPressed; } }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr wAbc, int wMsg, int wParam, int iParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        public CancelarReserva(Previsualizacion pre, Dictionary<MesaPictureBox, Mesa> dic, MesaPictureBox m)
        {
            InitializeComponent();
            this.p = pre;
            this.diccionario = dic;
            this.m = m;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnGuardarPressed = false;
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            btnGuardarPressed = false;
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardarPressed = false;
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            diccionario[m].cliente = null;
            diccionario[m].fecha = DateTime.Now;
            diccionario[m].fecha2 = DateTime.Now;
            diccionario[m].Estado = Estado.DISPONIBLE;
            if (diccionario[m].Ruta == @"C:..\Debug\items\00_celeste.png")
            {
                diccionario[m].Ruta = @"C:..\Debug\img\00.png";
            }
            else if (diccionario[m].Ruta == @"C:..\Debug\items\01_celeste.png")
            {
                diccionario[m].Ruta = @"C:..\Debug\img\01.png";
            }
            else if (diccionario[m].Ruta == @"C:..\Debug\items\02_celeste.png")
            {
                diccionario[m].Ruta = @"C:..\Debug\img\02.png";
            }
            else if (diccionario[m].Ruta == @"C:..\Debug\items\03_celeste.png")
            {
                diccionario[m].Ruta = @"C:..\Debug\img\03.png";
            }
            else if (diccionario[m].Ruta == @"C:..\Debug\items\04_celeste.png")
            {
                diccionario[m].Ruta = @"C:..\Debug\img\04.png";
            }
            else if (diccionario[m].Ruta == @"C:..\Debug\items\05_celeste.png")
            {
                diccionario[m].Ruta = @"C:..\Debug\img\05.png";
            }
            else if (diccionario[m].Ruta == @"C:..\Debug\items\06_celeste.png")
            {
                diccionario[m].Ruta = @"C:..\Debug\img\06.png";
            }
            btnGuardarPressed = true;
            this.Close();
        }

        public void llenarDatos()
        {
            lblNumeroMesa.Text = diccionario[m].NumeroMesa.ToString();
            lblNombre.Text = diccionario[m].cliente.Nombre;
            lblApellido.Text = diccionario[m].cliente.Apellido;
            lblDni.Text = diccionario[m].cliente.Dni;
            lblComienza.Text = diccionario[m].fecha.ToString("dd/MM/yyyy - HH:mm");
            lblFinaliza.Text = diccionario[m].fecha2.ToString("dd/MM/yyyy - HH:mm");
        }

        private void CancelarReserva_Load(object sender, EventArgs e)
        {
            llenarDatos();
        }

    }
}

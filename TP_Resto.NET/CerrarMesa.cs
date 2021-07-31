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
    public partial class CerrarMesa : Form
    {
        Previsualizacion p;
        Dictionary<MesaPictureBox, Mesa> diccionario;
        MesaPictureBox mesa;
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

        public CerrarMesa(Previsualizacion pre, Dictionary<MesaPictureBox, Mesa> dic, MesaPictureBox m)
        {
            InitializeComponent();
            this.p = pre;
            this.diccionario = dic;
            this.mesa = m;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardarPressed = false;
            Close();
        }

        public void llenarDatos()
        {
            lblNumeroMesa.Text = diccionario[mesa].NumeroMesa.ToString();
            lblNombre.Text = diccionario[mesa].cliente.Nombre;
            lblApellido.Text = diccionario[mesa].cliente.Apellido;
            lblDni.Text = diccionario[mesa].cliente.Dni;
            lblMozo.Text = diccionario[mesa].mozo.NombreYApellido;
        }

        private void CerrarMesa_Load(object sender, EventArgs e)
        {
            txtMonto.Text = "0";
            llenarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            diccionario[mesa].cliente = null;
            diccionario[mesa].mozo = null;
            diccionario[mesa].Estado = Estado.DISPONIBLE;
            if(diccionario[mesa].Ruta == @"C:..\Debug\items\00_roja.png")
            {
                diccionario[mesa].Ruta = @"C:..\Debug\img\00.png";

            }else if (diccionario[mesa].Ruta == @"C:..\Debug\items\01_roja.png")
            {
                diccionario[mesa].Ruta = @"C:..\Debug\img\01.png";
            }
            else if (diccionario[mesa].Ruta == @"C:..\Debug\items\02_roja.png")
            {
                diccionario[mesa].Ruta = @"C:..\Debug\img\02.png";
            }
            else if (diccionario[mesa].Ruta == @"C:..\Debug\items\03_roja.png")
            {
                diccionario[mesa].Ruta = @"C:..\Debug\img\03.png";
            }
            else if (diccionario[mesa].Ruta == @"C:..\Debug\items\04_roja.png")
            {
                diccionario[mesa].Ruta = @"C:..\Debug\img\04.png";
            }
            else if (diccionario[mesa].Ruta == @"C:..\Debug\items\05_roja.png")
            {
                diccionario[mesa].Ruta = @"C:..\Debug\img\05.png";
            }
            else if (diccionario[mesa].Ruta == @"C:..\Debug\items\06_rojo.png")
            {
                diccionario[mesa].Ruta = @"C:..\Debug\img\06.png";
            }
            btnGuardarPressed = true;
            Close();          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstBox.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
        }
    }
}

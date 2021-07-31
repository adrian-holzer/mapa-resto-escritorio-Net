using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TP_Resto.NET
{
    public partial class VentanaInicial : Form
    {
        public VentanaInicial()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr wAbc, int wMsg, int wParam, int iParam);


        private void panelWindows_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEdicion_Click(object sender, EventArgs e)
        {
            Diseño_Edicion diseño = new Diseño_Edicion();
            this.Hide();
            diseño.ShowDialog();
        }

        private void btnPrevisualizacion_Click(object sender, EventArgs e)
        {
            Previsualizacion prev = new Previsualizacion();
            this.Hide();
            prev.ShowDialog();
            prev.panelPrevisualizacion.Controls.Clear();
        }
    }
}

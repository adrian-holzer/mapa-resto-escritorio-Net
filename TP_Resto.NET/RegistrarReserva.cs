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
    public partial class RegistrarReserva : Form
    {
        private Cliente c;
        private DateTime fecha;
        private DateTime fecha2;
        private bool btnGuardarPressed;

        public Cliente cliente { get { return c; } }
        public DateTime Fecha { get { return fecha; } }
        public DateTime Fecha2 { get { return fecha2; } }
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

        public RegistrarReserva(int numMesa)
        {
            InitializeComponent();
            lblNumeroMesa.Text = numMesa.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnGuardarPressed = false;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                c = new Cliente(txtNombre.Text, txtApellido.Text, txtDni.Text);
                fecha = Calendario1.Value;
                fecha2 = Calendario2.Value;
                btnGuardarPressed = true;

                Close();
            }
        }

        private bool Validar()
        {
            bool validar = false;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "No puede estar vacío");
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errorProvider1.SetError(txtApellido, "No puede estar vacío");
            }
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                errorProvider1.SetError(txtDni, "No puede estar vacío");
            }
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtDni.Text))
            {
                errorProvider1.Clear();
                validar = true;
            }
            return validar;
        }
    }
}

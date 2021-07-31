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
    public partial class Datos : Form
    {
        private Cliente c;
        private DateTime fecha;
        private Mozo mozo;
        private bool btnGuardarPressed;

        List<Mozo> mozos;
        public Cliente cliente { get { return c; } }
        public DateTime Fecha { get { return fecha; } }
        public Mozo Mozo { get { return mozo; } }
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

        public Datos(int numMesa)
        {
            InitializeComponent();
            lblNumeroMesa.Text = numMesa.ToString();
            mozos = new List<Mozo>();
            mozos.Add(new Mozo("Juan Perez"));
            mozos.Add(new Mozo("Micaela Diaz"));
            mozos.Add(new Mozo("Carolina Lombardo"));
            mozos.Add(new Mozo("Martin Flores"));
            mozos.Add(new Mozo("Yamila Hierro"));
            mozos.Add(new Mozo("Nestor Guerrero"));
            mozos.Add(new Mozo("Sebastian Aguirre"));
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                c = new Cliente(txtNombre.Text, txtApellido.Text, txtDni.Text);
                fecha = Calendario.Value;
                mozo = new Mozo(cmbMozos.Text);
                btnGuardarPressed = true;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardarPressed = false;
            Close();
        }

        public void llenarCmb()
        {
            var query = (from item in mozos
                select item.NombreYApellido);

            cmbMozos.DisplayMember = "NombreYApellido";
            cmbMozos.DataSource = query.ToList();
        }

        private void Datos_Load(object sender, EventArgs e)
        {
            llenarCmb();
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

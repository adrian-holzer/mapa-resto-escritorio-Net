using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Resto.NET
{
    public partial class CambiarHora : Form
    {

        private DateTime fecha;

        public DateTime Hora { get { return fecha; } }

        public CambiarHora()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (ValidarNumero())
                {
                    fecha = new DateTime(2019, 06, 28, Convert.ToInt32(txtHora.Text), Convert.ToInt32(txtMinutos.Text), Convert.ToInt32(txtSegundos.Text));
                    Close();
                }
            }
        }

        private bool Validar()
        {
            bool validar = false;

            if (string.IsNullOrEmpty(txtHora.Text))
            {
                errorProvider1.SetError(txtHora, "No puede estar vacío");

            }
            if (string.IsNullOrEmpty(txtMinutos.Text))
            {
                errorProvider1.SetError(txtMinutos, "No puede estar vacío");

            }
            if (string.IsNullOrEmpty(txtSegundos.Text))
            {
                errorProvider1.SetError(txtSegundos, "No puede estar vacío");

            }
            if (!string.IsNullOrEmpty(txtHora.Text) && !string.IsNullOrEmpty(txtMinutos.Text) && !string.IsNullOrEmpty(txtSegundos.Text))
            {
                errorProvider1.Clear();
                validar = true;
            }
            return validar;
        }

        private bool ValidarNumero()
        {
            int contletrasHora = 0, contletrasMin = 0, contletrasSeg = 0;
            bool validarNum = false;

            foreach (char c in txtHora.Text)
            {
                if (char.IsLetter(c))
                {
                    contletrasHora++;
                }

            }

            foreach (char c in txtMinutos.Text)
            {
                if (char.IsLetter(c))
                {
                    contletrasMin++;
                }

            }

            foreach (char c in txtSegundos.Text)
            {
                if (char.IsLetter(c))
                {
                    contletrasSeg++;
                }

            }

            if (contletrasHora != 0)
            {
                errorProvider2.SetError(txtHora, "Solo puede contener números");

            }
            if (contletrasHora != 0)
            {
                errorProvider2.SetError(txtMinutos, "Solo puede contener números");

            }
            if (contletrasHora != 0)
            {
                errorProvider2.SetError(txtSegundos, "Solo puede contener números");

            }else
            {
                errorProvider2.Clear();
                validarNum = true;

            }

            return validarNum;
        }
    }
}

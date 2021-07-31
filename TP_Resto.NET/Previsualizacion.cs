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
    public partial class Previsualizacion : Form
    {
        public Almacenamiento a = new Almacenamiento();
        Serializer s = new Serializer();
        Dictionary<MesaPictureBox, Mesa> diccionario = new Dictionary<MesaPictureBox, Mesa>();

        public string rutaCargar = string.Empty;
        public string rutaGuardar = string.Empty;
        public int i = 1;
        private bool recargar = false;

        DateTime t1 = DateTime.Now;

        public Previsualizacion()
        {
            InitializeComponent();
            lblHora.Text = t1.ToLongTimeString();
        }

        public Previsualizacion(string rutaCargar, string rutaGuardar)
        {
            InitializeComponent();
            this.recargar = true;
            this.rutaCargar = rutaCargar;
            this.rutaGuardar = rutaGuardar;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Botones salir, maximizar, minimizar y restaurar

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        //Movimiento ventana

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr wAbc, int wMsg, int wParam, int iParam);

        private void panelWindows_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        //Previsualizacion load

        private void Previsualizacion_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (!recargar)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    a = s.CargarArchivo<Almacenamiento>(rutaCargar);
                    crearImagenes();
                }
                else
                {
                    MiMessageBox.ShowBox("La ruta ingresada no es válida.");
                }
            }
            else
            {
                a = s.CargarArchivo<Almacenamiento>(rutaCargar);
                crearImagenes();
            }
        }

        //OpenFileDialog, SaveFileDialog y botones guardar/abrir

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            rutaCargar = openFileDialog.FileName;
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            rutaGuardar = saveFileDialog.FileName;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            panelPrevisualizacion.Controls.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                a = s.CargarArchivo<Almacenamiento>(rutaCargar);
                crearImagenes();
            }
            else
            {
                MiMessageBox.ShowBox("La ruta ingresada no es válida.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                s.Guardar(a, rutaGuardar);
            }
            else
            {
                MiMessageBox.ShowBox("La ruta ingresada no es válida.");
            }
        }

        // Método para crear las imágenes guardadas

        private void crearImagenes()
        {
            foreach (Mesa item in a.Mesas)
            {
                MesaPictureBox p1 = new MesaPictureBox(i, false);
                p1.DataBindings.Add("NumeroMesa", item, "NumeroMesa", false, DataSourceUpdateMode.OnPropertyChanged);
                p1.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                p1.DataBindings.Add("ImageLocation", item, "Ruta");
                p1.Size = new Size(70, 50);
                p1.SizeMode = PictureBoxSizeMode.StretchImage;
                p1.Cursor = Cursors.Hand;
                p1.ContextMenuStrip = contextMenuStrip;
                diccionario.Add(p1,item);
                panelPrevisualizacion.Controls.Add(p1);
                p1.Visible = true;
            }
            foreach (Mesa item in a.MesasV)
            {
                MesaPictureBox p1 = new MesaPictureBox(i, false);
                p1.DataBindings.Add("NumeroMesa", item, "NumeroMesa", false, DataSourceUpdateMode.OnPropertyChanged);
                p1.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                p1.DataBindings.Add("ImageLocation", item, "Ruta");
                p1.Size = new Size(50, 70);
                p1.SizeMode = PictureBoxSizeMode.StretchImage;
                p1.Cursor = Cursors.Hand;
                p1.ContextMenuStrip = contextMenuStrip;
                diccionario.Add(p1, item);
                panelPrevisualizacion.Controls.Add(p1);
                p1.Visible = true;
            }
            foreach (Mesa item in a.taburetes)
            {
                MesaPictureBox pic = new MesaPictureBox(i, false);
                pic.DataBindings.Add("NumeroMesa", item, "NumeroMesa", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(20, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                diccionario.Add(pic, item);
                panelPrevisualizacion.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.decoracionP)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(false);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(20, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                panelPrevisualizacion.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.paredCortaH)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(false);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(60, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                panelPrevisualizacion.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.paredLargaH)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(false);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(100, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                panelPrevisualizacion.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.paredCortaV)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(false);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(20, 60);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                panelPrevisualizacion.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.paredLargaV)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(false);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(20, 100);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                panelPrevisualizacion.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.barra)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(false);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(50, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                panelPrevisualizacion.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.barraV)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(false);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(20, 50);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                panelPrevisualizacion.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.puerta)
            {
                PuertaPictureBox pic = new PuertaPictureBox(false);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.DataBindings.Add("Nombre", item, "Nombre");
                pic.Size = new Size(50, 70);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                panelPrevisualizacion.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.puertaH)
            {
                PuertaPictureBox pic = new PuertaPictureBox(false);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.DataBindings.Add("Nombre", item, "Nombre");
                pic.Size = new Size(70, 50);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                panelPrevisualizacion.Controls.Add(pic);
                pic.Visible = true;
            }
        }

        //ContextMenuStrip - Nuevo Cliente

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem cast1 = sender as ToolStripItem;
            ContextMenuStrip cast2 = cast1.Owner as ContextMenuStrip;
            MesaPictureBox cast3 = cast2.SourceControl as MesaPictureBox;

            Datos da = new Datos(diccionario[cast3].NumeroMesa);
            da.ShowDialog();

            if (da.BtnGuardarPressed) {
                diccionario[cast3].cliente = da.cliente;
                diccionario[cast3].fecha = da.Fecha;
                diccionario[cast3].mozo = da.Mozo;
                diccionario[cast3].Estado = Estado.OCUPADO;
                if (diccionario[cast3].Ruta == @"C:..\Debug\img\00.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\00_roja.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\01.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\01_roja.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\02.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\02_roja.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\03.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\03_roja.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\04.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\04_roja.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\05.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\05_roja.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\06.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\06_rojo.png";
                }

                s.Guardar(a, rutaCargar);
            }
            else
            {
                MiMessageBox.ShowBox("No se han guardado los cambios.");
            }


        }

        //ContextMenuStrip - Ver Información

        private void verInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem cast1 = sender as ToolStripItem;
            ContextMenuStrip cast2 = cast1.Owner as ContextMenuStrip;
            MesaPictureBox cast3 = cast2.SourceControl as MesaPictureBox;

            lblNumMesa.Text = diccionario[cast3].NumeroMesa.ToString();
            if (diccionario[cast3].cliente != null)
            {
                lblCliente.Text = diccionario[cast3].cliente.Nombre+ " " + diccionario[cast3].cliente.Apellido;
                if (diccionario[cast3].mozo != null) {
                    lblMozo.Text = diccionario[cast3].mozo.NombreYApellido;
                }
                else
                {
                    lblMozo.Text = " - ";
                }
                lblEstado.Text = diccionario[cast3].Estado.ToString();
                if (diccionario[cast3].Estado == Estado.OCUPADO) { lblFecha.Text = diccionario[cast3].fecha.ToString("dd/MM/yyyy - HH:mm"); }
                if (diccionario[cast3].Estado == Estado.RESERVADO)
                {
                    labelFecha.Visible = false;
                    labelFinaliza.Visible = true;
                    labelHorario1.Visible = true;
                    labelHorario2.Visible = true;
                    lblFecha.Text = diccionario[cast3].fecha.ToString("dd/MM/yyyy - HH:mm");
                    labelFinaliza.Text = diccionario[cast3].fecha2.ToString("dd/MM/yyyy - HH:mm");
                }
                else {
                    labelFecha.Visible = true;
                    labelFinaliza.Visible = false;
                    labelHorario1.Visible = false;
                    labelHorario2.Visible = false;
                }
            }
            else
            {
                labelFinaliza.Visible = false;
                labelHorario1.Visible = false;
                labelHorario2.Visible = false;
                lblCliente.Text = "-";
                lblMozo.Text = "-";
                lblEstado.Text = Estado.DISPONIBLE.ToString();
                labelFecha.Visible = true;
                lblFecha.Text = "-";
            }
        }

        //ContextMenuStrip - Registrar Reserva

        private void registrarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem cast1 = sender as ToolStripItem;
            ContextMenuStrip cast2 = cast1.Owner as ContextMenuStrip;
            MesaPictureBox cast3 = cast2.SourceControl as MesaPictureBox;

            RegistrarReserva register = new RegistrarReserva(diccionario[cast3].NumeroMesa);
            register.ShowDialog();


            if (register.BtnGuardarPressed)
            {
                diccionario[cast3].cliente = register.cliente;
                diccionario[cast3].fecha = register.Fecha;
                diccionario[cast3].fecha2 = register.Fecha2;
                diccionario[cast3].Estado = Estado.RESERVADO;
                if (diccionario[cast3].Ruta == @"C:..\Debug\img\00.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\00_celeste.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\01.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\01_celeste.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\02.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\02_celeste.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\03.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\03_celeste.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\04.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\04_celeste.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\05.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\05_celeste.png";
                }
                else if (diccionario[cast3].Ruta == @"C:..\Debug\img\06.png")
                {
                    diccionario[cast3].Ruta = @"C:..\Debug\items\06_celeste.png";
                }

                s.Guardar(a, rutaCargar);
            }
            else
            {
                MiMessageBox.ShowBox("No se han guardado los cambios.");
            }
        }

        //ContextMenuStrip - Cerrar Mesa

        private void cerrarMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem cast1 = sender as ToolStripItem;
            ContextMenuStrip cast2 = cast1.Owner as ContextMenuStrip;
            MesaPictureBox cast3 = cast2.SourceControl as MesaPictureBox;

            CerrarMesa cerrar = new CerrarMesa(this,diccionario,cast3);
            cerrar.ShowDialog();

            if (cerrar.BtnGuardarPressed) {
                s.Guardar(a, rutaCargar);
            }
            else
            {
                MiMessageBox.ShowBox("No se han guardado los cambios.");
            }
        }


        private void cancelarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem cast1 = sender as ToolStripItem;
            ContextMenuStrip cast2 = cast1.Owner as ContextMenuStrip;
            MesaPictureBox cast3 = cast2.SourceControl as MesaPictureBox;

            CancelarReserva cancelar = new CancelarReserva(this, diccionario, cast3);
            cancelar.ShowDialog();

            if (cancelar.BtnGuardarPressed) {
                
                s.Guardar(a, rutaCargar);
            }
            else
            {
                MiMessageBox.ShowBox("No se han guardado los cambios.");
            }
        }

        // Habilitar Items del ContextMenuStrip

        private void HabilitarItemsContext(MesaPictureBox m)
        {
            if (diccionario[m].Estado == Estado.DISPONIBLE)
            {
                m.ContextMenuStrip.Items[0].Enabled = true;
                m.ContextMenuStrip.Items[1].Enabled = true;
                m.ContextMenuStrip.Items[2].Enabled = false;
                m.ContextMenuStrip.Items[3].Enabled = false;
                m.ContextMenuStrip.Items[4].Enabled = false;
                m.ContextMenuStrip.Items[5].Enabled = false;
                m.ContextMenuStrip.Items[6].Enabled = true;
            }

            else if (diccionario[m].Estado == Estado.OCUPADO)
            {
                m.ContextMenuStrip.Items[0].Enabled = false;
                m.ContextMenuStrip.Items[1].Enabled = false;
                m.ContextMenuStrip.Items[2].Enabled = false;
                m.ContextMenuStrip.Items[3].Enabled = true;
                m.ContextMenuStrip.Items[4].Enabled = false;
                m.ContextMenuStrip.Items[5].Enabled = false;
                m.ContextMenuStrip.Items[6].Enabled = true;
            }

            else if (diccionario[m].Estado == Estado.RESERVADO)
            {
                m.ContextMenuStrip.Items[0].Enabled = false;
                m.ContextMenuStrip.Items[1].Enabled = false;
                m.ContextMenuStrip.Items[2].Enabled = false;
                m.ContextMenuStrip.Items[3].Enabled = false;
                m.ContextMenuStrip.Items[4].Enabled = true;
                m.ContextMenuStrip.Items[5].Enabled = false;
                m.ContextMenuStrip.Items[6].Enabled = true;
            }

        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip cast1 = sender as ContextMenuStrip;

            MesaPictureBox cast3 = cast1.SourceControl as MesaPictureBox;

            HabilitarItemsContext(cast3);
        }

        // Botón Volver a Ventana Inicial

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaInicial v = new VentanaInicial();
            this.Hide();
            v.ShowDialog();
        }        

        // Control Secuencia

        private void timer1_Tick(object sender, EventArgs e)
        {
            t1 = t1.AddSeconds(1);

            lblHora.Text = t1.ToLongTimeString();
        }

        private void lblHora_DoubleClick(object sender, EventArgs e)
        {
            CambiarHora ch = new CambiarHora();
            ch.ShowDialog();

            if (ch.Hora != DateTime.MinValue) {
                t1 = ch.Hora;
                lblHora.Text = t1.ToLongTimeString();
                if (lblHora.Text == "08:00:00")
                {
                    panelPrevisualizacion.Controls.Clear();
                    a = s.CargarArchivo<Almacenamiento>(@"C:..\Debug\secuencia\diseñoOriginal.xml");
                    crearImagenes();
                }if (lblHora.Text == "09:00:00")
                {
                    panelPrevisualizacion.Controls.Clear();
                    a = s.CargarArchivo<Almacenamiento>(@"C:..\Debug\secuencia\9am.xml");
                    crearImagenes();
                } else if (lblHora.Text == "10:26:00")
                {
                    panelPrevisualizacion.Controls.Clear();
                    a = s.CargarArchivo<Almacenamiento>(@"C:..\Debug\secuencia\1026am.xml");
                    crearImagenes();
                } else if (lblHora.Text == "11:46:00")
                {
                    panelPrevisualizacion.Controls.Clear();
                    a = s.CargarArchivo<Almacenamiento>(@"C:..\Debug\secuencia\1146am.xml");
                    crearImagenes();
                } else if (lblHora.Text == "14:01:00")
                {
                    panelPrevisualizacion.Controls.Clear();
                    a = s.CargarArchivo<Almacenamiento>(@"C:..\Debug\secuencia\1401am.xml");
                    crearImagenes();
                }
            }
        }

        private void panelWindows_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPrevisualizacion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

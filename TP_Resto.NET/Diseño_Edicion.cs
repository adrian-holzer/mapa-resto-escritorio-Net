using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Resto.NET
{
    public partial class Diseño_Edicion : Form
    {

        ListViewGroup mesas;
        ListViewGroup decoracion;
        ListViewGroup paredes;
        ListViewGroup barras;
        ListViewGroup puertas;
        ImageList imgs = new ImageList();
        Almacenamiento a = new Almacenamiento();
        Dictionary<MesaPictureBox, Mesa> dicMesas = new Dictionary<MesaPictureBox, Mesa>();
        Dictionary<DecoracionPictureBox, Decoracion> dicParedes = new Dictionary<DecoracionPictureBox, Decoracion>();
        Dictionary<PuertaPictureBox, Decoracion> dicPuertas = new Dictionary<PuertaPictureBox, Decoracion>();
        int i = 1;
        Serializer s;

        public Diseño_Edicion()
        {
            InitializeComponent();
            mesas = new ListViewGroup("Mesas", HorizontalAlignment.Left);
            decoracion = new ListViewGroup("Decoración", HorizontalAlignment.Left);
            paredes = new ListViewGroup("Paredes", HorizontalAlignment.Left);
            barras = new ListViewGroup("Barras", HorizontalAlignment.Left);
            puertas = new ListViewGroup("Puertas", HorizontalAlignment.Left);
            s = new Serializer(a);
        }

        //Botones salir,maximizar,minimizar y restaurar.

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        // Movimiento barra

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr wAbc, int wMsg, int wParam, int iParam);

        private void panelWindows_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        //Agregar objetos e imágenes a la ListView

        public void agregarObjetos()
        {
            imgs.ImageSize = new Size(70,50);

            string[] archivo = Directory.GetFiles(@"C:..\Debug\img");

            try
            {
                foreach (string item in archivo)
                {
                    imgs.Images.Add(item, Image.FromFile(item));
                }
            }
            catch
            {
                MessageBox.Show("Rompiste todo");
            }

            lstViewObjetos.SmallImageList = imgs;

            lstViewObjetos.Items.Add(new ListViewItem("Mesa para 4", 0, mesas));
            lstViewObjetos.Items.Add(new ListViewItem("Mesa para 6", 1, mesas));
            lstViewObjetos.Items.Add(new ListViewItem("Mesa circular", 2, mesas));
            lstViewObjetos.Items.Add(new ListViewItem("Mesa para 4", 3, mesas));
            lstViewObjetos.Items.Add(new ListViewItem("Mesa para 6", 4, mesas));
            lstViewObjetos.Items.Add(new ListViewItem("Mesa circular", 5, mesas));
            lstViewObjetos.Items.Add(new ListViewItem("Taburetes", 6, mesas));
            lstViewObjetos.Items.Add(new ListViewItem("Flores", 7, decoracion));
            lstViewObjetos.Items.Add(new ListViewItem("Pared corta H.", 8, paredes));
            lstViewObjetos.Items.Add(new ListViewItem("Pared larga H.", 9, paredes));
            lstViewObjetos.Items.Add(new ListViewItem("Pared corta V.", 10, paredes));
            lstViewObjetos.Items.Add(new ListViewItem("Pared larga V.", 11, paredes));
            lstViewObjetos.Items.Add(new ListViewItem("Barra horizontal", 12, barras));
            lstViewObjetos.Items.Add(new ListViewItem("Barra vertical", 13, barras));
            lstViewObjetos.Items.Add(new ListViewItem("Puerta vertical", 14, puertas));
            lstViewObjetos.Items.Add(new ListViewItem("Puerta horizontal", 15, puertas));

            lstViewObjetos.Groups.Add(mesas);
            lstViewObjetos.Groups.Add(decoracion);
            lstViewObjetos.Groups.Add(paredes);
            lstViewObjetos.Groups.Add(barras);
            lstViewObjetos.Groups.Add(puertas);
        }

        //Form load

        private void Diseño_Edicion_Load(object sender, EventArgs e)
        {
            agregarObjetos();
        }

        //Creación de objetos.

        private void lstViewObjetos_DoubleClick(object sender, EventArgs e)
        {

            if (lstViewObjetos.SelectedItems[0].ImageIndex < 3)
            {
                Mesa c = new Mesa();
                MesaPictureBox mesa = new MesaPictureBox(i, true);
                mesa.DataBindings.Add("NumeroMesa", c, "NumeroMesa", false, DataSourceUpdateMode.OnPropertyChanged);
                mesa.DataBindings.Add("Location", c, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                mesa.DataBindings.Add("ImageLocation", c, "Ruta");
                c.Location = new Point(360, 227);
                mesa.Size = new Size(70, 50);
                mesa.SizeMode = PictureBoxSizeMode.StretchImage;
                c.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                c.NumeroMesa = i;
                mesa.Cursor = Cursors.Hand;
                mesa.ContextMenuStrip = contextMenuStrip;
                dicMesas.Add(mesa,c);
                panelContenedorDiseño.Controls.Add(mesa);
                mesa.Visible = true;
                i++;
                a.Mesas.Add(c);
            }
            else if (lstViewObjetos.SelectedItems[0].ImageIndex > 2 && lstViewObjetos.SelectedItems[0].ImageIndex < 6)
            {
                Mesa c = new Mesa();
                MesaPictureBox mesa = new MesaPictureBox(i, true);
                mesa.DataBindings.Add("NumeroMesa", c, "NumeroMesa", false, DataSourceUpdateMode.OnPropertyChanged);
                mesa.DataBindings.Add("Location", c, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                mesa.DataBindings.Add("ImageLocation", c, "Ruta");
                c.Location = new Point(360, 227);
                mesa.Size = new Size(50, 70);
                mesa.SizeMode = PictureBoxSizeMode.StretchImage;
                c.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                c.NumeroMesa = i;
                mesa.Cursor = Cursors.Hand;
                mesa.ContextMenuStrip = contextMenuStrip;
                dicMesas.Add(mesa, c);
                panelContenedorDiseño.Controls.Add(mesa);
                mesa.Visible = true;
                i++;
                a.MesasV.Add(c);
            }else if (lstViewObjetos.SelectedItems[0].ImageIndex == 6)
            {
                Mesa c = new Mesa();
                MesaPictureBox mesa = new MesaPictureBox(i, true);
                mesa.DataBindings.Add("NumeroMesa", c, "NumeroMesa", false, DataSourceUpdateMode.OnPropertyChanged);
                mesa.DataBindings.Add("Location", c, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                mesa.DataBindings.Add("ImageLocation", c, "Ruta");
                c.Location = new Point(360, 227);
                mesa.Size = new Size(20, 20);
                mesa.SizeMode = PictureBoxSizeMode.StretchImage;
                c.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                c.NumeroMesa = i;
                mesa.Cursor = Cursors.Hand;
                mesa.ContextMenuStrip = contextMenuStrip;
                dicMesas.Add(mesa, c);
                panelContenedorDiseño.Controls.Add(mesa);
                mesa.Visible = true;
                i++;
                a.taburetes.Add(c);
            }
            else if (lstViewObjetos.SelectedItems[0].ImageIndex == 7)
            {
                Decoracion d = new Decoracion();
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", d, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", d, "Ruta");
                d.Location = new Point(360, 227);
                pic.Size = new Size(20, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                d.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic,d);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
                a.decoracionP.Add(d);
            }
            else if (lstViewObjetos.SelectedItems[0].ImageIndex == 8)
            {
                Decoracion d = new Decoracion();
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", d, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", d, "Ruta");
                d.Location = new Point(360, 227);
                pic.Size = new Size(60, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                d.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, d);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
                a.paredCortaH.Add(d);
            }
            else if (lstViewObjetos.SelectedItems[0].ImageIndex == 9)
            {
                Decoracion d = new Decoracion();
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", d, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", d, "Ruta");
                d.Location = new Point(360, 227);
                pic.Size = new Size(100, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                d.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, d);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
                a.paredLargaH.Add(d);
            }
            else if (lstViewObjetos.SelectedItems[0].ImageIndex == 10)
            {
                Decoracion d = new Decoracion();
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", d, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", d, "Ruta");
                d.Location = new Point(360, 227);
                pic.Size = new Size(20, 60);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                d.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, d);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
                a.paredCortaV.Add(d);
            }
            else if (lstViewObjetos.SelectedItems[0].ImageIndex == 11)
            {
                Decoracion d = new Decoracion();
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", d, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", d, "Ruta");
                d.Location = new Point(360, 227);
                pic.Size = new Size(20, 100);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                d.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, d);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
                a.paredLargaV.Add(d);
            }
            else if (lstViewObjetos.SelectedItems[0].ImageIndex == 12)
            {
                Decoracion d = new Decoracion();
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", d, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", d, "Ruta");
                d.Location = new Point(360, 227);
                pic.Size = new Size(50, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                d.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, d);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
                a.barra.Add(d);
            }
            else if (lstViewObjetos.SelectedItems[0].ImageIndex == 13)
            {
                Decoracion d = new Decoracion();
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", d, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", d, "Ruta");
                d.Location = new Point(360, 227);
                pic.Size = new Size(20, 50);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                d.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, d);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
                a.barraV.Add(d);
            }
            else if (lstViewObjetos.SelectedItems[0].ImageIndex == 14)
            {
                TextoPuerta txt = new TextoPuerta();
                txt.ShowDialog();
                Decoracion d = new Decoracion();
                PuertaPictureBox pic = new PuertaPictureBox(true);
                pic.DataBindings.Add("Location", d, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", d, "Ruta");
                pic.DataBindings.Add("Nombre", d, "Nombre");
                d.Nombre = txt.Area;
                d.Location = new Point(360, 227);
                pic.Size = new Size(50, 70);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                d.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicPuertas.Add(pic,d);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
                a.puerta.Add(d);
            }
            else
            {
                TextoPuerta txt = new TextoPuerta();
                txt.ShowDialog();
                Decoracion d = new Decoracion();
                PuertaPictureBox pic = new PuertaPictureBox(true);
                pic.DataBindings.Add("Location", d, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", d, "Ruta");
                pic.DataBindings.Add("Nombre", d, "Nombre");
                d.Nombre = txt.Area;
                d.Location = new Point(360, 227);
                pic.Size = new Size(70, 50);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                d.Ruta = imgs.Images.Keys[lstViewObjetos.SelectedItems[0].ImageIndex].ToString();
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicPuertas.Add(pic, d);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
                a.puertaH.Add(d);
            }

        }

        //OpenFileDialog y SaveFileDialog - Buscar path y guardar/abrir diseño.

        public string rutaCargar = string.Empty;
        public string rutaGuardar = string.Empty;

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            rutaCargar = openFileDialog.FileName;
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            rutaGuardar = saveFileDialog.FileName;
        }

        //Botones guardar, abrir y volver.

        private void btnCargar_Click(object sender, EventArgs e)
        {
            panelContenedorDiseño.Controls.Clear();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaInicial v = new VentanaInicial();
            this.Hide();
            v.ShowDialog();
        }

        private void crearImagenes()
        {
            foreach (Mesa item in a.Mesas)
            {
                MesaPictureBox p1 = new MesaPictureBox(i, true);
                p1.DataBindings.Add("NumeroMesa", item, "NumeroMesa", false, DataSourceUpdateMode.OnPropertyChanged);
                p1.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                p1.DataBindings.Add("ImageLocation", item, "Ruta");
                p1.Size = new Size(70, 50);
                p1.SizeMode = PictureBoxSizeMode.StretchImage;
                p1.Cursor = Cursors.Hand;
                p1.ContextMenuStrip = contextMenuStrip;
                dicMesas.Add(p1,item);
                panelContenedorDiseño.Controls.Add(p1);
                p1.Visible = true;
            }
            foreach (Mesa item in a.MesasV)
            {
                MesaPictureBox p1 = new MesaPictureBox(i, true);
                p1.DataBindings.Add("NumeroMesa", item, "NumeroMesa", false, DataSourceUpdateMode.OnPropertyChanged);
                p1.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                p1.DataBindings.Add("ImageLocation", item, "Ruta");
                p1.Size = new Size(50, 70);
                p1.SizeMode = PictureBoxSizeMode.StretchImage;
                p1.Cursor = Cursors.Hand;
                p1.ContextMenuStrip = contextMenuStrip;
                dicMesas.Add(p1, item);
                panelContenedorDiseño.Controls.Add(p1);
                p1.Visible = true;
            }
            foreach (Mesa item in a.taburetes)
            {
                MesaPictureBox pic = new MesaPictureBox(i,true);
                pic.DataBindings.Add("NumeroMesa", item, "NumeroMesa", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(20, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicMesas.Add(pic, item);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.decoracionP)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(20, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic,item);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;                
            }
            foreach (Decoracion item in a.paredCortaH)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(60, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, item);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.paredLargaH)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(100, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, item);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.paredCortaV)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(20, 60);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, item);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.paredLargaV)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(20, 100);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, item);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.barra)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(50, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, item);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.barraV)
            {
                DecoracionPictureBox pic = new DecoracionPictureBox(true);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.Size = new Size(20, 50);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicParedes.Add(pic, item);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.puerta)
            {
                PuertaPictureBox pic = new PuertaPictureBox(true);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.DataBindings.Add("Nombre", item, "Nombre");
                pic.Size = new Size(50, 70);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicPuertas.Add(pic,item);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
            }
            foreach (Decoracion item in a.puertaH)
            {
                PuertaPictureBox pic = new PuertaPictureBox(true);
                pic.DataBindings.Add("Location", item, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
                pic.DataBindings.Add("ImageLocation", item, "Ruta");
                pic.DataBindings.Add("Nombre", item, "Nombre");
                pic.Size = new Size(70, 50);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Cursor = Cursors.Hand;
                pic.ContextMenuStrip = contextMenuStrip;
                dicPuertas.Add(pic, item);
                panelContenedorDiseño.Controls.Add(pic);
                pic.Visible = true;
            }
        }

        //Hora y fecha.

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        //Eliminar Objetos en Diseño

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem cast1 = sender as ToolStripItem;
            ContextMenuStrip cast2 = cast1.Owner as ContextMenuStrip;
            MesaPictureBox pic = cast2.SourceControl as MesaPictureBox;

            if (pic != null) {
                panelContenedorDiseño.Controls.Remove(pic);
                a.Mesas.Remove(dicMesas[pic]);
                a.MesasV.Remove(dicMesas[pic]);
                a.taburetes.Remove(dicMesas[pic]);
            }
            else
            {
                MiMessageBox.ShowBox("Éste objeto, no es una mesa.");
            }
        }

        private void eliminarDecoraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem cast1 = sender as ToolStripItem;
            ContextMenuStrip cast2 = cast1.Owner as ContextMenuStrip;
            DecoracionPictureBox pic = cast2.SourceControl as DecoracionPictureBox;

            panelContenedorDiseño.Controls.Remove(pic);
            if (pic != null) {
                a.decoracionP.Remove(dicParedes[pic]);
                a.paredCortaH.Remove(dicParedes[pic]);
                a.paredCortaV.Remove(dicParedes[pic]);
                a.paredLargaH.Remove(dicParedes[pic]);
                a.paredLargaV.Remove(dicParedes[pic]);
                a.barra.Remove(dicParedes[pic]);
                a.barraV.Remove(dicParedes[pic]);
            }
            else
            {
                MiMessageBox.ShowBox("Éste objeto, no es una decoración.");
            }

        }

        private void eliminarPuertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem cast1 = sender as ToolStripItem;
            ContextMenuStrip cast2 = cast1.Owner as ContextMenuStrip;
            PuertaPictureBox pic = cast2.SourceControl as PuertaPictureBox;

            if (pic != null) {
                panelContenedorDiseño.Controls.Remove(pic);
                a.puerta.Remove(dicPuertas[pic]);
                a.puertaH.Remove(dicPuertas[pic]);
            }
            else
            {
                MiMessageBox.ShowBox("Éste objeto, no es una puerta.");
            }
        }

        private void panelContenedorDiseño_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

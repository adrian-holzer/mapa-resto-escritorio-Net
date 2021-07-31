using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TP_Resto.NET
{
    public class MesaPictureBox : PictureBox
    {
        bool down = false;
        Point inicio;

        public int NumeroMesa { get; set; }
        private bool moverse;

        public MesaPictureBox(int numeroMesa, bool moverse)
        {
            this.NumeroMesa = numeroMesa;
            this.Paint += Class1_Paint;
            if (moverse)
            {
                this.MouseDown += Ctr_MouseDown;
                this.MouseUp += Ctr_MouseUp;
                this.MouseMove += Ctr_MouseMove;
            }
        }

        public MesaPictureBox() : this(0, true)
        {
        }

        private void Class1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            string text = this.NumeroMesa.ToString();

            SizeF textSize = e.Graphics.MeasureString(text, Font);
            PointF locationToDraw = new PointF();
            locationToDraw.X = (((PictureBox)sender).Width / 2) - (textSize.Width / 2);
            locationToDraw.Y = (((PictureBox)sender).Height / 2) - (textSize.Height / 2);

            e.Graphics.DrawString(text, Font, Brushes.Black, locationToDraw);
        }

        private void Ctr_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;
            Control contenedor = ctr.Parent;

            if (down)
            {
                ctr.Left = e.X + ctr.Left - inicio.X;
                ctr.Top = e.Y + ctr.Top - inicio.Y;


                if (ctr.Left < 0)
                {
                    ctr.Left = 0;
                }
                if (ctr.Top < 0)
                {
                    ctr.Top = 0;
                }

                Point tmpPoint = ctr.Location;

                if (ctr.Location.X + ctr.Width > contenedor.Width)
                    tmpPoint.X = contenedor.Width - ctr.Width;
                else if (ctr.Location.X < 0)
                    tmpPoint.X = 0;

                if (ctr.Location.Y + ctr.Height > contenedor.Height)
                    tmpPoint.Y = contenedor.Height - ctr.Height;
                else if (ctr.Location.Y < 0)
                    tmpPoint.Y = 0;

                if (ctr.Location != tmpPoint)
                    ctr.Location = tmpPoint;           
            }
        }
        private void Ctr_MouseUp(object sender, MouseEventArgs e) => down = false;

        private void Ctr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                down = true;
                inicio = e.Location;
            }
        }


    }
}

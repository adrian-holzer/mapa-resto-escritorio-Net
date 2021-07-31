namespace TP_Resto.NET
{
    partial class VentanaInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInicial));
            this.panelWindows = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnPrevisualizacion = new System.Windows.Forms.Button();
            this.btnEdicion = new System.Windows.Forms.Button();
            this.panelWindows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWindows
            // 
            this.panelWindows.BackColor = System.Drawing.Color.Black;
            this.panelWindows.Controls.Add(this.btnMinimizar);
            this.panelWindows.Controls.Add(this.btnSalir);
            this.panelWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindows.Location = new System.Drawing.Point(0, 0);
            this.panelWindows.Name = "panelWindows";
            this.panelWindows.Size = new System.Drawing.Size(553, 33);
            this.panelWindows.TabIndex = 0;
            this.panelWindows.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWindows_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(482, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 33);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(519, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(31, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPrevisualizacion
            // 
            this.btnPrevisualizacion.FlatAppearance.BorderSize = 0;
            this.btnPrevisualizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnPrevisualizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnPrevisualizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevisualizacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevisualizacion.ForeColor = System.Drawing.Color.White;
            this.btnPrevisualizacion.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevisualizacion.Image")));
            this.btnPrevisualizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrevisualizacion.Location = new System.Drawing.Point(283, 60);
            this.btnPrevisualizacion.Name = "btnPrevisualizacion";
            this.btnPrevisualizacion.Size = new System.Drawing.Size(163, 209);
            this.btnPrevisualizacion.TabIndex = 4;
            this.btnPrevisualizacion.Text = "PREVISUALIZACIÓN";
            this.btnPrevisualizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrevisualizacion.UseVisualStyleBackColor = true;
            this.btnPrevisualizacion.Click += new System.EventHandler(this.btnPrevisualizacion_Click);
            // 
            // btnEdicion
            // 
            this.btnEdicion.FlatAppearance.BorderSize = 0;
            this.btnEdicion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnEdicion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdicion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdicion.ForeColor = System.Drawing.Color.White;
            this.btnEdicion.Image = ((System.Drawing.Image)(resources.GetObject("btnEdicion.Image")));
            this.btnEdicion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdicion.Location = new System.Drawing.Point(86, 60);
            this.btnEdicion.Name = "btnEdicion";
            this.btnEdicion.Size = new System.Drawing.Size(163, 209);
            this.btnEdicion.TabIndex = 3;
            this.btnEdicion.Text = "DISEÑO/EDICIÓN";
            this.btnEdicion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdicion.UseVisualStyleBackColor = true;
            this.btnEdicion.Click += new System.EventHandler(this.btnEdicion_Click);
            // 
            // VentanaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(553, 328);
            this.Controls.Add(this.btnPrevisualizacion);
            this.Controls.Add(this.btnEdicion);
            this.Controls.Add(this.panelWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaInicial";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelWindows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindows;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Button btnPrevisualizacion;
        private System.Windows.Forms.Button btnEdicion;
    }
}


namespace TP_Resto.NET
{
    partial class Diseño_Edicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diseño_Edicion));
            this.panelWindows = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.panelBordeIzquierdo = new System.Windows.Forms.Panel();
            this.panelBordeDerecho = new System.Windows.Forms.Panel();
            this.panelAbajo = new System.Windows.Forms.Panel();
            this.panelListContainer = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstViewObjetos = new System.Windows.Forms.ListView();
            this.panelContenedorDiseño = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDecoraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPuertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelWindows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panelListContainer.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindows
            // 
            this.panelWindows.BackColor = System.Drawing.Color.Black;
            this.panelWindows.Controls.Add(this.btnMaximizar);
            this.panelWindows.Controls.Add(this.btnMinimizar);
            this.panelWindows.Controls.Add(this.btnRestaurar);
            this.panelWindows.Controls.Add(this.btnSalir);
            this.panelWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindows.Location = new System.Drawing.Point(0, 0);
            this.panelWindows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelWindows.Name = "panelWindows";
            this.panelWindows.Size = new System.Drawing.Size(1267, 41);
            this.panelWindows.TabIndex = 0;
            this.panelWindows.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWindows_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1160, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(41, 42);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 7;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1111, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(41, 42);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1160, 0);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(41, 42);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1209, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 42);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelBordeIzquierdo
            // 
            this.panelBordeIzquierdo.BackColor = System.Drawing.Color.Black;
            this.panelBordeIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBordeIzquierdo.Location = new System.Drawing.Point(0, 41);
            this.panelBordeIzquierdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBordeIzquierdo.Name = "panelBordeIzquierdo";
            this.panelBordeIzquierdo.Size = new System.Drawing.Size(13, 821);
            this.panelBordeIzquierdo.TabIndex = 1;
            // 
            // panelBordeDerecho
            // 
            this.panelBordeDerecho.BackColor = System.Drawing.Color.Black;
            this.panelBordeDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBordeDerecho.Location = new System.Drawing.Point(1254, 41);
            this.panelBordeDerecho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBordeDerecho.Name = "panelBordeDerecho";
            this.panelBordeDerecho.Size = new System.Drawing.Size(13, 821);
            this.panelBordeDerecho.TabIndex = 2;
            // 
            // panelAbajo
            // 
            this.panelAbajo.BackColor = System.Drawing.Color.Black;
            this.panelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbajo.Location = new System.Drawing.Point(13, 850);
            this.panelAbajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAbajo.Name = "panelAbajo";
            this.panelAbajo.Size = new System.Drawing.Size(1241, 12);
            this.panelAbajo.TabIndex = 3;
            // 
            // panelListContainer
            // 
            this.panelListContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.panelListContainer.Controls.Add(this.lblFecha);
            this.panelListContainer.Controls.Add(this.lblHora);
            this.panelListContainer.Controls.Add(this.panel5);
            this.panelListContainer.Controls.Add(this.btnVolver);
            this.panelListContainer.Controls.Add(this.panel3);
            this.panelListContainer.Controls.Add(this.panel2);
            this.panelListContainer.Controls.Add(this.btnCargar);
            this.panelListContainer.Controls.Add(this.btnGuardar);
            this.panelListContainer.Controls.Add(this.lstViewObjetos);
            this.panelListContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelListContainer.Location = new System.Drawing.Point(1022, 41);
            this.panelListContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelListContainer.Name = "panelListContainer";
            this.panelListContainer.Size = new System.Drawing.Size(232, 809);
            this.panelListContainer.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(55, 763);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 23);
            this.lblFecha.TabIndex = 36;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(84, 725);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 30);
            this.lblHora.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Location = new System.Drawing.Point(221, 506);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 47);
            this.panel5.TabIndex = 34;
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(4, 506);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(220, 47);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(220, 398);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 47);
            this.panel3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(221, 452);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 47);
            this.panel2.TabIndex = 31;
            // 
            // btnCargar
            // 
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(4, 398);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(220, 47);
            this.btnCargar.TabIndex = 30;
            this.btnCargar.Text = "Abrir";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(4, 452);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(220, 47);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstViewObjetos
            // 
            this.lstViewObjetos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewObjetos.Location = new System.Drawing.Point(0, 0);
            this.lstViewObjetos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstViewObjetos.Name = "lstViewObjetos";
            this.lstViewObjetos.Size = new System.Drawing.Size(231, 349);
            this.lstViewObjetos.TabIndex = 0;
            this.lstViewObjetos.UseCompatibleStateImageBehavior = false;
            this.lstViewObjetos.View = System.Windows.Forms.View.SmallIcon;
            this.lstViewObjetos.DoubleClick += new System.EventHandler(this.lstViewObjetos_DoubleClick);
            // 
            // panelContenedorDiseño
            // 
            this.panelContenedorDiseño.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelContenedorDiseño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorDiseño.Location = new System.Drawing.Point(13, 41);
            this.panelContenedorDiseño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedorDiseño.Name = "panelContenedorDiseño";
            this.panelContenedorDiseño.Size = new System.Drawing.Size(1009, 809);
            this.panelContenedorDiseño.TabIndex = 5;
            this.panelContenedorDiseño.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorDiseño_Paint);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Archivos XML|*.xml";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Archivos XML|*.xml";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.contextMenuStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.eliminarDecoraciónToolStripMenuItem,
            this.eliminarPuertaToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(229, 82);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar Mesa";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // eliminarDecoraciónToolStripMenuItem
            // 
            this.eliminarDecoraciónToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eliminarDecoraciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarDecoraciónToolStripMenuItem.Image")));
            this.eliminarDecoraciónToolStripMenuItem.Name = "eliminarDecoraciónToolStripMenuItem";
            this.eliminarDecoraciónToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.eliminarDecoraciónToolStripMenuItem.Text = "Eliminar Decoración";
            this.eliminarDecoraciónToolStripMenuItem.Click += new System.EventHandler(this.eliminarDecoraciónToolStripMenuItem_Click);
            // 
            // eliminarPuertaToolStripMenuItem
            // 
            this.eliminarPuertaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eliminarPuertaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarPuertaToolStripMenuItem.Image")));
            this.eliminarPuertaToolStripMenuItem.Name = "eliminarPuertaToolStripMenuItem";
            this.eliminarPuertaToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.eliminarPuertaToolStripMenuItem.Text = "Eliminar Puerta";
            this.eliminarPuertaToolStripMenuItem.Click += new System.EventHandler(this.eliminarPuertaToolStripMenuItem_Click);
            // 
            // Diseño_Edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1267, 862);
            this.Controls.Add(this.panelContenedorDiseño);
            this.Controls.Add(this.panelListContainer);
            this.Controls.Add(this.panelAbajo);
            this.Controls.Add(this.panelBordeDerecho);
            this.Controls.Add(this.panelBordeIzquierdo);
            this.Controls.Add(this.panelWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Diseño_Edicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diseño_Edicion";
            this.Load += new System.EventHandler(this.Diseño_Edicion_Load);
            this.panelWindows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panelListContainer.ResumeLayout(false);
            this.panelListContainer.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindows;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel panelBordeIzquierdo;
        private System.Windows.Forms.Panel panelBordeDerecho;
        private System.Windows.Forms.Panel panelAbajo;
        private System.Windows.Forms.Panel panelListContainer;
        private System.Windows.Forms.ListView lstViewObjetos;
        private System.Windows.Forms.Panel panelContenedorDiseño;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDecoraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPuertaToolStripMenuItem;
    }
}
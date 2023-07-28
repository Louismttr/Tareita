namespace pjL_Matter
{
    partial class fmrPerzonalizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrPerzonalizar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.tSBarritaHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnColor = new System.Windows.Forms.ToolStripButton();
            this.btnLapiz = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.tArchivos = new System.Windows.Forms.ToolStripSplitButton();
            this.guardareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.tSBarritaHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(59)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnRestaurar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 60);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::pjL_Matter.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(665, 13);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::pjL_Matter.Properties.Resources.Restaurar;
            this.btnRestaurar.Location = new System.Drawing.Point(719, 13);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 40);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::pjL_Matter.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(771, 13);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tSBarritaHerramientas
            // 
            this.tSBarritaHerramientas.AutoSize = false;
            this.tSBarritaHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.tSBarritaHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnColor,
            this.btnLapiz,
            this.btnBorrar,
            this.tArchivos});
            this.tSBarritaHerramientas.Location = new System.Drawing.Point(0, 60);
            this.tSBarritaHerramientas.Name = "tSBarritaHerramientas";
            this.tSBarritaHerramientas.Size = new System.Drawing.Size(819, 50);
            this.tSBarritaHerramientas.TabIndex = 1;
            this.tSBarritaHerramientas.Text = "Minimenu";
            // 
            // btnColor
            // 
            this.btnColor.AutoSize = false;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(50, 50);
            this.btnColor.Text = "Color";
            this.btnColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnLapiz
            // 
            this.btnLapiz.ForeColor = System.Drawing.Color.White;
            this.btnLapiz.Image = ((System.Drawing.Image)(resources.GetObject("btnLapiz.Image")));
            this.btnLapiz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(38, 47);
            this.btnLapiz.Text = "Lápiz";
            this.btnLapiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.AutoSize = false;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(50, 50);
            this.btnBorrar.Text = "Borrador";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // tArchivos
            // 
            this.tArchivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardareToolStripMenuItem,
            this.limpiarToolStripMenuItem});
            this.tArchivos.ForeColor = System.Drawing.Color.White;
            this.tArchivos.Image = global::pjL_Matter.Properties.Resources.Carpeta;
            this.tArchivos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tArchivos.Name = "tArchivos";
            this.tArchivos.Size = new System.Drawing.Size(80, 47);
            this.tArchivos.Text = "Archivo";
            // 
            // guardareToolStripMenuItem
            // 
            this.guardareToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardareToolStripMenuItem.Image")));
            this.guardareToolStripMenuItem.Name = "guardareToolStripMenuItem";
            this.guardareToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardareToolStripMenuItem.Text = "Guardar";
            this.guardareToolStripMenuItem.Click += new System.EventHandler(this.guardareToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("limpiarToolStripMenuItem.Image")));
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 110);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(819, 415);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // fmrPerzonalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(819, 525);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.tSBarritaHerramientas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrPerzonalizar";
            this.Text = "fmrPerzonalizar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.tSBarritaHerramientas.ResumeLayout(false);
            this.tSBarritaHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ToolStrip tSBarritaHerramientas;
        private ToolStripButton btnColor;
        private ToolStripButton btnLapiz;
        private ToolStripButton btnBorrar;
        private ToolStripSplitButton tArchivos;
        private ToolStripMenuItem guardareToolStripMenuItem;
        private ToolStripMenuItem limpiarToolStripMenuItem;
        private PictureBox pic;
        private PictureBox btnMinimizar;
        private PictureBox btnRestaurar;
        private PictureBox btnCerrar;
    }
}
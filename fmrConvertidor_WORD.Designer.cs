namespace pjL_Matter
{
    partial class fmrConvertidor_WORD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArchivoOrigen = new System.Windows.Forms.TextBox();
            this.txtCarpetaDestino = new System.Windows.Forms.TextBox();
            this.btnCarpetaDestino = new System.Windows.Forms.Button();
            this.btnArchivoOrigen = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.paneContenedor = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.paneContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carpeta destino:";
            // 
            // txtArchivoOrigen
            // 
            this.txtArchivoOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtArchivoOrigen.ForeColor = System.Drawing.Color.White;
            this.txtArchivoOrigen.Location = new System.Drawing.Point(193, 113);
            this.txtArchivoOrigen.Name = "txtArchivoOrigen";
            this.txtArchivoOrigen.Size = new System.Drawing.Size(410, 25);
            this.txtArchivoOrigen.TabIndex = 2;
            // 
            // txtCarpetaDestino
            // 
            this.txtCarpetaDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtCarpetaDestino.ForeColor = System.Drawing.Color.White;
            this.txtCarpetaDestino.Location = new System.Drawing.Point(193, 195);
            this.txtCarpetaDestino.Name = "txtCarpetaDestino";
            this.txtCarpetaDestino.Size = new System.Drawing.Size(410, 25);
            this.txtCarpetaDestino.TabIndex = 3;
            // 
            // btnCarpetaDestino
            // 
            this.btnCarpetaDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(121)))));
            this.btnCarpetaDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarpetaDestino.Image = global::pjL_Matter.Properties.Resources.Carpeta;
            this.btnCarpetaDestino.Location = new System.Drawing.Point(629, 178);
            this.btnCarpetaDestino.Name = "btnCarpetaDestino";
            this.btnCarpetaDestino.Size = new System.Drawing.Size(176, 57);
            this.btnCarpetaDestino.TabIndex = 4;
            this.btnCarpetaDestino.Text = "Carpeta destino";
            this.btnCarpetaDestino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarpetaDestino.UseVisualStyleBackColor = false;
            this.btnCarpetaDestino.Click += new System.EventHandler(this.btnCarpetaDestino_Click);
            // 
            // btnArchivoOrigen
            // 
            this.btnArchivoOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(121)))));
            this.btnArchivoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivoOrigen.Image = global::pjL_Matter.Properties.Resources.PDF;
            this.btnArchivoOrigen.Location = new System.Drawing.Point(629, 98);
            this.btnArchivoOrigen.Name = "btnArchivoOrigen";
            this.btnArchivoOrigen.Size = new System.Drawing.Size(176, 53);
            this.btnArchivoOrigen.TabIndex = 5;
            this.btnArchivoOrigen.Text = "Archivo origen";
            this.btnArchivoOrigen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArchivoOrigen.UseVisualStyleBackColor = false;
            this.btnArchivoOrigen.Click += new System.EventHandler(this.btnArchivoOrigen_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(121)))));
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Image = global::pjL_Matter.Properties.Resources.Word;
            this.btnConvertir.Location = new System.Drawing.Point(348, 258);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(165, 57);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // paneContenedor
            // 
            this.paneContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(59)))), ((int)(((byte)(54)))));
            this.paneContenedor.Controls.Add(this.btnMinimizar);
            this.paneContenedor.Controls.Add(this.btnCerrar);
            this.paneContenedor.Controls.Add(this.btnRestaurar);
            this.paneContenedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneContenedor.Location = new System.Drawing.Point(0, 0);
            this.paneContenedor.Name = "paneContenedor";
            this.paneContenedor.Size = new System.Drawing.Size(839, 60);
            this.paneContenedor.TabIndex = 7;
            this.paneContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneContenedor_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::pjL_Matter.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(666, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::pjL_Matter.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(787, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::pjL_Matter.Properties.Resources.Restaurar;
            this.btnRestaurar.Location = new System.Drawing.Point(727, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 40);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 0;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // fmrConvertidor_WORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(839, 353);
            this.Controls.Add(this.paneContenedor);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnArchivoOrigen);
            this.Controls.Add(this.btnCarpetaDestino);
            this.Controls.Add(this.txtCarpetaDestino);
            this.Controls.Add(this.txtArchivoOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrConvertidor_WORD";
            this.Text = "fmrConvertidor_PDF";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fmrConvertidor_WORD_MouseDown);
            this.paneContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtArchivoOrigen;
        private TextBox txtCarpetaDestino;
        private Button btnCarpetaDestino;
        private Button btnArchivoOrigen;
        private Button btnConvertir;
        private Panel paneContenedor;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private PictureBox btnRestaurar;
    }
}
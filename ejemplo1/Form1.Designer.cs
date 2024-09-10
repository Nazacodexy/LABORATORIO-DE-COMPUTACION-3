namespace ejemplo1
{
    partial class Form1
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
            this.lvElementos = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechadenac = new System.Windows.Forms.Label();
            this.dtpFechadenac = new System.Windows.Forms.DateTimePicker();
            this.lblPerfilePersona = new System.Windows.Forms.Label();
            this.chbTegustaelchocolate = new System.Windows.Forms.CheckBox();
            this.rbtWizard = new System.Windows.Forms.RadioButton();
            this.rbtSmuggle = new System.Windows.Forms.RadioButton();
            this.rbtSquibs = new System.Windows.Forms.RadioButton();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.lblColorfav = new System.Windows.Forms.Label();
            this.cboColorfavorito = new System.Windows.Forms.ComboBox();
            this.nudNumFav = new System.Windows.Forms.NumericUpDown();
            this.lblNumFav = new System.Windows.Forms.Label();
            this.btnVerperfile = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumFav)).BeginInit();
            this.SuspendLayout();
            // 
            // lvElementos
            // 
            this.lvElementos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvElementos.HideSelection = false;
            this.lvElementos.Location = new System.Drawing.Point(106, 394);
            this.lvElementos.Name = "lvElementos";
            this.lvElementos.Size = new System.Drawing.Size(354, 179);
            this.lvElementos.TabIndex = 7;
            this.lvElementos.UseCompatibleStateImageBehavior = false;
            this.lvElementos.View = System.Windows.Forms.View.List;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(106, 579);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 50);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(261, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(103, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFechadenac
            // 
            this.lblFechadenac.AutoSize = true;
            this.lblFechadenac.Location = new System.Drawing.Point(103, 130);
            this.lblFechadenac.Name = "lblFechadenac";
            this.lblFechadenac.Size = new System.Drawing.Size(76, 13);
            this.lblFechadenac.TabIndex = 4;
            this.lblFechadenac.Text = "Fecha de nac:";
            // 
            // dtpFechadenac
            // 
            this.dtpFechadenac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechadenac.Location = new System.Drawing.Point(261, 123);
            this.dtpFechadenac.Name = "dtpFechadenac";
            this.dtpFechadenac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechadenac.TabIndex = 1;
            // 
            // lblPerfilePersona
            // 
            this.lblPerfilePersona.AutoSize = true;
            this.lblPerfilePersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilePersona.Location = new System.Drawing.Point(100, 3);
            this.lblPerfilePersona.Name = "lblPerfilePersona";
            this.lblPerfilePersona.Size = new System.Drawing.Size(184, 31);
            this.lblPerfilePersona.TabIndex = 6;
            this.lblPerfilePersona.Text = "Perfil Persona";
            // 
            // chbTegustaelchocolate
            // 
            this.chbTegustaelchocolate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbTegustaelchocolate.AutoSize = true;
            this.chbTegustaelchocolate.Location = new System.Drawing.Point(106, 162);
            this.chbTegustaelchocolate.Name = "chbTegustaelchocolate";
            this.chbTegustaelchocolate.Size = new System.Drawing.Size(135, 17);
            this.chbTegustaelchocolate.TabIndex = 2;
            this.chbTegustaelchocolate.Text = "Te gusta el chocolate?";
            this.chbTegustaelchocolate.UseVisualStyleBackColor = true;
            // 
            // rbtWizard
            // 
            this.rbtWizard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtWizard.AutoSize = true;
            this.rbtWizard.Checked = true;
            this.rbtWizard.Location = new System.Drawing.Point(16, 24);
            this.rbtWizard.Name = "rbtWizard";
            this.rbtWizard.Size = new System.Drawing.Size(58, 17);
            this.rbtWizard.TabIndex = 8;
            this.rbtWizard.TabStop = true;
            this.rbtWizard.Text = "Wizard";
            this.rbtWizard.UseVisualStyleBackColor = true;
            // 
            // rbtSmuggle
            // 
            this.rbtSmuggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtSmuggle.AutoSize = true;
            this.rbtSmuggle.Location = new System.Drawing.Point(152, 24);
            this.rbtSmuggle.Name = "rbtSmuggle";
            this.rbtSmuggle.Size = new System.Drawing.Size(66, 17);
            this.rbtSmuggle.TabIndex = 9;
            this.rbtSmuggle.TabStop = true;
            this.rbtSmuggle.Text = "Smuggle";
            this.rbtSmuggle.UseVisualStyleBackColor = true;
            // 
            // rbtSquibs
            // 
            this.rbtSquibs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtSquibs.AutoSize = true;
            this.rbtSquibs.Location = new System.Drawing.Point(260, 24);
            this.rbtSquibs.Name = "rbtSquibs";
            this.rbtSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbtSquibs.TabIndex = 10;
            this.rbtSquibs.TabStop = true;
            this.rbtSquibs.Text = "Squibs";
            this.rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // gbTipo
            // 
            this.gbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTipo.Controls.Add(this.rbtSquibs);
            this.gbTipo.Controls.Add(this.rbtSmuggle);
            this.gbTipo.Controls.Add(this.rbtWizard);
            this.gbTipo.Location = new System.Drawing.Point(106, 194);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(385, 62);
            this.gbTipo.TabIndex = 3;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // lblColorfav
            // 
            this.lblColorfav.AutoSize = true;
            this.lblColorfav.Location = new System.Drawing.Point(103, 285);
            this.lblColorfav.Name = "lblColorfav";
            this.lblColorfav.Size = new System.Drawing.Size(75, 13);
            this.lblColorfav.TabIndex = 12;
            this.lblColorfav.Text = "Color Favorito:";
            // 
            // cboColorfavorito
            // 
            this.cboColorfavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorfavorito.FormattingEnabled = true;
            this.cboColorfavorito.Location = new System.Drawing.Point(261, 277);
            this.cboColorfavorito.Name = "cboColorfavorito";
            this.cboColorfavorito.Size = new System.Drawing.Size(199, 21);
            this.cboColorfavorito.TabIndex = 4;
            // 
            // nudNumFav
            // 
            this.nudNumFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNumFav.Location = new System.Drawing.Point(340, 311);
            this.nudNumFav.Name = "nudNumFav";
            this.nudNumFav.Size = new System.Drawing.Size(120, 20);
            this.nudNumFav.TabIndex = 5;
            // 
            // lblNumFav
            // 
            this.lblNumFav.AutoSize = true;
            this.lblNumFav.Location = new System.Drawing.Point(103, 318);
            this.lblNumFav.Name = "lblNumFav";
            this.lblNumFav.Size = new System.Drawing.Size(88, 13);
            this.lblNumFav.TabIndex = 15;
            this.lblNumFav.Text = "Numero favorito: ";
            // 
            // btnVerperfile
            // 
            this.btnVerperfile.Location = new System.Drawing.Point(106, 349);
            this.btnVerperfile.Name = "btnVerperfile";
            this.btnVerperfile.Size = new System.Drawing.Size(100, 25);
            this.btnVerperfile.TabIndex = 6;
            this.btnVerperfile.Text = "Ver perfil";
            this.btnVerperfile.UseVisualStyleBackColor = true;
            this.btnVerperfile.Click += new System.EventHandler(this.btnVerperfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 660);
            this.Controls.Add(this.btnVerperfile);
            this.Controls.Add(this.lblNumFav);
            this.Controls.Add(this.nudNumFav);
            this.Controls.Add(this.cboColorfavorito);
            this.Controls.Add(this.lblColorfav);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.chbTegustaelchocolate);
            this.Controls.Add(this.lblPerfilePersona);
            this.Controls.Add(this.dtpFechadenac);
            this.Controls.Add(this.lblFechadenac);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lvElementos);
            this.MaximumSize = new System.Drawing.Size(877, 823);
            this.MinimumSize = new System.Drawing.Size(611, 699);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechadenac;
        private System.Windows.Forms.DateTimePicker dtpFechadenac;
        private System.Windows.Forms.Label lblPerfilePersona;
        private System.Windows.Forms.CheckBox chbTegustaelchocolate;
        private System.Windows.Forms.RadioButton rbtWizard;
        private System.Windows.Forms.RadioButton rbtSmuggle;
        private System.Windows.Forms.RadioButton rbtSquibs;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.Label lblColorfav;
        private System.Windows.Forms.ComboBox cboColorfavorito;
        private System.Windows.Forms.NumericUpDown nudNumFav;
        private System.Windows.Forms.Label lblNumFav;
        private System.Windows.Forms.Button btnVerperfile;
    }
}


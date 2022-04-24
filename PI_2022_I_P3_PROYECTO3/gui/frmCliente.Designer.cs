namespace PI_2022_I_P3_PROYECTO3.gui
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.btnGuardarComo = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblRTN = new System.Windows.Forms.Label();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.btnSiguienteRegistro = new System.Windows.Forms.Button();
            this.dgvClienteprimero = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblColt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.cboIDCliente = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteprimero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem1});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // regresarToolStripMenuItem1
            // 
            this.regresarToolStripMenuItem1.Name = "regresarToolStripMenuItem1";
            this.regresarToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.regresarToolStripMenuItem1.Text = "Regresar";
            this.regresarToolStripMenuItem1.Click += new System.EventHandler(this.regresarToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(221, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 23);
            this.txtID.TabIndex = 60;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.AliceBlue;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(102, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 59;
            this.lblId.Text = "ID:";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(221, 157);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(165, 23);
            this.txtApellidoCliente.TabIndex = 58;
            this.txtApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoCliente_KeyPress);
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.lblApellidoCliente.Location = new System.Drawing.Point(97, 165);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(113, 15);
            this.lblApellidoCliente.TabIndex = 57;
            this.lblApellidoCliente.Text = "Apellido del Cliente:";
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGuardarComo.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarComo.Image")));
            this.btnGuardarComo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarComo.Location = new System.Drawing.Point(12, 319);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(121, 54);
            this.btnGuardarComo.TabIndex = 56;
            this.btnGuardarComo.Text = "             Guardar          Como";
            this.btnGuardarComo.UseVisualStyleBackColor = false;
            this.btnGuardarComo.Click += new System.EventHandler(this.btnGuardarComo_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRegistrarCliente.Enabled = false;
            this.btnRegistrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCliente.Image")));
            this.btnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(147, 319);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(137, 54);
            this.btnRegistrarCliente.TabIndex = 55;
            this.btnRegistrarCliente.Text = "           Regristrar Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(221, 287);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(165, 23);
            this.txtCorreo.TabIndex = 54;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(221, 246);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(165, 23);
            this.txtRTN.TabIndex = 53;
            this.txtRTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRTN_KeyPress);
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(221, 199);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.PlaceholderText = "Ingre su Numero de Telefomo";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(165, 23);
            this.txtNumeroTelefono.TabIndex = 52;
            this.txtNumeroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTelefono_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(221, 116);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.PlaceholderText = "Ingrese Nombre ";
            this.txtNombreCliente.Size = new System.Drawing.Size(165, 23);
            this.txtNombreCliente.TabIndex = 51;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(221, 70);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(165, 23);
            this.txtCliente.TabIndex = 50;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCorreo.Location = new System.Drawing.Point(97, 293);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(113, 17);
            this.lblCorreo.TabIndex = 49;
            this.lblCorreo.Text = "Correo Electronico:";
            // 
            // lblRTN
            // 
            this.lblRTN.AutoSize = true;
            this.lblRTN.BackColor = System.Drawing.Color.AliceBlue;
            this.lblRTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblRTN.Location = new System.Drawing.Point(97, 252);
            this.lblRTN.Name = "lblRTN";
            this.lblRTN.Size = new System.Drawing.Size(36, 17);
            this.lblRTN.TabIndex = 48;
            this.lblRTN.Text = "RTN:";
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.BackColor = System.Drawing.Color.AliceBlue;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroTelefono.Location = new System.Drawing.Point(97, 205);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(108, 17);
            this.lblNumeroTelefono.TabIndex = 47;
            this.lblNumeroTelefono.Text = "Numero Telefono:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.Location = new System.Drawing.Point(97, 122);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(98, 17);
            this.lblNombreCliente.TabIndex = 46;
            this.lblNombreCliente.Text = "Nombre Cliente:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(97, 76);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 17);
            this.lblCliente.TabIndex = 45;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAbrirArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirArchivo.Image")));
            this.btnAbrirArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(322, 319);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(130, 54);
            this.btnAbrirArchivo.TabIndex = 62;
            this.btnAbrirArchivo.Text = "               Abrir Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = false;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirarchivo_Click);
            // 
            // btnSiguienteRegistro
            // 
            this.btnSiguienteRegistro.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSiguienteRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteRegistro.Image")));
            this.btnSiguienteRegistro.Location = new System.Drawing.Point(481, 319);
            this.btnSiguienteRegistro.Name = "btnSiguienteRegistro";
            this.btnSiguienteRegistro.Size = new System.Drawing.Size(124, 54);
            this.btnSiguienteRegistro.TabIndex = 63;
            this.btnSiguienteRegistro.Text = "Siguiente Registro";
            this.btnSiguienteRegistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSiguienteRegistro.UseVisualStyleBackColor = false;
            this.btnSiguienteRegistro.Click += new System.EventHandler(this.btnSiguienteRegistro_Click);
            // 
            // dgvClienteprimero
            // 
            this.dgvClienteprimero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteprimero.Location = new System.Drawing.Point(17, 397);
            this.dgvClienteprimero.Name = "dgvClienteprimero";
            this.dgvClienteprimero.RowTemplate.Height = 25;
            this.dgvClienteprimero.Size = new System.Drawing.Size(904, 171);
            this.dgvClienteprimero.TabIndex = 64;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrar.Image")));
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.Location = new System.Drawing.Point(628, 319);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(131, 54);
            this.btnMostrar.TabIndex = 66;
            this.btnMostrar.Text = "        Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblColt
            // 
            this.lblColt.AutoSize = true;
            this.lblColt.Location = new System.Drawing.Point(97, 339);
            this.lblColt.Name = "lblColt";
            this.lblColt.Size = new System.Drawing.Size(0, 15);
            this.lblColt.TabIndex = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(992, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(781, 319);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(140, 54);
            this.btnSeleccionar.TabIndex = 70;
            this.btnSeleccionar.Text = "         Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.lblIDCliente.Location = new System.Drawing.Point(580, 246);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(63, 15);
            this.lblIDCliente.TabIndex = 72;
            this.lblIDCliente.Text = "ID/Cliente:";
            // 
            // cboIDCliente
            // 
            this.cboIDCliente.FormattingEnabled = true;
            this.cboIDCliente.Location = new System.Drawing.Point(661, 243);
            this.cboIDCliente.Name = "cboIDCliente";
            this.cboIDCliente.Size = new System.Drawing.Size(165, 23);
            this.cboIDCliente.TabIndex = 74;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(992, 597);
            this.Controls.Add(this.cboIDCliente);
            this.Controls.Add(this.lblIDCliente);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblColt);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvClienteprimero);
            this.Controls.Add(this.btnSiguienteRegistro);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblRTN);
            this.Controls.Add(this.lblNumeroTelefono);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteprimero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem regresarToolStripMenuItem1;
        private TextBox txtID;
        private Label lblId;
        private TextBox txtApellidoCliente;
        private Label lblApellidoCliente;
        private Button btnGuardarComo;
        private Button btnRegistrarCliente;
        private TextBox txtCorreo;
        private TextBox txtRTN;
        private TextBox txtNumeroTelefono;
        private TextBox txtNombreCliente;
        private TextBox txtCliente;
        private Label lblCorreo;
        private Label lblRTN;
        private Label lblNumeroTelefono;
        private Label lblNombreCliente;
        private Label lblCliente;
        private Button btnAbrirArchivo;
        private Button btnSiguienteRegistro;
        private DataGridView dgvClienteprimero;
        private Button btnMostrar;
        private Label lblColt;
        private PictureBox pictureBox1;
        private Button btnSeleccionar;
        private Label lblIDCliente;
        private ComboBox cboIDCliente;
    }
}
namespace PI_2022_I_P3_PROYECTO3.gui
{
    partial class frmServicioaDomicilio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicioaDomicilio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSiguienteRegistro = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.btnGuardarComo = new System.Windows.Forms.Button();
            this.txtTarjetaoEfectivo = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblComidallevar = new System.Windows.Forms.Label();
            this.lblTarjetaoEfectivo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.bntMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPorte = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(995, 541);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSiguienteRegistro
            // 
            this.btnSiguienteRegistro.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._4829869_arrow_next_right_icon;
            this.btnSiguienteRegistro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiguienteRegistro.Location = new System.Drawing.Point(443, 304);
            this.btnSiguienteRegistro.Name = "btnSiguienteRegistro";
            this.btnSiguienteRegistro.Size = new System.Drawing.Size(121, 57);
            this.btnSiguienteRegistro.TabIndex = 57;
            this.btnSiguienteRegistro.Text = "Siguiente Registro";
            this.btnSiguienteRegistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSiguienteRegistro.UseVisualStyleBackColor = true;
            this.btnSiguienteRegistro.Click += new System.EventHandler(this.btnSiguienteRegistro_Click);
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(34, 384);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowTemplate.Height = 25;
            this.dgvView.Size = new System.Drawing.Size(815, 152);
            this.dgvView.TabIndex = 56;
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._3643772_folder_archive_open_archives_document_icon;
            this.btnAbrirArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(305, 304);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(114, 57);
            this.btnAbrirArchivo.TabIndex = 55;
            this.btnAbrirArchivo.Text = "                  Abrir                 Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click_1);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(227, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 23);
            this.txtID.TabIndex = 54;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.AliceBlue;
            this.lblID.Location = new System.Drawing.Point(94, 38);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 53;
            this.lblID.Text = "ID:";
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._9133514_signup_register_login_icon;
            this.btnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(163, 304);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(119, 57);
            this.btnRegistrarCliente.TabIndex = 52;
            this.btnRegistrarCliente.Text = "              Registrar            Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click_1);
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._285657_floppy_guardar_save_icon__1_;
            this.btnGuardarComo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarComo.Location = new System.Drawing.Point(34, 304);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(113, 60);
            this.btnGuardarComo.TabIndex = 51;
            this.btnGuardarComo.Text = "             Guardar              Como";
            this.btnGuardarComo.UseVisualStyleBackColor = true;
            this.btnGuardarComo.Click += new System.EventHandler(this.btnGuardarComo_Click);
            // 
            // txtTarjetaoEfectivo
            // 
            this.txtTarjetaoEfectivo.Location = new System.Drawing.Point(225, 260);
            this.txtTarjetaoEfectivo.Name = "txtTarjetaoEfectivo";
            this.txtTarjetaoEfectivo.Size = new System.Drawing.Size(138, 23);
            this.txtTarjetaoEfectivo.TabIndex = 50;
            this.txtTarjetaoEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarjetaoEfectivo_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(225, 217);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(138, 23);
            this.txtCorreo.TabIndex = 49;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(225, 176);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(138, 23);
            this.txtDireccion.TabIndex = 48;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(225, 135);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(138, 23);
            this.txtComida.TabIndex = 47;
            this.txtComida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComida_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(225, 92);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(138, 23);
            this.txtTelefono.TabIndex = 46;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(225, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 23);
            this.txtNombre.TabIndex = 45;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCorreoElectronico.Location = new System.Drawing.Point(94, 217);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(113, 17);
            this.lblCorreoElectronico.TabIndex = 44;
            this.lblCorreoElectronico.Text = "Correo Electronico:";
            // 
            // lblComidallevar
            // 
            this.lblComidallevar.AutoSize = true;
            this.lblComidallevar.BackColor = System.Drawing.Color.AliceBlue;
            this.lblComidallevar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblComidallevar.Location = new System.Drawing.Point(94, 141);
            this.lblComidallevar.Name = "lblComidallevar";
            this.lblComidallevar.Size = new System.Drawing.Size(107, 17);
            this.lblComidallevar.TabIndex = 43;
            this.lblComidallevar.Text = "Comida que lleva:";
            // 
            // lblTarjetaoEfectivo
            // 
            this.lblTarjetaoEfectivo.AutoSize = true;
            this.lblTarjetaoEfectivo.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTarjetaoEfectivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTarjetaoEfectivo.Location = new System.Drawing.Point(94, 260);
            this.lblTarjetaoEfectivo.Name = "lblTarjetaoEfectivo";
            this.lblTarjetaoEfectivo.Size = new System.Drawing.Size(107, 17);
            this.lblTarjetaoEfectivo.TabIndex = 42;
            this.lblTarjetaoEfectivo.Text = "Tarjeta o Efectivo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(94, 182);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 17);
            this.lblDireccion.TabIndex = 41;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.BackColor = System.Drawing.Color.AliceBlue;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroTelefono.Location = new System.Drawing.Point(94, 98);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(125, 17);
            this.lblNumeroTelefono.TabIndex = 40;
            this.lblNumeroTelefono.Text = "Numero de Telefono:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.Location = new System.Drawing.Point(94, 63);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(118, 17);
            this.lblNombreCliente.TabIndex = 39;
            this.lblNombreCliente.Text = "Nombre del Cliente:";
            // 
            // bntMostrar
            // 
            this.bntMostrar.BackColor = System.Drawing.Color.AliceBlue;
            this.bntMostrar.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._3844476_eye_see_show_view_watch_icon;
            this.bntMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntMostrar.Location = new System.Drawing.Point(593, 304);
            this.bntMostrar.Name = "bntMostrar";
            this.bntMostrar.Size = new System.Drawing.Size(113, 57);
            this.bntMostrar.TabIndex = 59;
            this.bntMostrar.Text = "Mostrar";
            this.bntMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntMostrar.UseVisualStyleBackColor = false;
            this.bntMostrar.Click += new System.EventHandler(this.bntMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(626, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nombre  Cliente:";
            // 
            // cboPorte
            // 
            this.cboPorte.FormattingEnabled = true;
            this.cboPorte.Location = new System.Drawing.Point(739, 211);
            this.cboPorte.Name = "cboPorte";
            this.cboPorte.Size = new System.Drawing.Size(132, 23);
            this.cboPorte.TabIndex = 62;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSeleccionar.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._9042663_open_select_hand_gesture_icon1;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(726, 304);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(123, 57);
            this.btnSeleccionar.TabIndex = 64;
            this.btnSeleccionar.Text = "          Sleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmServicioaDomicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(986, 553);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.cboPorte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntMostrar);
            this.Controls.Add(this.btnSiguienteRegistro);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.txtTarjetaoEfectivo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.lblComidallevar);
            this.Controls.Add(this.lblTarjetaoEfectivo);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNumeroTelefono);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmServicioaDomicilio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServicioaDomicilio";
            this.Load += new System.EventHandler(this.frmServicioaDomicilio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem regresarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button btnSiguienteRegistro;
        private DataGridView dgvView;
        private Button btnAbrirArchivo;
        private TextBox txtID;
        private Label lblID;
        private Button btnRegistrarCliente;
        private Button btnGuardarComo;
        private TextBox txtTarjetaoEfectivo;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private TextBox txtComida;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label lblCorreoElectronico;
        private Label lblComidallevar;
        private Label lblTarjetaoEfectivo;
        private Label lblDireccion;
        private Label lblNumeroTelefono;
        private Label lblNombreCliente;
        private Button bntMostrar;
        private Label label1;
        private ComboBox cboPorte;
        private Button btnSeleccionar;
    }
}
namespace PI_2022_I_P3_PROYECTO3.gui
{
    partial class frmEmpleadoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadoNuevo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAplellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNacimento = new System.Windows.Forms.TextBox();
            this.txtExperincia = new System.Windows.Forms.TextBox();
            this.btnGuardarComo = new System.Windows.Forms.Button();
            this.btnReguistarEmpleado = new System.Windows.Forms.Button();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.btnSiguienteReguistro = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.dgvPorte = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNombreone = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu principal";
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
            this.pictureBox1.Size = new System.Drawing.Size(1047, 519);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(39, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(39, 88);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(63, 15);
            this.lblEmpleado.TabIndex = 18;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 15);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre del Empleado:";
            // 
            // lblAplellido
            // 
            this.lblAplellido.AutoSize = true;
            this.lblAplellido.Location = new System.Drawing.Point(39, 170);
            this.lblAplellido.Name = "lblAplellido";
            this.lblAplellido.Size = new System.Drawing.Size(54, 15);
            this.lblAplellido.TabIndex = 22;
            this.lblAplellido.Text = "Apellido:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(39, 205);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(36, 15);
            this.lblEdad.TabIndex = 24;
            this.lblEdad.Text = "Edad:";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(39, 277);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(106, 15);
            this.lblNacimiento.TabIndex = 26;
            this.lblNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.Location = new System.Drawing.Point(39, 316);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(70, 15);
            this.lblExperiencia.TabIndex = 28;
            this.lblExperiencia.Text = "Experiancia:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(174, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(124, 23);
            this.txtID.TabIndex = 30;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(174, 88);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(124, 23);
            this.txtEmpleado.TabIndex = 32;
            this.txtEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpleado_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 133);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 23);
            this.txtNombre.TabIndex = 34;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(174, 170);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(124, 23);
            this.txtApellido.TabIndex = 36;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(174, 205);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(124, 23);
            this.txtEdad.TabIndex = 38;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtNacimento
            // 
            this.txtNacimento.Location = new System.Drawing.Point(174, 269);
            this.txtNacimento.Name = "txtNacimento";
            this.txtNacimento.Size = new System.Drawing.Size(124, 23);
            this.txtNacimento.TabIndex = 40;
            this.txtNacimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNacimento_KeyPress);
            // 
            // txtExperincia
            // 
            this.txtExperincia.Location = new System.Drawing.Point(174, 313);
            this.txtExperincia.Name = "txtExperincia";
            this.txtExperincia.Size = new System.Drawing.Size(124, 23);
            this.txtExperincia.TabIndex = 42;
            this.txtExperincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExperincia_KeyPress);
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._285657_floppy_guardar_save_icon__1_;
            this.btnGuardarComo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarComo.Location = new System.Drawing.Point(380, 110);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(126, 46);
            this.btnGuardarComo.TabIndex = 43;
            this.btnGuardarComo.Text = "                Guardar                Como";
            this.btnGuardarComo.UseVisualStyleBackColor = true;
            this.btnGuardarComo.Click += new System.EventHandler(this.btnGuardarComo_Click);
            // 
            // btnReguistarEmpleado
            // 
            this.btnReguistarEmpleado.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._9133514_signup_register_login_icon;
            this.btnReguistarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReguistarEmpleado.Location = new System.Drawing.Point(512, 110);
            this.btnReguistarEmpleado.Name = "btnReguistarEmpleado";
            this.btnReguistarEmpleado.Size = new System.Drawing.Size(124, 46);
            this.btnReguistarEmpleado.TabIndex = 44;
            this.btnReguistarEmpleado.Text = "             Registrar                       Emlpeado       ";
            this.btnReguistarEmpleado.UseVisualStyleBackColor = true;
            this.btnReguistarEmpleado.Click += new System.EventHandler(this.btnReguistarEmpleado_Click);
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._3643772_folder_archive_open_archives_document_icon;
            this.btnAbrirArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(642, 110);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(122, 46);
            this.btnAbrirArchivo.TabIndex = 45;
            this.btnAbrirArchivo.Text = "                       Abrir                       Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // btnSiguienteReguistro
            // 
            this.btnSiguienteReguistro.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._4829869_arrow_next_right_icon1;
            this.btnSiguienteReguistro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiguienteReguistro.Location = new System.Drawing.Point(770, 110);
            this.btnSiguienteReguistro.Name = "btnSiguienteReguistro";
            this.btnSiguienteReguistro.Size = new System.Drawing.Size(130, 46);
            this.btnSiguienteReguistro.TabIndex = 46;
            this.btnSiguienteReguistro.Text = "Siguiente Reguistro";
            this.btnSiguienteReguistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiguienteReguistro.UseVisualStyleBackColor = true;
            this.btnSiguienteReguistro.Click += new System.EventHandler(this.btnSiguienteReguistro_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._3844476_eye_see_show_view_watch_icon;
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.Location = new System.Drawing.Point(914, 110);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(115, 46);
            this.btnMostrar.TabIndex = 47;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(39, 240);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 15);
            this.lblSexo.TabIndex = 48;
            this.lblSexo.Text = "Sexo";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(174, 240);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(124, 23);
            this.txtSexo.TabIndex = 49;
            this.txtSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSexo_KeyPress);
            // 
            // dgvPorte
            // 
            this.dgvPorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorte.Location = new System.Drawing.Point(380, 277);
            this.dgvPorte.Name = "dgvPorte";
            this.dgvPorte.RowTemplate.Height = 25;
            this.dgvPorte.Size = new System.Drawing.Size(649, 150);
            this.dgvPorte.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(688, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nombre Cliente Nuevo:";
            // 
            // cboNombreone
            // 
            this.cboNombreone.FormattingEnabled = true;
            this.cboNombreone.Location = new System.Drawing.Point(859, 232);
            this.cboNombreone.Name = "cboNombreone";
            this.cboNombreone.Size = new System.Drawing.Size(152, 23);
            this.cboNombreone.TabIndex = 54;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._9042663_open_select_hand_gesture_icon;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(904, 170);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(125, 50);
            this.btnSeleccionar.TabIndex = 56;
            this.btnSeleccionar.Text = "             Selccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // frmEmpleadoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 519);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.cboNombreone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPorte);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSiguienteReguistro);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.btnReguistarEmpleado);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.txtExperincia);
            this.Controls.Add(this.txtNacimento);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblExperiencia);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblAplellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEmpleadoNuevo";
            this.Text = "Empleado Nuevo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem regresarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label lblID;
        private Label lblEmpleado;
        private Label lblNombre;
        private Label lblAplellido;
        private Label lblEdad;
        private Label lblNacimiento;
        private Label lblExperiencia;
        private TextBox txtID;
        private TextBox txtEmpleado;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtNacimento;
        private TextBox txtExperincia;
        private Button btnGuardarComo;
        private Button btnReguistarEmpleado;
        private Button btnAbrirArchivo;
        private Button btnSiguienteReguistro;
        private Button btnMostrar;
        private Label lblSexo;
        private TextBox txtSexo;
        private DataGridView dgvPorte;
        private Label label1;
        private ComboBox cboNombreone;
        private Button btnSeleccionar;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}
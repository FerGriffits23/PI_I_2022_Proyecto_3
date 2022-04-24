namespace PI_2022_I_P3_PROYECTO3.gui
{
    partial class frmReservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservaciones));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.btnSiguienteReguistro = new System.Windows.Forms.Button();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnGuardarcomo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtPersonas = new System.Windows.Forms.TextBox();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lbPersonas = new System.Windows.Forms.Label();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.bntMostrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.cboIDNombre1 = new System.Windows.Forms.ComboBox();
            this.lblIDNombreCliente = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
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
            this.pictureBox1.Size = new System.Drawing.Size(1008, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRegistrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCliente.Image")));
            this.btnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(180, 291);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(127, 49);
            this.btnRegistrarCliente.TabIndex = 66;
            this.btnRegistrarCliente.Text = "                 Registrar               Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click_1);
            // 
            // dgvMesas
            // 
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Location = new System.Drawing.Point(12, 389);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.RowTemplate.Height = 25;
            this.dgvMesas.Size = new System.Drawing.Size(897, 166);
            this.dgvMesas.TabIndex = 65;
            // 
            // btnSiguienteReguistro
            // 
            this.btnSiguienteReguistro.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSiguienteReguistro.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._4829869_arrow_next_right_icon;
            this.btnSiguienteReguistro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiguienteReguistro.Location = new System.Drawing.Point(463, 293);
            this.btnSiguienteReguistro.Name = "btnSiguienteReguistro";
            this.btnSiguienteReguistro.Size = new System.Drawing.Size(116, 46);
            this.btnSiguienteReguistro.TabIndex = 64;
            this.btnSiguienteReguistro.Text = "                    Siguiente Registro";
            this.btnSiguienteReguistro.UseVisualStyleBackColor = false;
            this.btnSiguienteReguistro.Click += new System.EventHandler(this.btnSiguienteReguistro_Click_1);
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAbrirArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirArchivo.Image")));
            this.btnAbrirArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(328, 291);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(119, 48);
            this.btnAbrirArchivo.TabIndex = 63;
            this.btnAbrirArchivo.Text = "                  Abrir                Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = false;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(234, 85);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(147, 23);
            this.txtTelefono.TabIndex = 62;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(93, 93);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(118, 15);
            this.lblTelefono.TabIndex = 61;
            this.lblTelefono.Text = "Numero de Telefono:";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(234, 161);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(147, 23);
            this.txtHora.TabIndex = 60;
            this.txtHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHora_KeyPress);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.AliceBlue;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(93, 161);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(130, 15);
            this.lblHora.TabIndex = 59;
            this.lblHora.Text = "Hora de la Reservacion:";
            // 
            // btnGuardarcomo
            // 
            this.btnGuardarcomo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGuardarcomo.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarcomo.Image")));
            this.btnGuardarcomo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarcomo.Location = new System.Drawing.Point(29, 293);
            this.btnGuardarcomo.Name = "btnGuardarcomo";
            this.btnGuardarcomo.Size = new System.Drawing.Size(129, 48);
            this.btnGuardarcomo.TabIndex = 58;
            this.btnGuardarcomo.Text = "                   Guardar                  Como  ";
            this.btnGuardarcomo.UseVisualStyleBackColor = false;
            this.btnGuardarcomo.Click += new System.EventHandler(this.btnGuardarcomo_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 57;
            // 
            // txtMesa
            // 
            this.txtMesa.Location = new System.Drawing.Point(234, 226);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(147, 23);
            this.txtMesa.TabIndex = 56;
            this.txtMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesa_KeyPress);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(234, 124);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(147, 23);
            this.txtFecha.TabIndex = 55;
            this.txtFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFecha_KeyPress);
            // 
            // txtPersonas
            // 
            this.txtPersonas.Location = new System.Drawing.Point(234, 256);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.Size = new System.Drawing.Size(147, 23);
            this.txtPersonas.TabIndex = 54;
            this.txtPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonas_KeyPress);
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(234, 194);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(147, 23);
            this.txtTicket.TabIndex = 53;
            this.txtTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicket_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(234, 56);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(147, 23);
            this.txtNombreCliente.TabIndex = 52;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.BackColor = System.Drawing.Color.AliceBlue;
            this.lblMesa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMesa.Location = new System.Drawing.Point(93, 226);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(38, 15);
            this.lblMesa.TabIndex = 51;
            this.lblMesa.Text = "Mesa:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.AliceBlue;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(93, 127);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(135, 15);
            this.lblFecha.TabIndex = 50;
            this.lblFecha.Text = "Fecha de la Reservacion:";
            // 
            // lbPersonas
            // 
            this.lbPersonas.AutoSize = true;
            this.lbPersonas.BackColor = System.Drawing.Color.AliceBlue;
            this.lbPersonas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPersonas.Location = new System.Drawing.Point(93, 256);
            this.lbPersonas.Name = "lbPersonas";
            this.lbPersonas.Size = new System.Drawing.Size(57, 15);
            this.lbPersonas.TabIndex = 49;
            this.lbPersonas.Text = "Personas:";
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.BackColor = System.Drawing.Color.AliceBlue;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroTelefono.Location = new System.Drawing.Point(93, 194);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(41, 15);
            this.lblNumeroTelefono.TabIndex = 48;
            this.lblNumeroTelefono.Text = "Ticket:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.Location = new System.Drawing.Point(93, 61);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(113, 15);
            this.lblNombreCliente.TabIndex = 47;
            this.lblNombreCliente.Text = "Nombre del Cliente:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(234, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 23);
            this.txtID.TabIndex = 68;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.AliceBlue;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(93, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 67;
            this.lblID.Text = "ID:";
            // 
            // bntMostrar
            // 
            this.bntMostrar.BackColor = System.Drawing.Color.AliceBlue;
            this.bntMostrar.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._3844476_eye_see_show_view_watch_icon;
            this.bntMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntMostrar.Location = new System.Drawing.Point(600, 292);
            this.bntMostrar.Name = "bntMostrar";
            this.bntMostrar.Size = new System.Drawing.Size(114, 50);
            this.bntMostrar.TabIndex = 69;
            this.bntMostrar.Text = "Mostrar";
            this.bntMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntMostrar.UseVisualStyleBackColor = false;
            this.bntMostrar.Click += new System.EventHandler(this.bntMostrar_Click_1);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._9042663_open_select_hand_gesture_icon;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(732, 291);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(126, 52);
            this.btnSeleccionar.TabIndex = 71;
            this.btnSeleccionar.Text = "             Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // cboIDNombre1
            // 
            this.cboIDNombre1.FormattingEnabled = true;
            this.cboIDNombre1.Location = new System.Drawing.Point(653, 218);
            this.cboIDNombre1.Name = "cboIDNombre1";
            this.cboIDNombre1.Size = new System.Drawing.Size(179, 23);
            this.cboIDNombre1.TabIndex = 73;
            // 
            // lblIDNombreCliente
            // 
            this.lblIDNombreCliente.AutoSize = true;
            this.lblIDNombreCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.lblIDNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIDNombreCliente.Location = new System.Drawing.Point(524, 221);
            this.lblIDNombreCliente.Name = "lblIDNombreCliente";
            this.lblIDNombreCliente.Size = new System.Drawing.Size(120, 17);
            this.lblIDNombreCliente.TabIndex = 75;
            this.lblIDNombreCliente.Text = "ID/Nombre Cliente:";
            this.lblIDNombreCliente.Click += new System.EventHandler(this.lblIDNombreCliente_Click);
            // 
            // frmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1008, 576);
            this.Controls.Add(this.lblIDNombreCliente);
            this.Controls.Add(this.cboIDNombre1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.bntMostrar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.btnSiguienteReguistro);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnGuardarcomo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMesa);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtPersonas);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lbPersonas);
            this.Controls.Add(this.lblNumeroTelefono);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReservaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservaciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSiguienteRegistro_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem regresarToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button btnRegistrarCliente;
        private DataGridView dgvMesas;
        private Button btnSiguienteReguistro;
        private Button btnAbrirArchivo;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtHora;
        private Label lblHora;
        private Button btnGuardarcomo;
        private Label label1;
        private TextBox txtMesa;
        private TextBox txtFecha;
        private TextBox txtPersonas;
        private TextBox txtTicket;
        private TextBox txtNombreCliente;
        private Label lblMesa;
        private Label lblFecha;
        private Label lbPersonas;
        private Label lblNumeroTelefono;
        private Label lblNombreCliente;
        private TextBox txtID;
        private Label lblID;
        private Button bntMostrar;
        private Button btnSeleccionar;
        private ComboBox cboIDNombre1;
        private Label lblIDNombreCliente;
    }
}
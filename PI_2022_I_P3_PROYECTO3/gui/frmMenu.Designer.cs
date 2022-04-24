namespace PI_2022_I_P3_PROYECTO3.gui
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPrit = new System.Windows.Forms.DataGridView();
            this.btnMostar = new System.Windows.Forms.Button();
            this.btnSiguienteReguistro = new System.Windows.Forms.Button();
            this.btnArbriArchivo = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGuardarComo = new System.Windows.Forms.Button();
            this.txtPostre = new System.Windows.Forms.TextBox();
            this.lblPostre = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRefresco = new System.Windows.Forms.Label();
            this.txtRefresco = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.lblRTN = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFanta = new System.Windows.Forms.Label();
            this.lblSprite = new System.Windows.Forms.Label();
            this.lblFresca = new System.Windows.Forms.Label();
            this.lblCocacola = new System.Windows.Forms.Label();
            this.lblPizza = new System.Windows.Forms.Label();
            this.lblPupusas = new System.Windows.Forms.Label();
            this.lblChuleta = new System.Windows.Forms.Label();
            this.lblBaledas = new System.Windows.Forms.Label();
            this.lblEmpadas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSleccionar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cboClienteN = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 24);
            this.menuStrip1.TabIndex = 31;
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
            this.pictureBox1.Size = new System.Drawing.Size(1134, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvPrit
            // 
            this.dgvPrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrit.Location = new System.Drawing.Point(337, 335);
            this.dgvPrit.Name = "dgvPrit";
            this.dgvPrit.RowTemplate.Height = 25;
            this.dgvPrit.Size = new System.Drawing.Size(667, 150);
            this.dgvPrit.TabIndex = 136;
            // 
            // btnMostar
            // 
            this.btnMostar.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._3844476_eye_see_show_view_watch_icon;
            this.btnMostar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostar.Location = new System.Drawing.Point(857, 256);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(113, 50);
            this.btnMostar.TabIndex = 135;
            this.btnMostar.Text = "Mostrar\r\n";
            this.btnMostar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click_1);
            // 
            // btnSiguienteReguistro
            // 
            this.btnSiguienteReguistro.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSiguienteReguistro.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._4829869_arrow_next_right_icon;
            this.btnSiguienteReguistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSiguienteReguistro.Location = new System.Drawing.Point(739, 256);
            this.btnSiguienteReguistro.Name = "btnSiguienteReguistro";
            this.btnSiguienteReguistro.Size = new System.Drawing.Size(112, 49);
            this.btnSiguienteReguistro.TabIndex = 134;
            this.btnSiguienteReguistro.Text = "Siguiente Registro";
            this.btnSiguienteReguistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSiguienteReguistro.UseVisualStyleBackColor = false;
            this.btnSiguienteReguistro.Click += new System.EventHandler(this.btnSiguienteReguistro_Click_1);
            // 
            // btnArbriArchivo
            // 
            this.btnArbriArchivo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnArbriArchivo.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._3643772_folder_archive_open_archives_document_icon;
            this.btnArbriArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArbriArchivo.Location = new System.Drawing.Point(612, 256);
            this.btnArbriArchivo.Name = "btnArbriArchivo";
            this.btnArbriArchivo.Size = new System.Drawing.Size(113, 50);
            this.btnArbriArchivo.TabIndex = 133;
            this.btnArbriArchivo.Text = "                    Abrir                  Archivo";
            this.btnArbriArchivo.UseVisualStyleBackColor = false;
            this.btnArbriArchivo.Click += new System.EventHandler(this.btnArbriArchivo_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRegistrar.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._134216_menu_lines_hamburger_icon;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(490, 258);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(116, 52);
            this.btnRegistrar.TabIndex = 132;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGuardarComo.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._285657_floppy_guardar_save_icon__1_;
            this.btnGuardarComo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarComo.Location = new System.Drawing.Point(375, 258);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(109, 52);
            this.btnGuardarComo.TabIndex = 131;
            this.btnGuardarComo.Text = "               Guardar         Como";
            this.btnGuardarComo.UseVisualStyleBackColor = false;
            this.btnGuardarComo.Click += new System.EventHandler(this.btnGuardarComo_Click_1);
            // 
            // txtPostre
            // 
            this.txtPostre.Location = new System.Drawing.Point(178, 485);
            this.txtPostre.Name = "txtPostre";
            this.txtPostre.Size = new System.Drawing.Size(128, 23);
            this.txtPostre.TabIndex = 130;
            this.txtPostre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostre_KeyPress);
            // 
            // lblPostre
            // 
            this.lblPostre.AutoSize = true;
            this.lblPostre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPostre.Location = new System.Drawing.Point(53, 488);
            this.lblPostre.Name = "lblPostre";
            this.lblPostre.Size = new System.Drawing.Size(43, 15);
            this.lblPostre.TabIndex = 129;
            this.lblPostre.Text = "Postre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AliceBlue;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(161, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 128;
            this.label9.Text = "Registrar ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(739, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 127;
            this.label8.Text = "Fruit Salad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(646, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 126;
            this.label7.Text = "Cup Cake";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(739, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 125;
            this.label6.Text = "Pasta Frola";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(646, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 124;
            this.label5.Text = "Ice Cream";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(674, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 123;
            this.label4.Text = "Postres";
            // 
            // lblRefresco
            // 
            this.lblRefresco.AutoSize = true;
            this.lblRefresco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRefresco.Location = new System.Drawing.Point(53, 457);
            this.lblRefresco.Name = "lblRefresco";
            this.lblRefresco.Size = new System.Drawing.Size(108, 15);
            this.lblRefresco.TabIndex = 122;
            this.lblRefresco.Text = "Refresco que  lleva:";
            // 
            // txtRefresco
            // 
            this.txtRefresco.Location = new System.Drawing.Point(178, 449);
            this.txtRefresco.Name = "txtRefresco";
            this.txtRefresco.Size = new System.Drawing.Size(128, 23);
            this.txtRefresco.TabIndex = 121;
            this.txtRefresco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefresco_KeyPress);
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(178, 409);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(128, 23);
            this.txtComida.TabIndex = 120;
            this.txtComida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComida_KeyPress);
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblComida.Location = new System.Drawing.Point(53, 417);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(102, 15);
            this.lblComida.TabIndex = 119;
            this.lblComida.Text = "Comida que lleva:";
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(178, 367);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(128, 23);
            this.txtRTN.TabIndex = 118;
            this.txtRTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRTN_KeyPress);
            // 
            // lblRTN
            // 
            this.lblRTN.AutoSize = true;
            this.lblRTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRTN.Location = new System.Drawing.Point(53, 375);
            this.lblRTN.Name = "lblRTN";
            this.lblRTN.Size = new System.Drawing.Size(53, 15);
            this.lblRTN.TabIndex = 117;
            this.lblRTN.Text = "Con RTN";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(178, 317);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 23);
            this.txtNombre.TabIndex = 116;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreCliente.Location = new System.Drawing.Point(53, 325);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(94, 15);
            this.lblNombreCliente.TabIndex = 115;
            this.lblNombreCliente.Text = "Nombre Cliente:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(178, 277);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 23);
            this.txtID.TabIndex = 114;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(53, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 113;
            this.label1.Text = "ID:";
            // 
            // lblFanta
            // 
            this.lblFanta.AutoSize = true;
            this.lblFanta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFanta.Location = new System.Drawing.Point(459, 123);
            this.lblFanta.Name = "lblFanta";
            this.lblFanta.Size = new System.Drawing.Size(66, 15);
            this.lblFanta.TabIndex = 112;
            this.lblFanta.Text = "Fanta 20lps";
            // 
            // lblSprite
            // 
            this.lblSprite.AutoSize = true;
            this.lblSprite.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSprite.Location = new System.Drawing.Point(458, 162);
            this.lblSprite.Name = "lblSprite";
            this.lblSprite.Size = new System.Drawing.Size(67, 15);
            this.lblSprite.TabIndex = 111;
            this.lblSprite.Text = "Sprite 20lps";
            // 
            // lblFresca
            // 
            this.lblFresca.AutoSize = true;
            this.lblFresca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFresca.Location = new System.Drawing.Point(337, 162);
            this.lblFresca.Name = "lblFresca";
            this.lblFresca.Size = new System.Drawing.Size(70, 15);
            this.lblFresca.TabIndex = 110;
            this.lblFresca.Text = "Fresca 20lps";
            // 
            // lblCocacola
            // 
            this.lblCocacola.AutoSize = true;
            this.lblCocacola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCocacola.Location = new System.Drawing.Point(337, 123);
            this.lblCocacola.Name = "lblCocacola";
            this.lblCocacola.Size = new System.Drawing.Size(91, 15);
            this.lblCocacola.TabIndex = 109;
            this.lblCocacola.Text = "Coca Cola 20lps";
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPizza.Location = new System.Drawing.Point(36, 211);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(102, 15);
            this.lblPizza.TabIndex = 108;
            this.lblPizza.Text = "Pizza casera: 35lps";
            // 
            // lblPupusas
            // 
            this.lblPupusas.AutoSize = true;
            this.lblPupusas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPupusas.Location = new System.Drawing.Point(148, 171);
            this.lblPupusas.Name = "lblPupusas";
            this.lblPupusas.Size = new System.Drawing.Size(84, 15);
            this.lblPupusas.TabIndex = 107;
            this.lblPupusas.Text = "Pupusas: 22lps";
            // 
            // lblChuleta
            // 
            this.lblChuleta.AutoSize = true;
            this.lblChuleta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblChuleta.Location = new System.Drawing.Point(36, 171);
            this.lblChuleta.Name = "lblChuleta";
            this.lblChuleta.Size = new System.Drawing.Size(81, 15);
            this.lblChuleta.TabIndex = 106;
            this.lblChuleta.Text = "Chuleta: 60lps";
            // 
            // lblBaledas
            // 
            this.lblBaledas.AutoSize = true;
            this.lblBaledas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBaledas.Location = new System.Drawing.Point(148, 126);
            this.lblBaledas.Name = "lblBaledas";
            this.lblBaledas.Size = new System.Drawing.Size(89, 15);
            this.lblBaledas.TabIndex = 105;
            this.lblBaledas.Text = "Baleadas: 25 lps";
            // 
            // lblEmpadas
            // 
            this.lblEmpadas.AutoSize = true;
            this.lblEmpadas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmpadas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpadas.Location = new System.Drawing.Point(36, 126);
            this.lblEmpadas.Name = "lblEmpadas";
            this.lblEmpadas.Size = new System.Drawing.Size(91, 15);
            this.lblEmpadas.TabIndex = 104;
            this.lblEmpadas.Text = "Empadas:  28lps";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(347, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Refrescos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Comida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(36, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 20);
            this.label10.TabIndex = 101;
            this.label10.Text = "Que desea Ordenar";
            // 
            // btnSleccionar
            // 
            this.btnSleccionar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSleccionar.Image = global::PI_2022_I_P3_PROYECTO3.Properties.Resources._9042663_open_select_hand_gesture_icon1;
            this.btnSleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSleccionar.Location = new System.Drawing.Point(989, 256);
            this.btnSleccionar.Name = "btnSleccionar";
            this.btnSleccionar.Size = new System.Drawing.Size(119, 49);
            this.btnSleccionar.TabIndex = 138;
            this.btnSleccionar.Text = "            Seleccionar";
            this.btnSleccionar.UseVisualStyleBackColor = false;
            this.btnSleccionar.Click += new System.EventHandler(this.btnSleccionar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AliceBlue;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(867, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 139;
            this.label11.Text = "Nombre Cliente:";
            // 
            // cboClienteN
            // 
            this.cboClienteN.FormattingEnabled = true;
            this.cboClienteN.Location = new System.Drawing.Point(976, 176);
            this.cboClienteN.Name = "cboClienteN";
            this.cboClienteN.Size = new System.Drawing.Size(132, 23);
            this.cboClienteN.TabIndex = 140;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1120, 594);
            this.Controls.Add(this.cboClienteN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSleccionar);
            this.Controls.Add(this.dgvPrit);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.btnSiguienteReguistro);
            this.Controls.Add(this.btnArbriArchivo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.txtPostre);
            this.Controls.Add(this.lblPostre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRefresco);
            this.Controls.Add(this.txtRefresco);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.lblRTN);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFanta);
            this.Controls.Add(this.lblSprite);
            this.Controls.Add(this.lblFresca);
            this.Controls.Add(this.lblCocacola);
            this.Controls.Add(this.lblPizza);
            this.Controls.Add(this.lblPupusas);
            this.Controls.Add(this.lblChuleta);
            this.Controls.Add(this.lblBaledas);
            this.Controls.Add(this.lblEmpadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem regresarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private PictureBox pictureBox1;
        private DataGridView dgvPrit;
        private Button btnMostar;
        private Button btnSiguienteReguistro;
        private Button btnArbriArchivo;
        private Button btnRegistrar;
        private Button btnGuardarComo;
        private TextBox txtPostre;
        private Label lblPostre;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblRefresco;
        private TextBox txtRefresco;
        private TextBox txtComida;
        private Label lblComida;
        private TextBox txtRTN;
        private Label lblRTN;
        private TextBox txtNombre;
        private Label lblNombreCliente;
        private TextBox txtID;
        private Label label1;
        private Label lblFanta;
        private Label lblSprite;
        private Label lblFresca;
        private Label lblCocacola;
        private Label lblPizza;
        private Label lblPupusas;
        private Label lblChuleta;
        private Label lblBaledas;
        private Label lblEmpadas;
        private Label label3;
        private Label label2;
        private Label label10;
        private Button btnSleccionar;
        private Label label11;
        private ComboBox cboClienteN;
    }
}
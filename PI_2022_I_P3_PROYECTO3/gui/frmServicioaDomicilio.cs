using PI_2022_I_P3_PROYECTO3.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_2022_I_P3_PROYECTO3.gui
{
    public partial class frmServicioaDomicilio : Form
    {

        protected int contadorTextBox { get; set; } = 7;
        List<RestauranteServicioaDomicilio> regsitroGrid = new List<RestauranteServicioaDomicilio>();
        List<ComboBoxItem> registroComo = new List<ComboBoxItem>();
        private StreamWriter archivoWriter;
        private StreamReader archivoReader;
        enum IndicesTextBox
        {
            ID,
            Nombre,
            NumeroTelefono,
            Comida,
            Direccion,
            CorreoElectronico,
            TarjetaoEfectivo
        }
        public frmServicioaDomicilio()
        {
            InitializeComponent();
        }

        public void LimpiartTextbox()
        {
            foreach (Control ControlGUI in Controls)
            {
                (ControlGUI as TextBox)?.Clear();
            }
        }

        public string[] ObtenerValoresTextBox()
        {
            return new string[]
            {
                txtID.Text,
                txtNombre.Text, 
                txtTelefono.Text,
                txtComida.Text,
                txtDireccion.Text,
                txtCorreo.Text, 
                txtTarjetaoEfectivo.Text
            };

        }

        private void frmServicioaDomicilio_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                archivoWriter?.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("NO SE PUEDE CERRAR EL ARCHIVO ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Application.Exit();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRestaurante From = new frmRestaurante();
            From.Show();
        }

        private void btnGuardarRegristro_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string nombreArchivo;
            using (var ArchivoSeleccionado = new SaveFileDialog())
            {
                ArchivoSeleccionado.CheckFileExists = false;
                result = ArchivoSeleccionado.ShowDialog();
                nombreArchivo = ArchivoSeleccionado.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(nombreArchivo))
                {
                    MessageBox.Show("Nombre de archivo invalido,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var salida = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
                        archivoWriter = new StreamWriter(salida);
                        btnGuardarComo.Enabled = false;
                        btnRegistrarCliente.Enabled = true;
                    }
                    catch (IOException)
                    {

                        MessageBox.Show("Error ABRIEndo el archivo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        { 
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string nombreArchivo;
            using (var ArchivoSeleccionado = new SaveFileDialog())
            {
                ArchivoSeleccionado.CheckFileExists = false;
                result = ArchivoSeleccionado.ShowDialog();
                nombreArchivo = ArchivoSeleccionado.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(nombreArchivo))
                {
                    MessageBox.Show("Nombre de archivo invalido,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var salida = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
                        archivoWriter = new StreamWriter(salida);
                        btnGuardarComo.Enabled = false;
                        btnRegistrarCliente.Enabled = true;
                    }
                    catch (IOException)
                    {

                        MessageBox.Show("Error ABRIEndo el archivo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void btnGuardarComo_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string nombreArchivo;
            using (var ArchivoSeleccionado = new SaveFileDialog())
            {
                ArchivoSeleccionado.CheckFileExists = false;
                result = ArchivoSeleccionado.ShowDialog();
                nombreArchivo = ArchivoSeleccionado.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(nombreArchivo))
                {
                    MessageBox.Show("Nombre de archivo invalido,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var salida = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
                        archivoWriter = new StreamWriter(salida);
                        btnGuardarComo.Enabled = false;
                        btnRegistrarCliente.Enabled = true;
                    }
                    catch (IOException)
                    {

                        MessageBox.Show("Error ABRIEndo el archivo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void btnRegistrarCliente_Click_1(object sender, EventArgs e)
        {
            string[] valores = ObtenerValoresTextBox();
            if (!string.IsNullOrEmpty(valores[(int)IndicesTextBox.ID]))
            {
                try
                {
                    int Numeroid = int.Parse(valores[(int)IndicesTextBox.ID]);
                    if (Numeroid > 0)
                    {
                        var cuenta = new RestauranteServicioaDomicilio(
                            Numeroid,
                            valores[(int)IndicesTextBox.Nombre],
                            valores[(int)IndicesTextBox.NumeroTelefono],
                            valores[(int)IndicesTextBox.Comida],
                            valores[(int)IndicesTextBox.Direccion],
                            valores[(int)IndicesTextBox.CorreoElectronico],
                            valores[(int)IndicesTextBox.TarjetaoEfectivo]

                            );
                        archivoWriter.WriteLine(
                            $"{cuenta.ID},{cuenta.NombreCliente},{cuenta.NumeroTelefono},{cuenta.Comidaquelleva},{cuenta.Direccion},{cuenta.CorreoElectronico}," +
                            $"{cuenta.TarjetaoEfectivo}");
                    }
                    else
                        MessageBox.Show("Numero de  cuenta  invalido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException)
                {
                    MessageBox.Show(" Errror escribiendo el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato invaliddo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtID.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "" || txtComida.Text == "" || txtDireccion.Text==""
                    || txtCorreo.Text==""|| txtTarjetaoEfectivo.Text=="")
                {
                    MessageBox.Show("por favor llenar los el espacio en blaco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Datos registrados correctamente!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiartTextbox();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirArchivo_Click_1(object sender, EventArgs e)
        {
            DialogResult Resultado;
            string nombreArchivo;
            using (OpenFileDialog archivoSeleccionado = new OpenFileDialog())
            {
                Resultado = archivoSeleccionado.ShowDialog();
                nombreArchivo = archivoSeleccionado.FileName;
            }
            if (Resultado == DialogResult.OK)
            {
                LimpiartTextbox();
                if (string.IsNullOrEmpty(nombreArchivo))
                {
                    MessageBox.Show("Nombre de archivo Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    try
                    {
                        FileStream entrada = new FileStream(
                           nombreArchivo, FileMode.Open, FileAccess.Read);
                        archivoReader = new StreamReader(entrada);
                        btnAbrirArchivo.Enabled = false;
                        btnSiguienteRegistro.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error abriendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }

        private void btnSiguienteRegistro_Click(object sender, EventArgs e)
        {
            try
            {

                var registroEntrada = archivoReader.ReadLine();
                if (registroEntrada != null)
                {
                    string[] entradacampo = registroEntrada.Split(',');
                    SetearValoresTextBox(entradacampo);
                }
                else
                {
                    archivoReader.Close();
                    btnAbrirArchivo.Enabled = true; btnSiguienteRegistro.Enabled = false;
                    LimpiartTextbox();
                    MessageBox.Show("No  tiene mas  registro enelarachivo", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {

                MessageBox.Show("Error Leyendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetearValoresTextBox(string[] valores)
        {
            if (valores.Length != contadorTextBox)
                throw (new ArgumentException(
                  $"Deberia de ser  {contadorTextBox} Elementos del  Arreglo", nameof(valores)));
            else
            {
                txtID.Text              = valores[(int)IndicesTextBox.ID];
                txtNombre.Text          = valores[(int)IndicesTextBox.Nombre];
                txtTelefono.Text        = valores[(int)IndicesTextBox.NumeroTelefono];
                txtComida.Text          = valores[(int)IndicesTextBox.Comida];
                txtDireccion.Text       = valores[(int)IndicesTextBox.Direccion];
                txtCorreo.Text          = valores[(int)IndicesTextBox.CorreoElectronico];
                txtTarjetaoEfectivo.Text = valores[(int)IndicesTextBox.TarjetaoEfectivo];
                regsitroGrid.Add(new RestauranteServicioaDomicilio(
                    Convert.ToInt32(txtID.Text),
                    txtNombre.Text,
                    txtTelefono.Text,
                    txtComida.Text,
                    txtDireccion.Text,
                    txtCorreo.Text,
                    txtTarjetaoEfectivo.Text));

                registroComo.Add(new ComboBoxItem(
                    txtNombre.Text, txtID.Text));
            }
        }

        private void bntMostrar_Click(object sender, EventArgs e)
        {
            dgvView.DataSource = regsitroGrid;
            cboPorte.DisplayMember = "Text";
            cboPorte.ValueMember = "Value";
            cboPorte.DataSource = registroComo;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int FilaSeleccionada = dgvView.CurrentCell.RowIndex;
            MessageBox.Show($"Grid {dgvView.Rows[FilaSeleccionada].Cells[0].Value}");

            ComboBoxItem itemSeleccionado = (ComboBoxItem)cboPorte.SelectedItem;
            int valoresSeleccionado = Convert.ToInt32(itemSeleccionado.Value);
            MessageBox.Show($"El nombre seleccionado es:{itemSeleccionado} y el ID:{valoresSeleccionado}");
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtComida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtTarjetaoEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
    }
    }


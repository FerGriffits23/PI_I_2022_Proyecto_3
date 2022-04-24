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
    public partial class frmCliente : Form
    {
        protected int contadorTextBox { get; set; } = 7;
        List<RestautranteCliente> registrosGrid = new List<RestautranteCliente>();
        List<ComboBoxItem> registrocombo = new List<ComboBoxItem>(); 
        private StreamWriter archivoWriter;
        private StreamReader archivoReader;
        enum IndicesTextBox
        {
            ID,
            Cliente,
            NombreCliente,
            ApellidoCliente,
            NumeroTelefono,
            RTN,
            CorreoElectronico,
        }

        public frmCliente()
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
            txtCliente.Text, 
            txtNombreCliente.Text,
            txtApellidoCliente.Text,
            txtNumeroTelefono.Text,
            txtRTN.Text,
            txtCorreo.Text,

            };
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

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void regresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRestaurante From = new frmRestaurante();
            From.Show();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnGuardarComo_Click(object sender, EventArgs e)
        {

            DialogResult result;
            string nombrearchivo;
            using (var archivoSeleccionado = new SaveFileDialog())
            {
                archivoSeleccionado.CheckFileExists = false;
                result = archivoSeleccionado.ShowDialog();
                nombrearchivo = archivoSeleccionado.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(nombrearchivo))
                {
                    MessageBox.Show("Nombre de Archivo invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var salir = new FileStream(nombrearchivo, FileMode.OpenOrCreate, FileAccess.Write);
                        archivoWriter = new StreamWriter(salir);
                        btnGuardarComo.Enabled = false;
                        btnRegistrarCliente.Enabled = true;

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error abriendo el Archivo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            string[] valores = ObtenerValoresTextBox();
            if (!string.IsNullOrEmpty(valores[(int)IndicesTextBox.ID]))
            {
                try
                {
                    int NumeroId = int.Parse(valores[(int)IndicesTextBox.ID]);
                    if (NumeroId > 0)
                    {
                        var cuenta = new RestautranteCliente(
                            NumeroId,
                            valores[(int)IndicesTextBox.Cliente],
                            valores[(int)IndicesTextBox.NombreCliente],
                            valores[(int)IndicesTextBox.ApellidoCliente],
                            valores[(int)IndicesTextBox.NumeroTelefono],
                            valores[(int)IndicesTextBox.RTN],
                            valores[(int)IndicesTextBox.CorreoElectronico]
                            );
                        archivoWriter.WriteLine(
                            $"{cuenta.ID}, {cuenta.Cliente}, {cuenta.NombreCliente},{cuenta.ApellidoCliente}," +
                            $"{cuenta.NumeroTelefono},{cuenta.RTN},{cuenta.CorreoElectronico}"
                            );
                    }
                    else
                    {
                        MessageBox.Show("Numero de ID invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Escribiendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato Invalido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtID.Text == "" || txtCliente.Text == "" || txtNombreCliente.Text == "" || txtApellidoCliente.Text == "" || txtNumeroTelefono.Text == "" 
                    || txtRTN.Text=="" || txtCorreo.Text=="")
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

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void btnAbrirarchivo_Click(object sender, EventArgs e)
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
                    txtCliente.Text         = valores[(int)IndicesTextBox.Cliente];
                    txtNombreCliente.Text   = valores[(int)IndicesTextBox.NombreCliente];
                    txtApellidoCliente.Text = valores[(int)IndicesTextBox.ApellidoCliente];
                    txtNumeroTelefono.Text  = valores[(int)IndicesTextBox.NumeroTelefono];
                    txtRTN.Text             = valores[(int)IndicesTextBox.RTN];
                    txtCorreo.Text          = valores[(int)IndicesTextBox.CorreoElectronico];
                registrosGrid.Add(new RestautranteCliente(
                    Convert.ToInt32(txtID.Text),
                    txtCliente.Text,
                    txtNombreCliente.Text,
                    txtApellidoCliente.Text,
                    txtNumeroTelefono.Text,
                    txtRTN.Text,
                    txtCorreo.Text));

                registrocombo.Add(new ComboBoxItem(
                         txtNombreCliente.Text, txtID.Text));
                    
            }
            }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvClienteprimero.DataSource = registrosGrid;
            cboIDCliente.DisplayMember = "Text";
            cboIDCliente.ValueMember = "Value";
            cboIDCliente.DataSource = registrocombo;

        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int FilaSeleccionada = dgvClienteprimero.CurrentCell.RowIndex;
            MessageBox.Show($"Grid {dgvClienteprimero.Rows[FilaSeleccionada].Cells[0].Value}");

            ComboBoxItem itemSeleccionado = (ComboBoxItem)cboIDCliente.SelectedItem;
            int valorSeleccionado = Convert.ToInt32(itemSeleccionado.Value);
            MessageBox.Show($"EL nombre Seleccionado {itemSeleccionado} y el ID {valorSeleccionado}");
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
    }
    }

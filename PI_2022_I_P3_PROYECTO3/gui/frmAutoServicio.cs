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
    public partial class frmAutoServicio : Form
    {
        protected int ContadorTextBox { get; set; } = 8;
        List<AutoServicio> registroGrid = new List<AutoServicio>(); 
        List<ComboBoxItem> registorCombo = new List<ComboBoxItem>();
        StreamWriter archivoWriter;
        StreamReader archivoReader;
        enum IndicesTextBox
        {
            ID,
            Nombre,
            Cliente,
            RTN,
            Comida,
            Refrescos,
            Postre,
            Fundacion

        }
        public frmAutoServicio()
        {
            InitializeComponent();
        }

        public void LimpiarTextBox() 
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
            txtNombre_1.Text,
            txtCliente.Text,
            txtRTN.Text,
            txtComida.Text,
            txtRefresco.Text,
            txtPostre.Text,
            txtFundacion.Text

            };
        }

        private void btnGuardaComo_Click(object sender, EventArgs e)
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
                        btnGuardaComo.Enabled = false;
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
                        var cuenta = new AutoServicio(
                            NumeroId,
                            valores[(int)IndicesTextBox.Cliente],
                            valores[(int)IndicesTextBox.Nombre],
                            valores[(int)IndicesTextBox.RTN],
                            valores[(int)IndicesTextBox.Comida],
                            valores[(int)IndicesTextBox.Refrescos],
                            valores[(int)IndicesTextBox.Postre],
                            valores[(int)IndicesTextBox.Fundacion]
                            ) ;
                        archivoWriter.WriteLine(
                            $"{cuenta.ID},{cuenta.Nombre3},{cuenta.NombreCliente},{cuenta.RTN},{cuenta.Comida},{cuenta.Fresco}," +
                            $"{cuenta.Postre},{cuenta.Fundacion}"
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
                if (txtID.Text == "" || txtNombre_1.Text == "" || txtCliente.Text == "" || txtRTN.Text == "" || txtComida.Text == ""
                   || txtRefresco.Text == "" || txtPostre.Text == "" || txtFundacion.Text=="")
                {
                    MessageBox.Show("por favor llenar los el espacio en blaco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Datos registrados correctamente!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimpiarTextBox();
            }
           
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
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
                LimpiarTextBox();
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
                        btnRegistrarCliente.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error abriendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        private void btnSiguienteReguistro_Click(object sender, EventArgs e)
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
                    btnAbrirArchivo.Enabled = true; btnRegistrarCliente.Enabled = false;
                    LimpiarTextBox();
                    MessageBox.Show("No  tiene mas  registro en el Archivo", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {

                MessageBox.Show("Error Leyendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetearValoresTextBox(string[] valores)
        {
            if (valores.Length != ContadorTextBox)
                throw (new ArgumentException(
                  $"Deberia de ser  {ContadorTextBox} Elementos del  Arreglo", nameof(valores)));
            else
            {
                txtID.Text              = valores[(int)IndicesTextBox.ID];
                txtNombre_1.Text        = valores[(int)IndicesTextBox.Nombre];
                txtCliente.Text         = valores[(int)IndicesTextBox.Cliente];
                txtRTN.Text             = valores[(int)IndicesTextBox.RTN];
                txtComida.Text          = valores[(int)IndicesTextBox.Comida];
                txtRefresco.Text        = valores[(int)IndicesTextBox.Refrescos];
                txtPostre.Text          = valores[(int)IndicesTextBox.Postre];
                txtFundacion.Text       = valores[(int)IndicesTextBox.Fundacion];
                registroGrid.Add(new AutoServicio(
                    Convert.ToInt32(txtID.Text),
                    txtNombre_1.Text,
                    txtCliente.Text,
                    txtRTN.Text,
                    txtComida.Text,
                    txtRefresco.Text,
                    txtPostre.Text,
                    txtFundacion.Text));

                registorCombo.Add(new ComboBoxItem(
                   txtCliente.Text ,txtID.Text));
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvRit.DataSource = registroGrid;
            cboCool.DisplayMember = "Text";
            cboCool.ValueMember = "Value";
            cboCool.DataSource = registorCombo;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                archivoWriter?.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("No se puede cerrar el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            Application.Exit();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRestaurante From = new frmRestaurante();
            From.Show();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            int FilaSeleccionada = dgvRit.CurrentCell.RowIndex;
            MessageBox.Show($"Grid {dgvRit.Rows[FilaSeleccionada].Cells[0].Value}");

            ComboBoxItem itemSeleccionado = (ComboBoxItem)cboCool.SelectedItem;
            int valoresSeleccionado = Convert.ToInt32(itemSeleccionado.Value);
            MessageBox.Show($"El nombre seleccionado es:{itemSeleccionado} y el ID:{valoresSeleccionado}");
        }

        private void txtNombre_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        private void txtNombre_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtComida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txtRefresco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txtPostre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txtFundacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
    }

}

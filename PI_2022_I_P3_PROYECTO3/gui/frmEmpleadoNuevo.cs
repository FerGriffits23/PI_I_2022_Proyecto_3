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
    public partial class frmEmpleadoNuevo : Form
    {
        protected int ContadorTextBox { get; set; } = 8;
        List<RestauranteEmpleado> registroGrid = new List<RestauranteEmpleado>();
        List<ComboBoxItem> registrocombo = new List<ComboBoxItem>();
        StreamReader archivoReader;
        StreamWriter archivoWriter;

        public frmEmpleadoNuevo()
        {
            InitializeComponent();
        }
        enum IndicesTextBox
        {
            ID,
            Empleado,
            NombreEmpleado,
            ApellidoEmpleado,
            Edad,
            Sexo,
            FechaNacimiento,
            Experiencia
        }

        public void LimpiarTextBox() 
        {
            foreach (Control ControGUI in Controls)
            {
                (ControGUI as TextBox)?.Clear();
            }
       }
        public string[] ObtenerValoresTextBox()
        {
            return new string[]
            {
            txtID.Text,
            txtEmpleado.Text,
            txtNombre.Text,
            txtApellido.Text,
            txtEdad.Text,
            txtSexo.Text,
            txtNacimento.Text,
            txtExperincia.Text

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
                MessageBox.Show("Error al salir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRestaurante Form = new frmRestaurante();
            Form.Show();
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
                        btnReguistarEmpleado.Enabled = true;

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error abriendo el Archivo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btnReguistarEmpleado_Click(object sender, EventArgs e)
        {
            string[] valores = ObtenerValoresTextBox();
            if (!string.IsNullOrEmpty(valores[(int)IndicesTextBox.ID]))
            {
                try
                {
                    int NumeroId = int.Parse(valores[(int)IndicesTextBox.ID]);
                    if (NumeroId > 0)
                    {
                        var cuenta = new RestauranteEmpleado(
                            NumeroId,
                            valores[(int)IndicesTextBox.Empleado],
                            valores[(int)IndicesTextBox.NombreEmpleado],
                            valores[(int)IndicesTextBox.ApellidoEmpleado],
                            valores[(int)IndicesTextBox.Edad],
                            valores[(int)IndicesTextBox.Sexo],
                            valores[(int)IndicesTextBox.FechaNacimiento],
                            valores[(int)IndicesTextBox.Experiencia]
                            );
                        archivoWriter.WriteLine(
                            $"{cuenta.ID}, {cuenta.Cliente}, {cuenta.NombreCliente},{cuenta.ApellidoCliente}," +
                            $"{cuenta.Edad},{cuenta.Sexo},{cuenta.Nacimiento}, {cuenta.Experiencia}"
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
                if (txtID.Text == "" || txtEmpleado.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtEdad.Text == ""
                   || txtSexo.Text == "" || txtNacimento.Text == "" || txtExperincia.Text=="")
                {
                    MessageBox.Show("por favor llenar los el espacio en blaco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Datos registrados correctamente!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        btnSiguienteReguistro.Enabled = true;
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
                    btnAbrirArchivo.Enabled = true; btnSiguienteReguistro.Enabled = false;
                    LimpiarTextBox();
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
            if (valores.Length != ContadorTextBox)
                throw (new ArgumentException(
                  $"Deberia de ser  {ContadorTextBox} Elementos del  Arreglo", nameof(valores)));
            else
            {
                txtID.Text          = valores[(int)IndicesTextBox.ID];
                txtEmpleado.Text    = valores[(int)IndicesTextBox.Empleado];
                txtNombre.Text      = valores[(int)IndicesTextBox.NombreEmpleado];
                txtApellido.Text    = valores[(int)IndicesTextBox.ApellidoEmpleado];
                txtEdad.Text        = valores[(int)IndicesTextBox.Edad];
                txtSexo.Text        = valores[(int)IndicesTextBox.Sexo];
                txtNacimento.Text   = valores[(int)IndicesTextBox.FechaNacimiento];
                txtExperincia.Text  = valores[(int)IndicesTextBox.Experiencia];
                registroGrid.Add(new RestauranteEmpleado(
                    Convert.ToInt32(txtID.Text),
                    txtEmpleado.Text,
                    txtNombre.Text,
                    txtApellido.Text,
                    txtEdad.Text,
                    txtSexo.Text,
                    txtNacimento.Text,
                    txtExperincia.Text));

                registrocombo.Add(new ComboBoxItem(
                    txtNombre.Text, txtID.Text));
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvPorte.DataSource = registroGrid;
            cboNombreone.DisplayMember = "Text";
            cboNombreone.ValueMember = "Value";
            cboNombreone.DataSource = registrocombo;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int FilaSeleccionada = dgvPorte.CurrentCell.RowIndex;
            MessageBox.Show($"Grid {dgvPorte.Rows[FilaSeleccionada].Cells[0].Value}");

            ComboBoxItem itemSeleccionado = (ComboBoxItem)cboNombreone.SelectedItem;
            int valoresSeleccionado = Convert.ToInt32(itemSeleccionado.Value);
            MessageBox.Show($"El nombre seleccionado es:{itemSeleccionado} y el ID:{valoresSeleccionado}");
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txtNacimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txtExperincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
    }
}
